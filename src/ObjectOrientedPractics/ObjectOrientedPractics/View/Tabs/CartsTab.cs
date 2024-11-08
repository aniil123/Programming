using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CartsTab : UserControl
    {
        List<Model.Item> _items;
        List<Model.Customer> _customers;
        int saveSelectedIndex = -1;
        public List<Model.Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
                ItemsListBox.Items.Clear();
                foreach(var i in _items)
                {
                    ItemsListBox.Items.Add(i.Name);
                }
            }
        }
        public List<Model.Customer> Customers
        {
            get
            {
                return _customers;
            }
            set
            {
                _customers = value;
                CustomerComboBox.Items.Clear();
                foreach(var i in _customers)
                {
                    CustomerComboBox.Items.Add(i.FullName);
                }
            }
        }
        private Model.Item CurrentItem
        {
            get
            {
                return _items[ItemsListBox.SelectedIndex];
            }
        }
        private Model.Customer CurrentCustomer
        {
            get
            {
                return _customers[CustomerComboBox.SelectedIndex];
            }
        }
        public CartsTab()
        {
            InitializeComponent();
            CustomerComboBox.SelectedIndexChanged += CustomerComboBox_SelectedIndexChanged;
            AddToCartButton.Click += AddToCartButton_Click;
            RemoveItemButton.Click += RemoveItemButton_Click;
            ClearCartButton.Click += ClearCartButton_Click;
            TotalCostLabel.SizeChanged += TotalCostLabel_SizeChanged;
            CreateOrderButton.Click += CreateOrderButton_Click;
        }
        public void RefreshData()
        {
            ItemsListBox.Items.Clear();
            foreach(var i in Items)
            {
                ItemsListBox.Items.Add(i.Name);
            }
            CustomerComboBox.Items.Clear();
            foreach (var i in Customers)
            {
                CustomerComboBox.Items.Add(i.FullName);
            }
            CustomerComboBox.SelectedIndex = saveSelectedIndex;
            if (CustomerComboBox.SelectedIndex != -1)
            {
                CartListBox.Items.Clear();
                foreach (var i in CurrentCustomer.Cart.Items)
                {
                    CartListBox.Items.Add(i.Name);
                }
            }
        }
        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomerComboBox.SelectedIndex != -1)
            {
                saveSelectedIndex = CustomerComboBox.SelectedIndex;
                CartListBox.Items.Clear();
                foreach (var i in CurrentCustomer.Cart.Items)
                {
                    CartListBox.Items.Add(i.Name);
                }
                CostUpdate();
            }
            else
            {
                CartListBox.Items.Clear();
                TotalCostLabel.Text = "";
            }
        }
        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if(ItemsListBox.SelectedIndex != -1 && CustomerComboBox.SelectedIndex != -1)
            {
                CurrentCustomer.Cart.Items.Add(CurrentItem);
                CartListBox.Items.Add(CurrentItem.Name);
                CostUpdate();
            }
        }
        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if(CustomerComboBox.SelectedIndex != -1 && CartListBox.SelectedIndex != -1)
            {
                CurrentCustomer.Cart.Items.RemoveAt(CartListBox.SelectedIndex);
                CartListBox.Items.RemoveAt(CartListBox.SelectedIndex);
                CostUpdate();
            }
        }
        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            CurrentCustomer.Cart.Items.Clear();
            CartListBox.Items.Clear();
            CostUpdate();
        }
        private void TotalCostLabel_SizeChanged(object sender, EventArgs e)
        {
            TotalCostLabel.Left = 743 - TotalCostLabel.Width;
        }
        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if (CartListBox.Items.Count != 0)
            {
                int index = CurrentCustomer.Address.Index;
                string country = CurrentCustomer.Address.Country;
                string city = CurrentCustomer.Address.City;
                string street = CurrentCustomer.Address.Street;
                string building = CurrentCustomer.Address.Building;
                string apartment = CurrentCustomer.Address.Apartment;
                string date = new Random().Next(1, 9).ToString() + "." + new Random().Next(1, 12).ToString() + "." + new Random().Next(2001, 2025).ToString();
                CurrentCustomer.Orders.Add(new Model.Order(index, country, city, street, building, apartment, date, CurrentCustomer.Cart.Items, OrderStatus.New));
                CurrentCustomer.Cart.Items.Clear();
                CartListBox.Items.Clear();
                CostUpdate();
            }
        }
        private void CostUpdate()
        {
            TotalCostLabel.Text = CurrentCustomer.Cart.Amount.ToString();
        }
    }
}

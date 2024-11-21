using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model.Orders;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CartsTab : UserControl
    {
        public event EventHandler<EventArgs> OrdersChanged;
        List<Model.Item> _items;
        List<Model.Customer> _customers;
        public List<Model.Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                if (value != null)
                {
                    _items = value;
                    ItemsListBox.Items.Clear();
                    foreach (var i in _items)
                    {
                        ItemsListBox.Items.Add(i.Name);
                    }
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
                if (value != null)
                {
                    _customers = value;
                    CustomerComboBox.Items.Clear();
                    foreach (var i in _customers)
                    {
                        CustomerComboBox.Items.Add(i.FullName);
                    }
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
            CostLabel.SizeChanged += CostLabel_SizeChanged;
            DiscountLabel.SizeChanged += DiscountLabel_SizeChanged;
            TotalCostLabel.SizeChanged += TotalCostLabel_SizeChanged;
            CreateOrderButton.Click += CreateOrderButton_Click;
            DiscountsCheckedListBox.SelectedIndexChanged += DiscountsCheckedListBox_SelectedIndexChanged;
        }
        public void RefreshData()
        {
            ItemsListBox.Items.Clear();
            foreach(var i in Items)
            {
                ItemsListBox.Items.Add(i.Name);
            }
            CustomerComboBox.SelectedIndex = -1;
            CustomerComboBox.Items.Clear();
            foreach (var i in Customers)
            {
                CustomerComboBox.Items.Add(i.FullName);
            }
        }
        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomerComboBox.SelectedIndex != -1)
            {
                CartListBox.Items.Clear();
                for (int i = 0;i < CurrentCustomer.Cart.Items.Count;i++)
                {
                    if (!CurrentCustomer.Cart.Items[i].Active)
                    {
                        CurrentCustomer.Cart.Items.RemoveAt(i);
                        i--;
                        continue;
                    }
                    CartListBox.Items.Add(CurrentCustomer.Cart.Items[i].Name);
                }
                DiscountsCheckedListBox.Items.Clear();
                foreach(var i in CurrentCustomer.Discounts)
                {
                    DiscountsCheckedListBox.Items.Add(i.Info);
                }
                for(int i = 0;i < DiscountsCheckedListBox.Items.Count;i++)
                {
                    DiscountsCheckedListBox.SetItemChecked(i, true);
                }
                Update();
            }
            else
            {
                CartListBox.Items.Clear();
                CostLabel.Text = "0";
                DiscountsCheckedListBox.Items.Clear();
                DiscountLabel.Text = "0";
                TotalCostLabel.Text = "0";
            }
        }
        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if(ItemsListBox.SelectedIndex != -1 && CustomerComboBox.SelectedIndex != -1)
            {
                CurrentCustomer.Cart.Items.Add(CurrentItem);
                CartListBox.Items.Add(CurrentItem.Name);
                Update();
            }
        }
        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if(CustomerComboBox.SelectedIndex != -1 && CartListBox.SelectedIndex != -1)
            {
                CurrentCustomer.Cart.Items.RemoveAt(CartListBox.SelectedIndex);
                CartListBox.Items.RemoveAt(CartListBox.SelectedIndex);
                Update();
            }
        }
        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            CurrentCustomer.Cart.Items.Clear();
            CartListBox.Items.Clear();
            Update();
        }
        private void CostLabel_SizeChanged(object sender, EventArgs e)
        {
            CostLabel.Left = 743 - CostLabel.Width;
        }
        private void DiscountLabel_SizeChanged(object sender, EventArgs e)
        {
            DiscountLabel.Left = 743 - DiscountLabel.Width;
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
                if (CurrentCustomer.IsPriority)
                {
                    CurrentCustomer.Orders.Add(new PriorityOrder(index, country, city, street, building, apartment, date, CurrentCustomer.Cart.Items, OrderStatus.New));
                }
                else
                {
                    CurrentCustomer.Orders.Add(new Order(index, country, city, street, building, apartment, date, CurrentCustomer.Cart.Items, OrderStatus.New));
                }
                for (int i = 0;i < CurrentCustomer.Discounts.Count;i++)
                {
                    if (DiscountsCheckedListBox.GetItemChecked(i))
                    {
                        CurrentCustomer.Discounts[i].Apply(CurrentCustomer.Orders[CurrentCustomer.Orders.Count - 1].Items);
                    }
                    CurrentCustomer.Discounts[i].Update(CurrentCustomer.Orders[CurrentCustomer.Orders.Count - 1].Items);
                }
                bool[] statusOfDiscounts = new bool[DiscountsCheckedListBox.Items.Count];
                for(int i = 0;i < DiscountsCheckedListBox.Items.Count;i++)
                {
                    statusOfDiscounts[i] = DiscountsCheckedListBox.GetItemChecked(i);
                }
                DiscountsCheckedListBox.Items.Clear();
                foreach (var i in CurrentCustomer.Discounts)
                {
                    DiscountsCheckedListBox.Items.Add(i.Info);
                }
                for (int i = 0; i < DiscountsCheckedListBox.Items.Count; i++)
                {
                    DiscountsCheckedListBox.SetItemChecked(i, statusOfDiscounts[i]);
                }
                CurrentCustomer.Cart.Items.Clear();
                CartListBox.Items.Clear();
                Update();
                OrdersChanged?.Invoke(this, new EventArgs());
            }
        }
        private void DiscountsCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Update();
        }
        private void Update()
        {
            CostLabel.Text = CurrentCustomer.Cart.Amount.ToString();
            double amount = 0;
            for (int i = 0; i < CurrentCustomer.Discounts.Count; i++)
            {
                if (DiscountsCheckedListBox.GetItemChecked(i))
                {
                    amount += CurrentCustomer.Discounts[i].Calculate(CurrentCustomer.Cart.Items);
                }
            }
            DiscountLabel.Text = amount.ToString();
            TotalCostLabel.Text = (Convert.ToDouble(CostLabel.Text) - Convert.ToDouble(DiscountLabel.Text)).ToString();
        }
    }
}

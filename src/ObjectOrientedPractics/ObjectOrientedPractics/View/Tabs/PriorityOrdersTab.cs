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
    public partial class PriorityOrdersTab : UserControl
    {
        PriorityOrder _priorityOrder;
        public PriorityOrdersTab()
        {
            InitializeComponent();
            ClearOrderButton.Click += ClearOrderButton_Click;
            RemoveItemButton.Click += RemoveItemButton_Click;
            DeliveryTimeComboBox.SelectedIndexChanged += DeliveryTimeComboBox_SelectedIndexChanged;
            _priorityOrder = NewPriorityOrder();
            foreach(var i in Enum.GetValues(typeof(OrderStatus)))
            {
                StatusComboBox.Items.Add(i);
            }
            string[] times = { "9:00 - 11:00", "11:00 - 13:00", "13:00 - 15:00", "15:00 - 17:00", "17:00 - 19:00", "19:00 - 21:00" };
            foreach(var i in times)
            {
                DeliveryTimeComboBox.Items.Add(i);
            }
            UpdatePriorityOrder();
        }
        private void ClearOrderButton_Click(object sender, EventArgs e)
        {
            _priorityOrder = NewPriorityOrder();
            OrderItemsListBox.Items.Clear();
            UpdatePriorityOrder();
            UpdateTotalCost();
        }
        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if(OrderItemsListBox.SelectedIndex != -1)
            {
                int index = OrderItemsListBox.SelectedIndex;
                _priorityOrder.Items.RemoveAt(index);
                OrderItemsListBox.Items.RemoveAt(index);
                if (index == OrderItemsListBox.Items.Count)
                {
                    OrderItemsListBox.SelectedIndex = index - 1;
                }
                else
                {
                    OrderItemsListBox.SelectedIndex = index;
                }
                UpdateTotalCost();
            }
        }
        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DeliveryTimeComboBox.SelectedIndex != -1)
            {
                _priorityOrder.PriorityTime = DeliveryTimeComboBox.SelectedItem.ToString();
            }
        }
        private void UpdateTotalCost()
        {
            TotalCostLabel.Text = _priorityOrder.TotalCost.ToString();
        }
        private void UpdatePriorityOrder()
        {
            foreach(var i in _priorityOrder.Items)
            {
                OrderItemsListBox.Items.Add(i.Name);
            }
            IDTextBox.Text = _priorityOrder.ID.ToString();
            CreatedTextBox.Text = _priorityOrder.Date;
            AddressControl.Address = _priorityOrder.Address;
            StatusComboBox.SelectedItem = _priorityOrder.OrderStatus;
            TotalCostLabel.Text = _priorityOrder.TotalCost.ToString();
            DeliveryTimeComboBox.SelectedIndex = -1;
        }
        private PriorityOrder NewPriorityOrder()
        {
            int index = new Random().Next(100000, 1000000);
            string country = "Россия";
            string city = "Томск";
            string street = "Ленина";
            string building = new Random().Next(0, 100).ToString();
            string apartment = new Random().Next(0, 100).ToString();
            string date = new Random().Next(1, 11).ToString() + "." + new Random().Next(1, 12).ToString() + "." + new Random().Next(2000, 2025).ToString();
            List<Model.Item> items = new List<Model.Item>();
            int randomCount = new Random().Next(4, 7);
            for (int i = 0; i < randomCount; i++)
            {
                items.Add(new Model.Item());
            }
            OrderStatus orderStatus = (OrderStatus)new Random().Next(0, Enum.GetValues(typeof(OrderStatus)).Length);
            return new PriorityOrder(index, country, city, street, building, apartment, date, items, orderStatus);
        }
    }
}

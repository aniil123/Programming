using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Orders;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class OrdersTab : UserControl
    {
        List<Customer> _customers;
        List<Order> _orders = new List<Order>();
        bool flag = true;
        public List<Customer> Customers
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
                    UpdateOrders();
                }
            }
        }
        private Order CurrentOrder
        {
            get
            {
                return _orders[DataGridView.SelectedRows[0].Index];
            }
        }
        public OrdersTab()
        {
            InitializeComponent();
            DataGridView.SelectionChanged += DataGridView_SelectionChanged;
            StatusComboBox.SelectedIndexChanged += StatusComboBox_SelectedIndexChanged;
            TotalCostLabel.SizeChanged += TotalCostLabel_SizeChanged;
            DataGridView.AllowUserToAddRows = false;
            DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DataGridView.RowHeadersVisible = false;
            DataGridView.AllowUserToResizeRows = false;
            AddressControl.ReadOnlyOn();
            foreach(var i in Enum.GetValues(typeof(OrderStatus)))
            {
                StatusComboBox.Items.Add(i);
            }
            string[] times = { "9:00 - 11:00", "11:00 - 13:00", "13:00 - 15:00", "15:00 - 17:00", "17:00 - 19:00", "19:00 - 21:00" };
            foreach (var i in times)
            {
                DeliveryTimeComboBox.Items.Add(i);
            }
        }
        public void UpdateOrders()
        {
            _orders.Clear();
            DataGridView.Rows.Clear();
            foreach(var i in _customers)
            {
                foreach(var j in i.Orders)
                {
                    string address = j.Address.Index.ToString() + ", " + j.Address.Country + ", " + j.Address.City + ", " + j.Address.Street + ", " + j.Address.Building + ", " + j.Address.Apartment;
                    flag = false;
                    DataGridView.Rows.Add(j.ID, j.Date, i.FullName, j.OrderStatus, address, j.TotalCost);
                    _orders.Add(j);
                }
            }
            DataGridView.ClearSelection();
        }
        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (flag)
            {
                if (DataGridView.SelectedRows.Count != 0)
                {
                    if(CurrentOrder.GetType() == typeof(PriorityOrder))
                    {
                        PriorityOptionsPanel.Visible = true;
                    }
                    else
                    {
                        PriorityOptionsPanel.Visible = false;
                    }
                    IDTextBox.Text = CurrentOrder.ID.ToString();
                    CreatedTextBox.Text = CurrentOrder.Date;
                    StatusComboBox.SelectedItem = CurrentOrder.OrderStatus;
                    AddressControl.Address = CurrentOrder.Address;
                    OrderItemsListBox.Items.Clear();
                    foreach (var i in CurrentOrder.Items)
                    {
                        OrderItemsListBox.Items.Add(i.Name);
                    }
                    TotalCostLabel.Text = CurrentOrder.TotalCost.ToString();
                }
                else
                {
                    IDTextBox.Text = "";
                    CreatedTextBox.Text = "";
                    StatusComboBox.SelectedIndex = -1;
                    AddressControl.Address = new Model.Address();
                    OrderItemsListBox.Items.Clear();
                    TotalCostLabel.Text = "";
                    PriorityOptionsPanel.Visible = false;
                }
            }
            flag = true;
        }
        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(DataGridView.SelectedRows.Count != 0)
            {
                CurrentOrder.OrderStatus = (OrderStatus)StatusComboBox.SelectedIndex;
                DataGridView.SelectedRows[0].Cells[3].Value = (OrderStatus)StatusComboBox.SelectedIndex;
            }
        }
        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CurrentOrder.GetType() == typeof(PriorityOrder))
            {
                PriorityOrder priorityOrder = (PriorityOrder)CurrentOrder;
                priorityOrder.PriorityTime = DeliveryTimeComboBox.SelectedItem.ToString();
            }
        }
        private void TotalCostLabel_SizeChanged(object sender, EventArgs e)
        {
            TotalCostLabel.Location = new Point(740 - TotalCostLabel.Width, TotalCostLabel.Location.Y);
        }
    }
}

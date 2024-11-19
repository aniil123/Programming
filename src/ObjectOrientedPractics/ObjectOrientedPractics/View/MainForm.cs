using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model.Discounts;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            TabControl.SelectedIndexChanged += TabControl_SelectedIndexChanged;
            Model.Store _store = new Model.Store();
            ItemsTab.Items = _store.Items;
            CustomersTab.Customers = _store.Customers;
            CartsTab.Items = _store.Items;
            CartsTab.Customers = _store.Customers;
            OrdersTab.Customers = _store.Customers;
        }
        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(TabControl.SelectedIndex == 2)
            {
                CartsTab.RefreshData();
            }
            else if(TabControl.SelectedIndex == 3)
            {
                OrdersTab.UpdateOrders();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            TabControl.SelectedIndexChanged += TabControl_SelectedIndexChanged;
            Model.PointsDiscount di = new Model.PointsDiscount();
            List<Model.Item> items = new List<Model.Item>();
            for(int i = 0;i< 3;i++)
            {
                items.Add(new Model.Item());
            }
            di.Update(items);
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

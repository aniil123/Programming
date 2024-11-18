using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Discounts;

namespace ObjectOrientedPractics.View
{
    public partial class AddDiscount : Form
    {
        Customer customer;
        public AddDiscount(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
            AddButton.Click += AddButton_Click;
            RemoveButton.Click += RemoveButton_Click;
            foreach (var i in Enum.GetValues(typeof(Category)))
            {
                CategoryComboBox.Items.Add(i);
            }
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            if(CategoryComboBox.SelectedIndex != -1)
            {
                bool flag = true;
                for(int i = 1;i < customer.Discounts.Count;i++)
                {
                    PresentDiscount presentDiscount = (PresentDiscount)customer.Discounts[i];
                    if(presentDiscount.Category == (Category)CategoryComboBox.SelectedItem)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    customer.Discounts.Add(new PresentDiscount((Category)CategoryComboBox.SelectedItem));
                    this.Close();
                }
            }
        }
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

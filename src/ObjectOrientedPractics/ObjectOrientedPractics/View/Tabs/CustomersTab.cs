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

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        List<Customer> _customers;
        /// <summary>
        /// Возвращает и присваивает список покупателей.
        /// </summary>
        public List<Customer> Customers
        {
            get
            {
                return _customers;
            }
            set
            {
                _customers = value;
            }
        }
        private Customer CurrentCustomer
        {
            get
            {
                return _customers[CustomersListBox.SelectedIndex];
            }
        }
        public CustomersTab()
        {
            InitializeComponent();
            IDTextBox.ReadOnly = true;
            FullNameTextBox.ReadOnly = true;
            IsPriorityCheckBox.Enabled = false;
            AddCustomerButton.Click += AddCustomerButton_Click;
            RemoveCustomerButton.Click += RemoveCustomerButton_Click;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
            FullNameTextBox.TextChanged += FullNameTextBox_TextChanged;
            IsPriorityCheckBox.CheckedChanged += IsPriorityCheckBox_CheckedChanged;
            AddDiscountButton.Click += AddDiscountButton_Click;
            RemoveDiscountButton.Click += RemoveDiscountButton_Click;
        }
        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            _customers.Add(new Model.Customer());
            CustomersListBox.Items.Add(_customers[_customers.Count - 1].FullName);
        }
        private void RemoveCustomerButton_Click(object sender, EventArgs e)
        {
            int index = CustomersListBox.SelectedIndex;
            if (index != -1)
            {
                CustomersListBox.Items.RemoveAt(index);
                _customers.RemoveAt(index);
                FullNameTextBox.BackColor = IDTextBox.BackColor;
                AddressControl.Address = new Model.Address();
                AddressControl.ReadOnlyOn();
            }
        }
        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CustomersListBox.SelectedIndex != -1)
            {
                AddressControl.ReadOnlyOff();
                FullNameTextBox.ReadOnly = false;
                AddressControl.Enabled = true;
                IsPriorityCheckBox.Enabled = true;
                IDTextBox.Text = CurrentCustomer.ID.ToString();
                FullNameTextBox.Text = CurrentCustomer.FullName;
                AddressControl.Address = CurrentCustomer.Address;
                IsPriorityCheckBox.Checked = CurrentCustomer.IsPriority;
                DiscountsListBox.Items.Clear();
                foreach (var i in CurrentCustomer.Discounts)
                {
                    DiscountsListBox.Items.Add(i.Info);
                }
            }
            else
            {
                FullNameTextBox.ReadOnly = true;
                IsPriorityCheckBox.Enabled = false;
                IDTextBox.Text = "";
                FullNameTextBox.Text = "";
                IsPriorityCheckBox.Checked = false;
                DiscountsListBox.Items.Clear();
            }
        }
        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int kolWords = 0;
                char[] charMas = FullNameTextBox.Text.ToCharArray();
                for(int i = 0;i < charMas.Length;i++)
                {
                    if(i == 0 && charMas[i] != ' ')
                    {
                        kolWords++;
                    }
                    else if(charMas[i - 1] == ' ' && charMas[i] != ' ')
                    {
                        kolWords++;
                    }
                    if(kolWords > 3)
                    {
                        throw new Exception();
                    }
                }
                if(kolWords < 3)
                {
                    throw new Exception();
                }
                CurrentCustomer.FullName = FullNameTextBox.Text;
                CustomersListBox.Items[CustomersListBox.SelectedIndex] = _customers[CustomersListBox.SelectedIndex].FullName;
                FullNameTextBox.SelectionStart = FullNameTextBox.Text.Length;
                FullNameTextBox.BackColor = Color.White;
            }
            catch
            {
                FullNameTextBox.BackColor = Color.Red;
            }
        }
        private void IsPriorityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(CustomersListBox.SelectedIndex != -1)
            {
                CurrentCustomer.IsPriority = Convert.ToBoolean(IsPriorityCheckBox.CheckState);
            }
        }
        private void AddDiscountButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                AddDiscount addDiscountForm = new AddDiscount(_customers[CustomersListBox.SelectedIndex]);
                int countOfDiscounts = CurrentCustomer.Discounts.Count;
                addDiscountForm.ShowDialog();
                if(CurrentCustomer.Discounts.Count != countOfDiscounts)
                {
                    UpdateListDiscounts();
                }
            }
        }
        private void RemoveDiscountButton_Click(object sender, EventArgs e)
        {
            if(CustomersListBox.SelectedIndex != -1 && DiscountsListBox.SelectedIndex != -1 && DiscountsListBox.SelectedIndex != 0)
            {
                CurrentCustomer.Discounts.RemoveAt(DiscountsListBox.SelectedIndex);
                UpdateListDiscounts();
            }
        }
        private void UpdateListDiscounts()
        {
            DiscountsListBox.Items.Clear();
            foreach (var i in CurrentCustomer.Discounts)
            {
                DiscountsListBox.Items.Add(i.Info);
            }
        }
    }
}

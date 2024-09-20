using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        List<Model.Customer> _customers = new List<Model.Customer>();
        public CustomersTab()
        {
            InitializeComponent();
            IDTextBox.ReadOnly = true;
            FullNameTextBox.ReadOnly = true;
            AddressTextBox.ReadOnly = true;
            AddCustomerButton.Click += AddCustomerButton_Click;
            RemoveCustomerButton.Click += RemoveCustomerButton_Click;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
            FullNameTextBox.TextChanged += FullNameTextBox_TextChanged;
            AddressTextBox.TextChanged += AddressTextBox_TextChanged;
        }
        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            _customers.Add(new Model.Customer("Владимир Владимиров Владимирович", "ул. Ленина 40"));
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
                AddressTextBox.BackColor = IDTextBox.BackColor;
            }
        }
        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CustomersListBox.SelectedIndex != -1)
            {
                FullNameTextBox.ReadOnly = false;
                AddressTextBox.ReadOnly = false;
                IDTextBox.Text = _customers[CustomersListBox.SelectedIndex].ID.ToString();
                FullNameTextBox.Text = _customers[CustomersListBox.SelectedIndex].FullName;
                AddressTextBox.Text = _customers[CustomersListBox.SelectedIndex].Address;
            }
            else
            {
                FullNameTextBox.ReadOnly = true;
                AddressTextBox.ReadOnly = true;
                IDTextBox.Text = "";
                FullNameTextBox.Text = "";
                AddressTextBox.Text = "";
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
                _customers[CustomersListBox.SelectedIndex].FullName = FullNameTextBox.Text;
                CustomersListBox.Items[CustomersListBox.SelectedIndex] = _customers[CustomersListBox.SelectedIndex].FullName;
                FullNameTextBox.SelectionStart = FullNameTextBox.Text.Length;
                FullNameTextBox.BackColor = Color.White;
            }
            catch
            {
                FullNameTextBox.BackColor = Color.Red;
            }
        }
        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _customers[CustomersListBox.SelectedIndex].Address = AddressTextBox.Text;
                AddressTextBox.BackColor = Color.White;
            }
            catch
            {
                AddressTextBox.BackColor = Color.Red;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThreeWindows.Classes;
using ThreeWindows.ArgumentsForEvents;

namespace ThreeWindows.Forms
{
    public partial class SecondaryForm : Form
    {
        Contact contact;
        public SecondaryForm(Contact contact)
        {
            InitializeComponent();
            this.contact = contact;
            FullNameTextBox.TextChanged += FullNameTextBox_TextChanged;
            PhoneNumberTextBox.TextChanged += PhoneNumberTextBox_TextChanged;
            AddressTextBox.TextChanged += AddressTextBox_TextChanged;
            contact.FullNameChanged += FullNameChanged;
            contact.PhoneNumberChanged += PhoneNumberChanged;
            contact.AddressChanged += AddressChanged;
        }
        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            contact.FullName = FullNameTextBox.Text;
        }
        private void PhoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            contact.PhoneNUmber = PhoneNumberTextBox.Text;
        }
        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            contact.Address = AddressTextBox.Text;
        }
        private void FullNameChanged(object sender, StringEventArgs e)
        {
            FullNameTextBox.Text = e.NewData;
        }
        private void PhoneNumberChanged(object sender, StringEventArgs e)
        {
            PhoneNumberTextBox.Text = e.NewData;
        }
        private void AddressChanged(object sender, StringEventArgs e)
        {
            AddressTextBox.Text = e.NewData;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThreeWindows.Forms;
using ThreeWindows.Classes;
using ThreeWindows.ArgumentsForEvents;

namespace ThreeWindows
{
    public partial class MainWindow : Form
    {
        Contact contact = new Contact();
        public MainWindow()
        {
            InitializeComponent();
            FullNameTextBox.TextChanged += FullNameTextBox_TextChanged;
            PhoneNumberTextBox.TextChanged += PhoneNumberTextBox_TextChanged;
            AddressTextBox.TextChanged += AddressTextBox_TextChanged;
            contact.FullNameChanged += FullNameChanged;
            contact.PhoneNumberChanged += PhoneNumberChanged;
            contact.AddressChanged += AddressChanged; 
            SecondaryForm form1 = new SecondaryForm(contact);
            SecondaryForm form2 = new SecondaryForm(contact);
            form1.Show();
            form2.Show();
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

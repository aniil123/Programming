using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    public partial class EnumsControl : UserControl
    {
        public EnumsControl()
        {
            InitializeComponent();
            EnumsListBox.SelectedIndexChanged += EnumsListBox_SelectedIndexChanged;
            ValueListBox.SelectedIndexChanged += ValueListBox_SelectedIndexChanged;
            EnumsListBox.SelectedIndex = 0;
        }
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (EnumsListBox.SelectedIndex)
            {
                case 0:
                    ValueListBox.Items.Clear();
                    foreach (var i in Enum.GetValues(typeof(ColorEnum)))
                    {
                        ValueListBox.Items.Add(i);
                    }
                    break;
                case 1:
                    ValueListBox.Items.Clear();
                    foreach (var i in Enum.GetValues(typeof(Form_edu)))
                    {
                        ValueListBox.Items.Add(i);
                    }
                    break;
                case 2:
                    ValueListBox.Items.Clear();
                    foreach (var i in Enum.GetValues(typeof(Genre)))
                    {
                        ValueListBox.Items.Add(i);
                    }
                    break;
                case 3:
                    ValueListBox.Items.Clear();
                    foreach (var i in Enum.GetValues(typeof(Season)))
                    {
                        ValueListBox.Items.Add(i);
                    }
                    break;
                case 4:
                    ValueListBox.Items.Clear();
                    foreach (var i in Enum.GetValues(typeof(Smartphones)))
                    {
                        ValueListBox.Items.Add(i);
                    }
                    break;
                case 5:
                    ValueListBox.Items.Clear();
                    foreach (var i in Enum.GetValues(typeof(Weekday)))
                    {
                        ValueListBox.Items.Add(i);
                    }
                    break;
            }
        }
        private void ValueListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IntTextBox.Text = Convert.ToString(Convert.ToInt32(ValueListBox.Items[ValueListBox.SelectedIndex]));
        }

    }
}

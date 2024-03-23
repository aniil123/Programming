using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming
{
    public partial class MainForm : Form
    {
        bool flag = true;
        public MainForm()
        {
            InitializeComponent();
            EnumsListBox.SelectedIndex = 0;
            foreach (var i in Enum.GetValues(typeof(Season)))
            {
                SeasonComboBox.Items.Add(i);
            }
            SeasonComboBox.SelectedIndex = 0;
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(EnumsListBox.SelectedIndex)
            {
                case 0:
                    ValueListBox.Items.Clear();
                    foreach(var i in Enum.GetValues(typeof(ColorEnum)))
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

        private void ParseButton_Click(object sender, EventArgs e)
        {
            foreach(var i in Enum.GetValues(typeof(Weekday)))
            {
                if(Convert.ToString(i) == ParseWeekDayTextBox.Text)
                {
                    ParseResultLabel.Text = $"Это день недели({i} = {Convert.ToInt32(i)})";
                    flag = false;
                }
            }
            if(flag==true)
            {
                ParseResultLabel.Text = "Нет такого дня недели";
            }
            flag = true;
        }

        private void SeasonButton_Click(object sender, EventArgs e)
        {
            switch(SeasonComboBox.SelectedIndex)
            {
                case 0:
                    SeasonResultLabel.Text = "";
                    this.BackColor = Color.Orange;
                    break;
                case 1:
                    this.BackColor = Color.White;
                    SeasonResultLabel.Text = "Ура! Солнце!";
                    break;
                case 2:
                    this.BackColor = Color.White;
                    SeasonResultLabel.Text = "Бррр! Холодно!";
                    break;
                case 3:
                    SeasonResultLabel.Text = "";
                    this.BackColor = Color.Green;
                    break;
            }
        }
    }
}

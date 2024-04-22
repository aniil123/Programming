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
        Model.Rectangle[] _rectangles = new Model.Rectangle[5];
        Model.Rectangle _currentRectangle = new Model.Rectangle(25, 16);
        public static MainForm forma;
        public MainForm()
        {
            InitializeComponent();
            forma = this;
            Random rand = new Random();
            EnumsListBox.SelectedIndex = 0;
            foreach (var i in Enum.GetValues(typeof(Season)))
            {
                SeasonComboBox.Items.Add(i);
            }
            SeasonComboBox.SelectedIndex = 0; 
            for(int i = 0;i<5;i++)
            {
                _rectangles[i] = new Model.Rectangle(rand.Next(100),rand.Next(100));
            }
            for (int i = 1; i <= 5; i++)
            {
                RectangleListBox.Items.Add($"Rectangle {i}");
            }
            RectangleListBox.SelectedIndex = 0;
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

        private void RectangleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRectangle.Length = _rectangles[RectangleListBox.SelectedIndex].Length;
            _currentRectangle.Width = _rectangles[RectangleListBox.SelectedIndex].Width;
            _currentRectangle.color = _rectangles[RectangleListBox.SelectedIndex].color;
            LengthTextBox.Text = Convert.ToString(_currentRectangle.Length);
            WidthTextBox.Text = Convert.ToString(_currentRectangle.Width);
            ColorTextBox.Text = _currentRectangle.color;
        }
        public void MessageError()
        {
            this.BackColor = Color.LightPink;
        }
        public void MessageErrorNo()
        {
            this.BackColor = Color.White;
        }

        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(LengthTextBox.Text, out int a) && Convert.ToInt32(LengthTextBox.Text) > 0)
                {
                    _rectangles[RectangleListBox.SelectedIndex].Length = Convert.ToInt32(LengthTextBox.Text);
                    MessageErrorNo();
                }
                else
                {
                    throw new Exception();
                }
            }
            catch
            {
                MessageError();
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(WidthTextBox.Text, out int a) && Convert.ToInt32(WidthTextBox.Text) > 0)
                {
                    _rectangles[RectangleListBox.SelectedIndex].Width = Convert.ToInt32(WidthTextBox.Text);
                    MessageErrorNo();
                }
                else
                {
                    throw new Exception();
                }
            }
            catch
            {
                MessageError();
            }
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            _rectangles[RectangleListBox.SelectedIndex].color = ColorTextBox.Text;
        }
        private int FindRectangleWithMaxWidth(Model.Rectangle[] _rectangle_mas)
        {
            int MaxWidth = 0, index_max = 0;
            for(int i = 0;i<_rectangle_mas.Length;i++)
            {
                if(MaxWidth < _rectangle_mas[i].Width)
                {
                    MaxWidth = _rectangle_mas[i].Width;
                    index_max = i; 
                }
            }
            return index_max;
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            RectangleListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
        }
    }
}

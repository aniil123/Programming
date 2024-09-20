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
    public partial class RectangleInfoControl : UserControl
    {
        Model.Rectangle[] _rectangles = new Model.Rectangle[5];
        Model.Rectangle _currentRectangle = new Model.Rectangle(25, 16, new Random().Next(0, 200), new Random().Next(0, 200));
        public RectangleInfoControl()
        {
            InitializeComponent();
            RectangleListBox.SelectedIndexChanged += RectangleListBox_SelectedIndexChanged;
            LengthTextBox.TextChanged += LengthTextBox_TextChanged;
            WidthTextBox.TextChanged += WidthTextBox_TextChanged;
            ColorTextBox.TextChanged += ColorTextBox_TextChanged;
            FindButton.Click += FindButton_Click;
            Random rand = new Random();
            for (int i = 0; i < 5; i++)
            {
                _rectangles[i] = new Model.Rectangle(rand.Next(50, 150), rand.Next(50, 150), rand.Next(15, 500), rand.Next(15, 300));
            }
            for (int i = 1; i <= 5; i++)
            {
                RectangleListBox.Items.Add($"Rectangle {i}");
            }
            RectangleListBox.SelectedIndex = 0;
            xTextBox.ReadOnly = true;
            yTextBox.ReadOnly = true;
            IDTextBox.ReadOnly = true;
        }
        /// <summary>
        /// Меняет цвет фона пользовательского элемента на LightPink.
        /// </summary>
        public void MessageError()
        {
            this.BackColor = Color.LightPink;
        }
        /// <summary>
        /// Меняет цвет фона пользовательского элемента на White.
        /// </summary>
        public void MessageErrorNo()
        {
            this.BackColor = Color.White;
        }
        private void RectangleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRectangle.Length = _rectangles[RectangleListBox.SelectedIndex].Length;
            _currentRectangle.Width = _rectangles[RectangleListBox.SelectedIndex].Width;
            _currentRectangle.color = _rectangles[RectangleListBox.SelectedIndex].color;
            LengthTextBox.Text = Convert.ToString(_currentRectangle.Length);
            WidthTextBox.Text = Convert.ToString(_currentRectangle.Width);
            ColorTextBox.Text = _currentRectangle.color;
            xTextBox.Text = Convert.ToString(_currentRectangle.X);
            yTextBox.Text = Convert.ToString(_currentRectangle.Y);
            IDTextBox.Text = Convert.ToString(_rectangles[RectangleListBox.SelectedIndex]._id);
        }
        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Model.Validator.AssertValueInRange(Convert.ToInt32(LengthTextBox.Text), 1, 2147483647);
                _rectangles[RectangleListBox.SelectedIndex].Length = Convert.ToInt32(LengthTextBox.Text);
                xTextBox.Text = Convert.ToString(_rectangles[RectangleListBox.SelectedIndex].xCenter);
                MessageErrorNo();
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
                Model.Validator.AssertValueInRange(Convert.ToInt32(WidthTextBox.Text), 1, 2147483647);
                _rectangles[RectangleListBox.SelectedIndex].Width = Convert.ToInt32(WidthTextBox.Text);
                yTextBox.Text = Convert.ToString(_rectangles[RectangleListBox.SelectedIndex].yCenter);
                MessageErrorNo();
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
        private int FindRectangleWithMaxWidth(Model.Rectangle[] _rectangle_list)
        {
            int MaxWidth = 0, index_max = 0;
            for (int i = 0; i < _rectangle_list.Length; i++)
            {
                if (MaxWidth < _rectangle_list[i].Width)
                {
                    MaxWidth = _rectangle_list[i].Width;
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

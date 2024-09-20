using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Programming.View.Panels
{
    public partial class RectangleCollisionControl : UserControl
    {
        List<Model.Rectangle> _rectangles = new List<Model.Rectangle>();
        List<Panel> PanelList = new List<Panel>();
        bool FlagMouseAdd = false;
        bool FlagMouseDelete = false;
        public RectangleCollisionControl()
        {
            InitializeComponent();
            AddPictureBox.Click += AddPictureBox_Click;
            AddPictureBox.MouseMove += AddPictureBox_MouseMove;
            AddPictureBox.MouseLeave += AddPictureBox_MouseLeave;
            AddPictureBox.MouseDown += AddPictureBox_MouseDown;
            AddPictureBox.MouseUp += AddPictureBox_MouseUp;
            DeletePictureBox.Click += DeletePictureBox_Click;
            DeletePictureBox.MouseMove += DeletePictureBox_MouseMove;
            DeletePictureBox.MouseLeave += DeletePictureBox_MouseLeave;
            DeletePictureBox.MouseDown += DeletePictureBox_MouseDown;
            DeletePictureBox.MouseUp += DeletePictureBox_MouseUp;
            XSelectedTextBox.TextChanged += XSelectedTextBox_TextChanged;
            YSelectedTextBox.TextChanged += YSelectedTextBox_TextChanged;
            WidthSelectedTextBox.TextChanged += WidthSelectedTextBox_TextChanged;
            HeightSelectedTextBox.TextChanged += HeightSelectedTextBox_TextChanged;
            RectanglesListBoxPage3.SelectedIndexChanged += RectanglesListBoxPage3_SelectedIndexChanged;
            Random rand = new Random();
            for (int i = 0; i < 5; i++)
            {
                int L = rand.Next(50, 150);
                int W = rand.Next(50, 150);
                _rectangles.Add(new Model.Rectangle(L, W, rand.Next(15, PanelForRectangles.Width - 15 - L), rand.Next(15, PanelForRectangles.Height - 15 - W)));
                PanelList.Add(new Panel());
                PanelForRectangles.Controls.Add(PanelList[i]);
                PanelList[i].Size = new Size(_rectangles[i].Length, _rectangles[i].Width);
                PanelList[i].Location = new Point(Convert.ToInt32(Math.Round(_rectangles[i].X)), Convert.ToInt32(Math.Round(_rectangles[i].Y)));
            }
            for (int i = 0; i < _rectangles.Count; i++)
            {
                RectanglesListBoxPage3.Items.Add($"{RectanglesListBoxPage3.Items.Count + 1}: (X={_rectangles[i].X}, Y={_rectangles[i].Y}, W={_rectangles[i].Length}, H={_rectangles[i].Width})");
            }
            IDSelectedTextBox.ReadOnly = true;
            FindCollisions();
            AddPictureBox.Image = Properties.Resources.AddNavodka;
            DeletePictureBox.Image = Image.FromFile("D:/Папка для локального репозитория/src/Programming/Programming/Model/Resources/Delete.bmp");
            AddPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            DeletePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void RectanglesListBoxPage3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RectanglesListBoxPage3.SelectedIndex == -1)
            {
                IDSelectedTextBox.Text = "";
                XSelectedTextBox.Text = "";
                YSelectedTextBox.Text = "";
                WidthSelectedTextBox.Text = "";
                HeightSelectedTextBox.Text = "";
                MessageErrorTextBoxNo(XSelectedTextBox);
                MessageErrorTextBoxNo(YSelectedTextBox);
                MessageErrorTextBoxNo(WidthSelectedTextBox);
                MessageErrorTextBoxNo(HeightSelectedTextBox);
            }
            else
            {
                IDSelectedTextBox.Text = Convert.ToString(_rectangles[RectanglesListBoxPage3.SelectedIndex]._id);
                XSelectedTextBox.Text = Convert.ToString(_rectangles[RectanglesListBoxPage3.SelectedIndex].X);
                YSelectedTextBox.Text = Convert.ToString(_rectangles[RectanglesListBoxPage3.SelectedIndex].Y);
                WidthSelectedTextBox.Text = Convert.ToString(_rectangles[RectanglesListBoxPage3.SelectedIndex].Length);
                HeightSelectedTextBox.Text = Convert.ToString(_rectangles[RectanglesListBoxPage3.SelectedIndex].Width);
                for (int i = 0; i < PanelList.Count; i++)
                {
                    if (i == RectanglesListBoxPage3.SelectedIndex)
                    {
                        PanelList[i].BorderStyle = BorderStyle.FixedSingle;
                    }
                    else
                    {
                        PanelList[i].BorderStyle = BorderStyle.None;
                    }
                }
            }
        }
        private void XSelectedTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Model.Validator.AssertValueInRange(int.Parse(XSelectedTextBox.Text), 15, PanelForRectangles.Width - 15 - _rectangles[RectanglesListBoxPage3.SelectedIndex].Length);
                _rectangles[RectanglesListBoxPage3.SelectedIndex].X = int.Parse(XSelectedTextBox.Text);
                RectanglesListBoxPage3.Items[RectanglesListBoxPage3.SelectedIndex] = $"{RectanglesListBoxPage3.SelectedIndex + 1}: (X={_rectangles[RectanglesListBoxPage3.SelectedIndex].X}, Y={_rectangles[RectanglesListBoxPage3.SelectedIndex].Y}, W={_rectangles[RectanglesListBoxPage3.SelectedIndex].Length}, H={_rectangles[RectanglesListBoxPage3.SelectedIndex].Width})";
                PanelList[RectanglesListBoxPage3.SelectedIndex].Location = new Point(Convert.ToInt32(Math.Round(_rectangles[RectanglesListBoxPage3.SelectedIndex].X)), PanelList[RectanglesListBoxPage3.SelectedIndex].Location.Y);
                XSelectedTextBox.SelectionStart = XSelectedTextBox.TextLength;
                FindCollisions();
                MessageErrorTextBoxNo(XSelectedTextBox);
            }
            catch
            {
                MessageErrorTextBox(XSelectedTextBox);
            }
        }
        private void YSelectedTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Model.Validator.AssertValueInRange(int.Parse(YSelectedTextBox.Text), 15, PanelForRectangles.Height - 15 - _rectangles[RectanglesListBoxPage3.SelectedIndex].Width);
                _rectangles[RectanglesListBoxPage3.SelectedIndex].Y = int.Parse(YSelectedTextBox.Text);
                RectanglesListBoxPage3.Items[RectanglesListBoxPage3.SelectedIndex] = $"{RectanglesListBoxPage3.SelectedIndex + 1}: (X={_rectangles[RectanglesListBoxPage3.SelectedIndex].X}, Y={_rectangles[RectanglesListBoxPage3.SelectedIndex].Y}, W={_rectangles[RectanglesListBoxPage3.SelectedIndex].Length}, H={_rectangles[RectanglesListBoxPage3.SelectedIndex].Width})";
                PanelList[RectanglesListBoxPage3.SelectedIndex].Location = new Point(PanelList[RectanglesListBoxPage3.SelectedIndex].Location.X, Convert.ToInt32(Math.Round(_rectangles[RectanglesListBoxPage3.SelectedIndex].Y)));
                YSelectedTextBox.SelectionStart = YSelectedTextBox.TextLength;
                FindCollisions();
                MessageErrorTextBoxNo(YSelectedTextBox);
            }
            catch
            {
                MessageErrorTextBox(YSelectedTextBox);
            }
        }
        private void WidthSelectedTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Model.Validator.AssertValueInRange(int.Parse(WidthSelectedTextBox.Text) + _rectangles[RectanglesListBoxPage3.SelectedIndex].X, 15, PanelForRectangles.Width - 15);
                _rectangles[RectanglesListBoxPage3.SelectedIndex].Length = int.Parse(WidthSelectedTextBox.Text);
                RectanglesListBoxPage3.Items[RectanglesListBoxPage3.SelectedIndex] = $"{RectanglesListBoxPage3.SelectedIndex + 1}: (X={_rectangles[RectanglesListBoxPage3.SelectedIndex].X}, Y={_rectangles[RectanglesListBoxPage3.SelectedIndex].Y}, W={_rectangles[RectanglesListBoxPage3.SelectedIndex].Length}, H={_rectangles[RectanglesListBoxPage3.SelectedIndex].Width})";
                PanelList[RectanglesListBoxPage3.SelectedIndex].Size = new Size(_rectangles[RectanglesListBoxPage3.SelectedIndex].Length, PanelList[RectanglesListBoxPage3.SelectedIndex].Size.Height);
                WidthSelectedTextBox.SelectionStart = WidthSelectedTextBox.TextLength;
                FindCollisions();
                MessageErrorTextBoxNo(WidthSelectedTextBox);
            }
            catch
            {
                MessageErrorTextBox(WidthSelectedTextBox);
            }
        }
        private void HeightSelectedTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Model.Validator.AssertValueInRange(int.Parse(HeightSelectedTextBox.Text) + _rectangles[RectanglesListBoxPage3.SelectedIndex].Y, 15, PanelForRectangles.Height - 15);
                _rectangles[RectanglesListBoxPage3.SelectedIndex].Width = int.Parse(HeightSelectedTextBox.Text);
                RectanglesListBoxPage3.Items[RectanglesListBoxPage3.SelectedIndex] = $"{RectanglesListBoxPage3.SelectedIndex + 1}: (X={_rectangles[RectanglesListBoxPage3.SelectedIndex].X}, Y={_rectangles[RectanglesListBoxPage3.SelectedIndex].Y}, W={_rectangles[RectanglesListBoxPage3.SelectedIndex].Length}, H={_rectangles[RectanglesListBoxPage3.SelectedIndex].Width})";
                PanelList[RectanglesListBoxPage3.SelectedIndex].Size = new Size(PanelList[RectanglesListBoxPage3.SelectedIndex].Size.Width, _rectangles[RectanglesListBoxPage3.SelectedIndex].Width);
                HeightSelectedTextBox.SelectionStart = HeightSelectedTextBox.TextLength;
                FindCollisions();
                MessageErrorTextBoxNo(HeightSelectedTextBox);
            }
            catch
            {
                MessageErrorTextBox(HeightSelectedTextBox);
            }
        }
        private void DeletePictureBox_Click(object sender, EventArgs e)
        {
            if (RectanglesListBoxPage3.SelectedIndex != -1)
            {
                _rectangles.RemoveAt(RectanglesListBoxPage3.SelectedIndex);
                PanelForRectangles.Controls.Remove(PanelList[RectanglesListBoxPage3.SelectedIndex]);
                PanelList.RemoveAt(RectanglesListBoxPage3.SelectedIndex);
                RectanglesListBoxPage3.Items.RemoveAt(RectanglesListBoxPage3.SelectedIndex);
                FindCollisions();
            }
        }
        private void AddPictureBox_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int L = rand.Next(50, 150);
            int W = rand.Next(50, 150);
            _rectangles.Add(new Model.Rectangle(L, W, rand.Next(15, PanelForRectangles.Width - 15 - L), rand.Next(15, PanelForRectangles.Height - 15 - W)));
            PanelList.Add(new Panel());
            PanelForRectangles.Controls.Add(PanelList[PanelList.Count - 1]);
            PanelList[PanelList.Count - 1].Size = new Size(_rectangles[PanelList.Count - 1].Length, _rectangles[PanelList.Count - 1].Width);
            PanelList[PanelList.Count - 1].Location = new Point(Convert.ToInt32(Math.Round(_rectangles[PanelList.Count - 1].X)), Convert.ToInt32(Math.Round(_rectangles[PanelList.Count - 1].Y)));
            RectanglesListBoxPage3.Items.Add($"{RectanglesListBoxPage3.Items.Count + 1}: (X={_rectangles[_rectangles.Count - 1].X}, Y={_rectangles[_rectangles.Count - 1].Y}, W={_rectangles[_rectangles.Count - 1].Length}, H={_rectangles[_rectangles.Count - 1].Width})");
            FindCollisions();
        }
        /// <summary>
        /// Находит прямоугольники, которые пересекаются, и меняет их цвет на красный. 
        /// </summary>
        private void FindCollisions()
        {
            foreach (var i in PanelList)
            {
                i.BackColor = Color.FromArgb(127, 127, 255, 127);
            }
            for (int i = 0; i < _rectangles.Count - 1; i++)
            {
                for (int j = i + 1; j < _rectangles.Count; j++)
                {
                    if (Model.CollisionManager.IsCollision(_rectangles[i], _rectangles[j]))
                    {
                        PanelList[i].BackColor = Color.FromArgb(127, 255, 127, 127);
                        PanelList[j].BackColor = Color.FromArgb(127, 255, 127, 127);
                    }
                }
            }
        }
        /// <summary>
        /// Обновляет информацию о выбранном прямоугольнике в текстовых полях.
        /// </summary>
        /// <param name="rectangle">Прямоугольник, информация о котором обновляется. Объект типа <see cref="Model.Rectangle"/></param>
        private void UpdateRectangleInfo(Model.Rectangle rectangle)
        {
            IDSelectedTextBox.Text = Convert.ToString(rectangle._id);
            XSelectedTextBox.Text = Convert.ToString(rectangle.X);
            YSelectedTextBox.Text = Convert.ToString(rectangle.Y);
            WidthSelectedTextBox.Text = Convert.ToString(rectangle.Length);
            HeightSelectedTextBox.Text = Convert.ToString(rectangle.Width);
        }
        /// <summary>
        /// Очищает текстовые поля.
        /// </summary>
        private void ClearRectangleInfo()
        {
            IDSelectedTextBox.Text = "";
            XSelectedTextBox.Text = "";
            YSelectedTextBox.Text = "";
            WidthSelectedTextBox.Text = "";
            HeightSelectedTextBox.Text = "";
        }
        private void AddPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (FlagMouseAdd == false)
            {
                AddPictureBox.Image = Properties.Resources.RedactNavodka;
            }
        }
        private void AddPictureBox_MouseLeave(object sender, System.EventArgs e)
        {
            AddPictureBox.Image = Image.FromFile("D:/Папка для локального репозитория/Programming/Programming/Model/Resources/Add.bmp");
            FlagMouseAdd = false;
        }
        private void AddPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            AddPictureBox.Image = Image.FromFile("D:/Папка для локального репозитория/Programming/Programming/Model/Resources/AddClick.png");
            FlagMouseAdd = true;
        }
        private void AddPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            AddPictureBox.Image = Image.FromFile("D:/Папка для локального репозитория/Programming/Programming/Model/Resources/AddNavodka.bmp");
            FlagMouseAdd = false;
        }
        private void DeletePictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (FlagMouseDelete == false)
            {
                DeletePictureBox.Image = Image.FromFile("D:/Папка для локального репозитория/src/Programming/Programming/Model/Resources/DeleteNavodka.png");
            }
        }
        private void DeletePictureBox_MouseLeave(object sender, System.EventArgs e)
        {
            DeletePictureBox.Image = Image.FromFile("D:/Папка для локального репозитория/Programming/Programming/Model/Resources/Delete.bmp");
            FlagMouseDelete = false;
        }
        private void DeletePictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            DeletePictureBox.Image = Image.FromFile("D:/Папка для локального репозитория/Programming/Programming/Model/Resources/DeleteClick.bmp");
            FlagMouseDelete = true;
        }
        private void DeletePictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            DeletePictureBox.Image = Image.FromFile("D:/Папка для локального репозитория/Programming/Programming/Model/Resources/deleteNavodka.png");
            FlagMouseDelete = false;
        }
        /// <summary>
        /// Меняет цвет передаваемого текстового поля на красный.
        /// </summary>
        /// <param name="textbox">Текстовое поле цвет, которого меняется.</param>
        public void MessageErrorTextBox(TextBox textbox)
        {
            textbox.BackColor = Color.Red;
        }
        /// <summary>
        /// Меняет цвет передаваемого текстового поля на белый.
        /// </summary>
        /// <param name="textbox">Текстовое поле цвет, которого меняется.</param>
        public void MessageErrorTextBoxNo(TextBox textbox)
        {
            textbox.BackColor = Color.White;
        }
    }
}

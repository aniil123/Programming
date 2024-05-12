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
        List<Model.Rectangle> _rectangles = new List<Model.Rectangle>();
        Model.Rectangle _currentRectangle = new Model.Rectangle(25, 16, new Random().Next(0,200), new Random().Next(0,200));
        Model.Film[] _films = new Model.Film[5];
        Model.Film _currentFilm = new Model.Film("ASD", 153, 1996, "Comedy", 7);
        List<Panel> PanelList = new List<Panel>();
        bool FlagMouseAdd = false;
        bool FlagMouseDelete = false;
        public MainForm()
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
            Random rand = new Random();
            EnumsListBox.SelectedIndex = 0;
            foreach (var i in Enum.GetValues(typeof(Season)))
            {
                SeasonComboBox.Items.Add(i);
            }
            SeasonComboBox.SelectedIndex = 0; 
            for(int i = 0;i<5;i++)
            {
                _films[i] = new Model.Film("dades", rand.Next(60,120), rand.Next(1900,2024), "Thriller", rand.Next(0,10));
            }
            for(int i = 1;i<=5;i++)
            {
                FilmListBox.Items.Add($"Film {i}");
            }
            FilmListBox.SelectedIndex = 0;
            for(int i = 0;i<5;i++)
            {
                _rectangles.Add(new Model.Rectangle(rand.Next(50,150),rand.Next(50,150), rand.Next(0,600), rand.Next(0,320)));
                PanelList.Add(new Panel());
                PanelForRectangles.Controls.Add(PanelList[i]);
                PanelList[i].Size =  new Size(_rectangles[i].Length, _rectangles[i].Width);
                PanelList[i].Location = new Point(Convert.ToInt32(Math.Round(_rectangles[i].X)), Convert.ToInt32(Math.Round(_rectangles[i].Y)));
            }
            for (int i = 1; i <= 5; i++)
            {
                RectangleListBox.Items.Add($"Rectangle {i}");
            }
            RectangleListBox.SelectedIndex = 0;
            for(int i = 0;i<_rectangles.Count;i++)
            {
                RectanglesListBoxPage3.Items.Add($"{RectanglesListBoxPage3.Items.Count + 1}: (X={_rectangles[i].X}, Y={_rectangles[i].Y}, W={_rectangles[i].Length}, H={_rectangles[i].Width})");
            }
            xTextBox.ReadOnly = true;
            yTextBox.ReadOnly = true;
            IDTextBox.ReadOnly = true;
            IDSelectedTextBox.ReadOnly = true;
            FindCollisions();
            AddPictureBox.Image = Image.FromFile("D:/Папка для локального репозитория/Programming/Programming/Model/Resources/Add.bmp");
            DeletePictureBox.Image = Image.FromFile("D:/Папка для локального репозитория/Programming/Programming/Model/Resources/Delete.bmp");
            AddPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            DeletePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
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
            xTextBox.Text = Convert.ToString(_currentRectangle.X);
            yTextBox.Text = Convert.ToString(_currentRectangle.Y);
            IDTextBox.Text = Convert.ToString(_rectangles[RectangleListBox.SelectedIndex]._id);
        }
        public void MessageError()
        {
            this.BackColor = Color.LightPink;
        }
        public void MessageErrorNo()
        {
            this.BackColor = Color.White;
        }
        public void MessageErrorTextBox(TextBox textbox)
        {
            textbox.BackColor = Color.Red;
        }
        public void MessageErrorTextBoxNo(TextBox textbox)
        {
            textbox.BackColor = Color.White;
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
        private int FindFilmWithMaxRating(Model.Film[] _film_mas)
        {
            int MaxRating = 0, index_max = 0;
            for (int i = 0; i < _film_mas.Length; i++)
            {
                if (MaxRating < _film_mas[i].Rating)
                {
                    MaxRating = _film_mas[i].Rating;
                    index_max = i;
                }
            }
            return index_max;
        }
        private int FindRectangleWithMaxWidth(List<Model.Rectangle> _rectangle_list)
        {
            int MaxWidth = 0, index_max = 0;
            for(int i = 0;i<_rectangle_list.Count;i++)
            {
                if(MaxWidth < _rectangle_list[i].Width)
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

        private void FilmListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentFilm.name = _films[FilmListBox.SelectedIndex].name;
            _currentFilm.Duration = _films[FilmListBox.SelectedIndex].Duration;
            _currentFilm.Date = _films[FilmListBox.SelectedIndex].Date;
            _currentFilm.genre = _films[FilmListBox.SelectedIndex].genre;
            _currentFilm.Rating = _films[FilmListBox.SelectedIndex].Rating;
            NameTextBox.Text = _currentFilm.name;
            DurationTextBox.Text = Convert.ToString(_currentFilm.Duration);
            DateTextBox.Text = Convert.ToString(_currentFilm.Date);
            GenreTextBox.Text = _currentFilm.genre;
            RatingTextBox.Text = Convert.ToString(_currentFilm.Rating);
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            _films[FilmListBox.SelectedIndex].name = NameTextBox.Text;
        }

        private void DurationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Model.Validator.AssertOnPositiveValue(Convert.ToInt32(DurationTextBox.Text));
                _films[FilmListBox.SelectedIndex].Duration = Convert.ToInt32(DurationTextBox.Text);
                MessageErrorNo();
            }
            catch
            {
                MessageError();
            }
        }

        private void DateTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(DateTextBox.Text, out int a) && Convert.ToInt32(DateTextBox.Text) >= 1900 && Convert.ToInt32(DateTextBox.Text) <= 2024)
                {
                    _films[FilmListBox.SelectedIndex].Date = Convert.ToInt32(DateTextBox.Text);
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

        private void GenreTextBox_TextChanged(object sender, EventArgs e)
        {
            _films[FilmListBox.SelectedIndex].genre = GenreTextBox.Text;
        }

        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(RatingTextBox.Text, out int a) && Convert.ToInt32(RatingTextBox.Text) >= 0 && Convert.ToInt32(RatingTextBox.Text) <= 10)
                {
                    _films[FilmListBox.SelectedIndex].Rating = Convert.ToInt32(RatingTextBox.Text);
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

        private void FindFilmButton_Click(object sender, EventArgs e)
        {
            FilmListBox.SelectedIndex = FindFilmWithMaxRating(_films);
        }

        private void RectanglesListBoxPage3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(RectanglesListBoxPage3.SelectedIndex == -1)
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
                for(int i = 0;i<PanelList.Count;i++)
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
            _rectangles.Add(new Model.Rectangle(rand.Next(50, 150), rand.Next(50, 150), rand.Next(0, 600), rand.Next(0, 320)));
            PanelList.Add(new Panel());
            PanelForRectangles.Controls.Add(PanelList[PanelList.Count-1]);
            PanelList[PanelList.Count - 1].Size = new Size(_rectangles[PanelList.Count - 1].Length, _rectangles[PanelList.Count - 1].Width);
            PanelList[PanelList.Count - 1].Location = new Point(Convert.ToInt32(Math.Round(_rectangles[PanelList.Count - 1].X)), Convert.ToInt32(Math.Round(_rectangles[PanelList.Count - 1].Y)));
            RectanglesListBoxPage3.Items.Add($"{RectanglesListBoxPage3.Items.Count + 1}: (X={_rectangles[_rectangles.Count-1].X}, Y={_rectangles[_rectangles.Count - 1].Y}, W={_rectangles[_rectangles.Count - 1].Length}, H={_rectangles[_rectangles.Count - 1].Width})");
            FindCollisions();
        }
        private void FindCollisions()
        {
            foreach(var i in PanelList)
            {
                i.BackColor = Color.FromArgb(127, 127, 255, 127);
            }
            for(int i = 0;i < _rectangles.Count - 1;i++)
            {
                for(int j = i + 1;j < _rectangles.Count;j++)
                {
                    if(Model.CollisionManager.IsCollision(_rectangles[i], _rectangles[j]))
                    {
                        PanelList[i].BackColor = Color.FromArgb(127, 255, 127, 127);
                        PanelList[j].BackColor = Color.FromArgb(127, 255, 127, 127);
                    }
                }
            }
        }
        private void UpdateRectangleInfo(Model.Rectangle rectangle)
        {
            IDSelectedTextBox.Text = Convert.ToString(rectangle._id);
            XSelectedTextBox.Text = Convert.ToString(rectangle.X);
            YSelectedTextBox.Text = Convert.ToString(rectangle.Y);
            WidthSelectedTextBox.Text = Convert.ToString(rectangle.Length);
            HeightSelectedTextBox.Text = Convert.ToString(rectangle.Width);
        }
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
                AddPictureBox.Image = Image.FromFile("D:/Папка для локального репозитория/Programming/Programming/Model/Resources/AddNavodka.bmp");
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
                DeletePictureBox.Image = Image.FromFile("D:/Папка для локального репозитория/Programming/Programming/Model/Resources/DeleteNavodka.bmp");
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
            DeletePictureBox.Image = Image.FromFile("D:/Папка для локального репозитория/Programming/Programming/Model/Resources/deleteNavodka.bmp");
            FlagMouseDelete = false;
        }
    }
}

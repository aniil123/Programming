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
        Model.Rectangle _currentRectangle = new Model.Rectangle(25, 16, new Random().Next(0,200), new Random().Next(0,200));
        Model.Film[] _films = new Model.Film[5];
        Model.Film _currentFilm = new Model.Film("ASD", 153, 1996, "Comedy", 7);
        public MainForm()
        {
            InitializeComponent();
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
            for(int i = 0;i < 5;i++)
            {
                _rectangles[i] = new Model.Rectangle(rand.Next(50, 150), rand.Next(50, 150), rand.Next(15,500), rand.Next(15, 300));
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
        private int FindRectangleWithMaxWidth(Model.Rectangle[] _rectangle_list)
        {
            int MaxWidth = 0, index_max = 0;
            for(int i = 0;i<_rectangle_list.Length;i++)
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
    }
}

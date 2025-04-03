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
    public partial class FilmsInfoControl : UserControl
    {
        Model.Film[] _films = new Model.Film[5];
        Model.Film _currentFilm = new Model.Film("ASD", 153, 1996, "Comedy", 7);
        public FilmsInfoControl()
        {
            InitializeComponent();
            FilmListBox.SelectedIndexChanged += FilmListBox_SelectedIndexChanged;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            DurationTextBox.TextChanged += DurationTextBox_TextChanged;
            GenreTextBox.TextChanged += GenreTextBox_TextChanged;
            RatingTextBox.TextChanged += RatingTextBox_TextChanged;
            DateTextBox.TextChanged += DateTextBox_TextChanged;
            FindFilmButton.Click += FindFilmButton_Click;
            Random rand = new Random();
            for (int i = 0; i < 5; i++)
            {
                _films[i] = new Model.Film("dades", rand.Next(60, 120), rand.Next(1900, 2024), "Thriller", rand.Next(0, 10));
            }
            for (int i = 1; i <= 5; i++)
            {
                FilmListBox.Items.Add($"Film {i}");
            }
            FilmListBox.SelectedIndex = 0;
        }
        /// <summary>
        /// Меняет цвет фона пользовательского элемента на LightPing.
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
        /// <summary>
        /// Ищет фильм с наибольшим рейтингом.
        /// </summary>
        /// <param name="_film_mas">Массив объектов типа <see cref="Model.Film"/></param>
        /// <returns>Возвращает индекс элемента массива _film_mas с наибольшим рейтингом.</returns>
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

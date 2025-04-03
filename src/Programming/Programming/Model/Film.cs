using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит информацию о фильме.
    /// </summary>
    class Film
    {
        //Хранит название фильма.
        public string name { get; set; }
        //Хранит продолжительность фильма в минутах.
        private int duration;
        //Хранит дату создания фильма.
        private int date;
        //Хранит жанр фильма.
        public string genre{ get; set; }
        //Хранит рейтинг фильма по 10-балльной шкале.
        private int rating;
        /// <summary>
        /// Возвращает и задает продолжительность фильма. Должна быть целым положительным числом.
        /// </summary>
        public int Duration
        {
            get
            {
                return duration;
            }
            set
            {
                Validator.AssertOnPositiveValue(value);
                duration = value;
            }
        }
        /// <summary>
        /// Возвращает и задает дату создания фильма. Должна быть целым положительным числом.
        /// </summary>
        public int Date
        {
            get
            {
                return date;
            }
            set
            {
                if (value >= 1900 && value <= 2024)
                {
                    date = value;
                }
                else
                {
                    throw new Exception("Неверная дата создания фильма");
                }
            }
        }
        /// <summary>
        /// Возвращает и задает рейтинг фильма. Должен быть целым неотрицательным числом не больше 10-и.
        /// </summary>
        public int Rating
        {
            get
            {
                return rating;
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 10);
                rating = value;
            }
        }
        /// <summary>
        /// Заполняет поля класса константами.
        /// </summary>
        public Film()
        {
            name = "film";
            duration = 90;
            date = 2015;
            genre = "Drama";
            rating = 7;
        }
        /// <summary>
        /// Заполняет поля класса передаваемыми значениями.
        /// </summary>
        /// <param name="name">Название фильма. Должно быть строкой.</param>
        /// <param name="duration">Продолжительность фильма в минутах. Должна быть целым положительным числом.</param>
        /// <param name="date">Дата создания фильма. Должна быть целым положительным числом.</param>
        /// <param name="genre">Жанр фильма. Должен быть строкой.</param>
        /// <param name="rating">Рейтинг фильма. Делжен быть целым неотрицательным числом не больше 10-и.</param>
        public Film(string name, int duration, int date, string genre, int rating)
        {
            this.name = name;
            Duration = duration;
            Date = date;
            this.genre = genre;
            Rating = rating;
        }
    }
}

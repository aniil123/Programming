using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    class Film
    {
        public string name { get; set; }
        private int duration;
        private int date;
        public string genre{ get; set; }
        private int rating;
        public int Duration
        {
            get
            {
                return duration;
            }
            set
            {
                if(value <= 0)
                {
                    throw new Exception("Продолжительность фильма не может быть меньше или равна нулю");
                }
                else
                {
                    duration = value;
                }
            }
        }
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
        public int Rating
        {
            get
            {
                return rating;
            }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    rating = value;
                }
                else
                {
                    throw new Exception("Неверный рейтинг фильма");
                }
            }
        }
        public Film()
        {
            name = "film";
            duration = 90;
            date = 2015;
            genre = "Drama";
            rating = 7;
        }
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

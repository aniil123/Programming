using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит информацию о песне.
    /// </summary>
    class Song
    {
        //Хранит продолжительность песни в минутах.
        private int duration;
        //Хранит информацию о том, понравилась ли песня или нет.
        public bool like { get; set; }
        //Хранит название песни.
        public string name { get; set; }
        /// <summary>
        /// Возвращает и задает продолжительность песни в минутах. Должна быть целым положительным числом.
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
        /// Заполняет все поля класса константами.
        /// </summary>
        public Song()
        {
            Duration = 134;
            like = true;
            name = "lilalo";
        }
        /// <summary>
        /// Заполняет все поля класса передаваемыми значениями. 
        /// </summary>
        /// <param name="duration">Продолжительность песни в минутах. Должна быть целым положительным числом.</param>
        /// <param name="like">Информация о том, нравится ли песня или нет. Объект типа bool</param>
        /// <param name="name">Название песни. Должно быть строкой.</param>
        public Song(int duration, bool like, string name)
        {
            Duration = duration;
            this.like = like;
            this.name = name;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    class Song
    {
        private int duration;
        public bool like { get; set; }
        public string name { get; set; }
        public int Duration
        {
            get
            {
                return duration;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Продолжительность песни не может быть меньше или равна нулю");
                }
                else
                {
                    duration = value;
                }
            }
        }
        public Song()
        {
            Duration = 134;
            like = true;
            name = "lilalo";
        }
        public Song(int duration, bool like, string name)
        {
            Duration = duration;
            this.like = like;
            this.name = name;
        }
    }
}

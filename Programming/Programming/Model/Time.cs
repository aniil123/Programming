using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    class Time
    {
        private int hour;
        private int minut;
        private int second;
        public int Hour
        {
            get
            {
                return hour;
            }
            set
            {
                if (value >= 0 && value <= 23)
                {
                    hour = value;
                }
                else
                {
                    throw new Exception("Количество часов не может быть меньше 0 и больше 23");
                }
            }
        }
        public int Minut
        {
            get
            {
                return minut;
            }
            set
            {
                if (value >= 0 && value <= 59)
                {
                    minut = value;
                }
                else
                {
                    throw new Exception("Количество минут не может быть меньше 0 и больше 59");
                }
            }
        }
        public int Second
        {
            get
            {
                return second;
            }
            set
            {
                if (value >= 0 && value <= 23)
                {
                    second = value;
                }
                else
                {
                    throw new Exception("Количество секунд не может быть меньше 0 и больше 59");
                }
            }
        }
        public Time()
        {
            hour = 23;
            minut = 59;
            second = 59;
        }
        public Time(int hour, int minut, int second)
        {
            Hour = hour;
            Minut = minut;
            Second = second;
        }
    }
}

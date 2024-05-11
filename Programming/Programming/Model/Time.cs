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
                Validator.AssertValueInRange(value, 0, 23);
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
                Validator.AssertValueInRange(value, 0, 59);
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
                Validator.AssertValueInRange(value, 0, 59);
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

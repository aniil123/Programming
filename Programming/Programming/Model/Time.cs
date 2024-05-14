using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит ифнормацию о времени.
    /// </summary>
    class Time
    {
        //Хранит количество часов.
        private int hour;
        //Хранит количество минут.
        private int minut;
        //Хранит количество секунд.
        private int second;
        /// <summary>
        /// Возвращает и задает количество часов. Должно быть челым неотрицательным числом не больше 23.
        /// </summary>
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
        /// <summary>
        /// Возвращает и задает количество минут. Должно быть целым неотрицательным числом не больше 59.
        /// </summary>
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
        /// <summary>
        /// Возвращает и задает количество секунд. Должно быть целым неотрицательным числом не больше 59.
        /// </summary>
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
        /// <summary>
        /// Заполняет все поля класса константами.
        /// </summary>
        public Time()
        {
            hour = 23;
            minut = 59;
            second = 59;
        }
        /// <summary>
        /// Заполняет все поля класса передаваемыми зачениями.
        /// </summary>
        /// <param name="hour">Количество часов. Должно быть целым неотрицательным числом не больше 23.</param>
        /// <param name="minut">Количество минут. Должно быть целым неотрицательным числом не больше 59.</param>
        /// <param name="second">Количество секунд. Должно быть целым неотрицательным числом не больше 59.</param>
        public Time(int hour, int minut, int second)
        {
            Hour = hour;
            Minut = minut;
            Second = second;
        }
    }
}

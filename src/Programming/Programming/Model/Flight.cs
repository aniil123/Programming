using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит информацию о рейсе.
    /// </summary>
    class Flight
    {
        //Хранит название начального пункта.
        private string beginning { get; set; }
        //Хранит название конечного пункта.
        private string end { get; set; }
        //Хранит количество минут, которое уходит на путь от начального пункта до конечного.
        private int minuts;
        /// <summary>
        /// Возвращает и задает количество минут, которое уходит на путь от начального пункта до конечного. Должно быть целым положительным числом. 
        /// </summary>
        public int Minuts
        {
            get
            {
                return minuts;
            }
            set
            {
                Validator.AssertOnPositiveValue(value);
                minuts = value;
            }
        }
        /// <summary>
        /// Заполняет все поля класса.
        /// </summary>
        public Flight()
        {
            beginning = "nach";
            end = "kon";
            minuts = 60;
        }
        /// <summary>
        /// Заполняет все поля класса передаваемыми значениями.
        /// </summary>
        /// <param name="beginning">Название начального пункта. Должно быть строкой.</param>
        /// <param name="end">Название конечного пункта. Должно быть строкой.</param>
        /// <param name="minuts">Количество минут, которое уходит на путь от начального пункта до конечного. Должно быть целым положительным числом.</param>
        public Flight(string beginning, string end, int minuts)
        {
            this.beginning = beginning;
            this.end = end;
            Minuts = minuts;
        }
    }
}

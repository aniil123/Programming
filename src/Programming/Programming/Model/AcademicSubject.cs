using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные об академическом предмете.
    /// </summary>
    class AcademicSubject
    {
        //Хранит название академического предмета.
        public string appellation { get; set; }
        //Хранит количество пар.
        private int number_of_pairs;
        //Хранит состояние зачета.
        public bool academic_test { get; set; }
        /// <summary>
        /// Возвращает и задает количество пар. Должно быть положительным целым числом.
        /// </summary>
        public int NumberOfPairs
        {
            get
            {
                return number_of_pairs;
            }
            set
            {
                Validator.AssertOnPositiveValue(value);
                number_of_pairs = value;
            }
        }
        /// <summary>
        /// Заполняет поля класса константами.
        /// </summary>
        public AcademicSubject()
        {
            appellation = "Math";
            NumberOfPairs = 23;
            academic_test = true;
        }
        /// <summary>
        /// Заполняет поля класса передаваемыми значениями.
        /// </summary>
        /// <param name="appellation">Название академического предмета. Должно быть строкой.</param>
        /// <param name="number_of_pairs">Количество пар. Должно быть целыми положительным числом.</param>
        /// <param name="academic_test">Состояние зачета. Должно быть объектом типа bool.</param>
        public AcademicSubject(string appellation, int number_of_pairs, bool academic_test)
        {
            this.appellation = appellation;
            NumberOfPairs = number_of_pairs;
            this.academic_test = academic_test;
        }
    }
}

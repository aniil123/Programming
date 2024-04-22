using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    class AcademicSubject
    {
        public string appellation { get; set; }
        private int number_of_pairs;
        public bool academic_test { get; set; }
        public int NumberOfPairs
        {
            get
            {
                return number_of_pairs;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Количество пар не может быть меньше единицы");
                }
                else
                {
                    number_of_pairs = value;
                }
            }
        }
        public AcademicSubject()
        {
            appellation = "Math";
            NumberOfPairs = 23;
            academic_test = true;
        }
        public AcademicSubject(string appellation, int number_of_pairs, bool academic_test)
        {
            this.appellation = appellation;
            NumberOfPairs = number_of_pairs;
            this.academic_test = academic_test;
        }
    }
}

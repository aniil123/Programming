using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит информацию об кольце.
    /// </summary>
    class Ring
    {
        //Хранит радиус внешней окружности кольца.
        private double bol_r = -1;
        //Хранит радиус внутренней окружности кольца.
        private double mal_r = -1;
        //Хранит координату у центра кольца.
        public double xCenter { get; private set; }
        //Хранит координату х центра кольца.
        public double yCenter { get; private set; }
        /// <summary>
        /// Вохвращает и задает радиус внешней окружности кольца. Должен быть числом больше нуля.
        /// </summary>
        public double Bol_r
        {
            get
            {
                return bol_r;
            }
            set
            {
                if (mal_r != -1)
                {
                    Validator.AssertValueInRange(value, mal_r, 922337203);
                }
                else
                {
                    Validator.AssertOnPositiveValue(value);
                }
                bol_r = value;
            }
        }
        /// <summary>
        /// Возвращает и задает радиус внутренней окружности кольца. Должен быть числом больше нуля.
        /// </summary>
        public double Mal_r
        {
            get
            {
                return mal_r;
            }
            set
            {
                if (bol_r != -1)
                {
                    Validator.AssertValueInRange(value, 0, bol_r);
                }
                else
                {
                    Validator.AssertOnPositiveValue(value);
                }
                mal_r = value;
            }
        }
        /// <summary>
        /// Задает координаты центра кольца. Принимает объект типа <see cref="Point2D"/>
        /// </summary>
        private Point2D Center
        {
            set
            {
                xCenter = value.x + bol_r;
                yCenter = value.y + bol_r;
            }
        }
        /// <summary>
        /// Возвращает площадь кольца.
        /// </summary>
        public double Area
        {
            get
            {
                return 3.14*Bol_r*Bol_r - 3.14*Mal_r*Mal_r;
            }
        }
        /// <summary>
        /// Заполняет все поля класса константами.
        /// </summary>
        public Ring()
        {
            Bol_r = 20;
            Mal_r = 15;
            Point2D point = new Point2D(123,-123);
            Center = point;
        }
        /// <summary>
        /// Заполняет все поля класса передаваемыми значениями.
        /// </summary>
        /// <param name="mal_r">Радиус внутренней окуружности кольца. Должен быть числом больше нуля.</param>
        /// <param name="bol_r">Радиус внешней окружности кольца. Должен быть числом больше нуля.</param>
        /// <param name="center">Точка с координатами центра кольца. Объект типа <see cref="Point2D"/></param>
        public Ring(double mal_r, double bol_r, Point2D center)
        {
            Bol_r = bol_r;
            Mal_r = mal_r;
            Center = center;
        }
    }
}

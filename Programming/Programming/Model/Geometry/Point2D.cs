using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит информацию о точке.
    /// </summary>
    class Point2D
    {
        //Хранит координату x.
        public double x;
        //Хранит координату y
        public double y;
        /// <summary>
        /// Возвращает и задает координату x. Должна быть числом.
        /// </summary>
        public double X
        {
            get
            {
                return x;
            }
            private set
            {
                x = value;
            }
        }
        /// <summary>
        /// Возвращает и задает координату y. Должна быть числом.
        /// </summary>
        public double Y
        {
            get
            {
                return y;
            }
            private set
            {
                y = value;
            }
        }
        /// <summary>
        /// Присваивает координатам х и у значение 10.
        /// </summary>
        public Point2D()
        {
            x = 10;
            y = 10;
        }
        /// <summary>
        /// Присваивает координатам х и у передаваемые значения.
        /// </summary>
        /// <param name="x">Должно быть числом</param>
        /// <param name="y">Должно быть числом</param>
        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}

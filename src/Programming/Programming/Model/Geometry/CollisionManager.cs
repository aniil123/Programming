using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Статический класс. Обнаруживает пересечение фигур.
    /// </summary>
    static class CollisionManager
    {
        /// <summary>
        /// Обнаруживает пересечение двух прямоугольников.
        /// </summary>
        /// <param name="rectangle1">Объект типа <see cref="Rectangle"/></param>
        /// <param name="rectangle2">Объект типа <see cref="Rectangle"/></param>
        /// <returns>Возвращает true, если прямоугольники пересекаются, и false,если нет.</returns>
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            //Нужно для хранения информации о пересечении.
            bool intersection = false;
            if((rectangle1.Length+rectangle2.Length)/2 >= Math.Abs(rectangle1.xCenter - rectangle2.xCenter) && (rectangle1.Width + rectangle2.Width) / 2 >= Math.Abs(rectangle1.yCenter - rectangle2.yCenter))
            {
                intersection = true;
            }
            return intersection;
        }
        /// <summary>
        /// Обнаруживает пересечение двух колец.
        /// </summary>
        /// <param name="ring1">Объект типа <see cref="Ring"/></param>
        /// <param name="ring2">Объект типа <see cref="Ring"/></param>
        /// <returns>Возвращает true, если кольца пересекаются, и false,если нет.</returns>
        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            //Нужно для хранения информации о пересечении.
            bool intersection = false;
            if(ring1.Bol_r+ring2.Bol_r >= Math.Sqrt(Math.Pow(Math.Abs(ring1.xCenter - ring2.xCenter), 2) + Math.Pow(Math.Abs(ring1.yCenter - ring2.yCenter), 2)))
            {
                intersection = true;
            }
            return intersection;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит информацию о прямоугольниках
    /// </summary>
    public class Rectangle
    {
        //Хранит длину прямоугольника.
        private int length;
        //Хранит ширину прямоугольника.
        private int width;
        //Хранит цвет прямоугольника.
        public string color { get; set; }
        //Хранит координату х центра прямоугльника.
        public double xCenter { get; private set; }
        //Хранит координату у центра прямоугольника.
        public double yCenter { get; private set; }
        //Хранит координату х левого верхнего угла прямоугольника.
        private double x;
        //Хранит координату у левого верхнего угла прямоугольника.
        private double y;
        //Хранит количество созданных прямоугольников.
        private static int _allRectanglesCount = 0;
        //Уникальный идентификатор для всех объектов данного класса.
        public int _id { get; private set; }
        /// <summary>
        /// Возвращает и задает длину прямоугольника. Должна быть числом больше нуля.
        /// </summary>
        public int Length
        {
            get
            {
                return length;
            }
            set
            {
                Validator.AssertValueInRange(value, 1, 2147483647);
                length = value;
                Point2D point = new Point2D(x, y);
                Center = point;
            }
        }
        /// <summary>
        /// Возвращает и задает ширину прямоугольника. Должна быть числом больше нуля.
        /// </summary>
        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                Validator.AssertValueInRange(value, 1, 2147483647);
                width = value;
                Point2D point = new Point2D(x, y);
                Center = point;
            }
        }
        /// <summary>
        /// Задает значение координатам центра прямоугольника. Принимает объект типа <see cref="Point2D"/>
        /// </summary>
        private Point2D Center
        {
            set
            {
                xCenter = value.x + Length / 2;
                yCenter = value.y + Width / 2;
            }
        }
        /// <summary>
        /// Возвращает и задает значение координате х левого верхнего угла прямоугольника. Должна быть числом.
        /// </summary>
        public double X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
                Point2D point = new Point2D(x,y);
                Center = point;
            }
        }
        /// <summary>
        /// Возвращает и задает значение координате у левого верхнего угла прямоугольника. Должна быть числом.
        /// </summary>
        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
                Point2D point = new Point2D(x, y);
                Center = point;
            }
        }
        /// <summary>
        /// Возвращает количество созданных прямоугольников.
        /// </summary>
        public static int AllRectanglesCount
        {
            get
            {
                return _allRectanglesCount;
            }
        }
        /// <summary>
        /// Задает значение id прямоугольника. Должно быть числом.
        /// </summary>
        private int ID
        {
            set
            {
                _id = value;
            }
        }
        /// <summary>
        /// Заполняет поля класса константами.
        /// </summary>
        public Rectangle()
        {
            length = 10;
            width = 5;
            color = "blue";
            X = 123;
            Y = 167;
            _allRectanglesCount += 1;
            ID = AllRectanglesCount;
        }
        /// <summary>
        /// Заполняет поля класса передаваемыми значениями.
        /// </summary>
        /// <param name="length">Длина. Должна быть числом больше нуля.</param>
        /// <param name="width">Ширина. Должна быть числом больше нуля.</param>
        /// <param name="x">Координата х левого верхнего угла прямоугольника. Должна быть числом.</param>
        /// <param name="y">Координата у левого верхнего угла прямоугольника. Должна быть числом.</param>
        public Rectangle(int length, int width , double x, double y)
        {
            Length = length;
            Width = width;
            color = "blue";
            X = x;
            Y = y;
            _allRectanglesCount += 1;
            ID = AllRectanglesCount;
        }
    }
}

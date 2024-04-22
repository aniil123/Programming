using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Rectangle
    {
        private int length;
        private int width;
        public string color { get; set; }
        public int Length
        {
            get
            {
                return length;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Длина прямоугольника не может быть меньше или равна нулю");
                }
                else
                {
                    length = value;
                }
            }
        }
        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Ширина прямоугольника не может быть меньше или равна нулю");
                }
                else
                {
                    width = value;
                }
            }
        }
        public Rectangle()
        {
            length = 10;
            width = 5;
            color = "blue";
        }
        public Rectangle(int length, int width)
        {
            Length = length;
            Width = width;
            color = "blue";
        }
    }
}

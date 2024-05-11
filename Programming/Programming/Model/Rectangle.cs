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
        public double xCenter { get; private set; }
        public double yCenter { get; private set; }
        private double x;
        private double y;
        private static int _allRectanglesCount = 0;
        public int _id { get; private set; }
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
        private Point2D Center
        {
            set
            {
                xCenter = value.x + Length / 2;
                yCenter = value.y + Width / 2;
            }
        }
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
        public static int AllRectanglesCount
        {
            get
            {
                return _allRectanglesCount;
            }
        }
        private int ID
        {
            set
            {
                _id = value;
            }
        }
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
        public Rectangle(int length, int width , double x, double y)
        {
            Random rand = new Random();
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

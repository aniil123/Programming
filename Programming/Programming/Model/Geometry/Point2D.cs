using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    class Point2D
    {
        public double x;
        public double y;
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
        public Point2D()
        {
            x = 10;
            y = 10;
        }
        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}

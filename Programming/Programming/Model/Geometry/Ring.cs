using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    class Ring
    {
        private Point2D centre;
        private double bol_r = -1;
        private double mal_r = -1;
        public double xCenter { get; private set; }
        public double yCenter { get; private set; }
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
        private Point2D Center
        {
            set
            {
                xCenter = value.x + bol_r;
                yCenter = value.y + bol_r;
            }
        }
        public double Area
        {
            get
            {
                return 3.14*Bol_r*Bol_r - 3.14*Mal_r*Mal_r;
            }
        }
        public Ring()
        {
            centre = new Point2D();
            Bol_r = 20;
            Mal_r = 15;
            Point2D point = new Point2D(123,-123);
            Center = point;
        }
        public Ring(double mal_r, double bol_r, Point2D centre)
        {
            Random rand = new Random();
            this.centre = centre;
            Bol_r = bol_r;
            Mal_r = mal_r;
            Point2D point = new Point2D(rand.Next(-200,200), rand.Next(-200,200));
            Center = point;
        }
    }
}

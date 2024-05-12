using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Geometry
{
    static class RectangleFactory
    {
        public static Rectangle Randomize()
        {
            Random rand = new Random();
            return new Rectangle(rand.Next(50, 150), rand.Next(50, 150), rand.Next(0, 600), rand.Next(0, 320));
        }
    }
}

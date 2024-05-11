using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    static class CollisionManager
    {
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            bool intersection = false;
            if((rectangle1.Length+rectangle2.Length)/2 >= Math.Abs(rectangle1.xCenter - rectangle2.xCenter) && (rectangle1.Width + rectangle2.Width) / 2 >= Math.Abs(rectangle1.yCenter - rectangle2.yCenter))
            {
                intersection = true;
            }
            return intersection;
        }
        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            bool intersection = false;
            if(ring1.Bol_r+ring2.Bol_r >= Math.Sqrt(Math.Pow(Math.Abs(ring1.xCenter - ring2.xCenter), 2) + Math.Pow(Math.Abs(ring1.yCenter - ring2.yCenter), 2)))
            {
                intersection = true;
            }
            return intersection;
        }
    }
}

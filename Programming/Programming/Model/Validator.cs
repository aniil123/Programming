using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public static class Validator
    {
        public static void AssertOnPositiveValue(int value, [System.Runtime.CompilerServices.CallerMemberName] string MethodName = "")
        {
            if(value<0)
            {
                throw new Exception("Произошла ошибка при работе метода "+MethodName);
            }
        }
        public static void AssertOnPositiveValue(double value, [System.Runtime.CompilerServices.CallerMemberName] string MethodName = "")
        {
            if (value < 0)
            {
                throw new Exception("Произошла ошибка при работе метода " + MethodName);
            }
        }
        public static void AssertValueInRange(double value, double min, double max, [System.Runtime.CompilerServices.CallerMemberName] string MethodName = "")
        {
            if(value > max||value < min)
            {
                throw new Exception("Произошла ошибка при работе метода " + MethodName);
            }
        }
    }
}

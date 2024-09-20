using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Проверяет является ли число пренадлежащим к нужному диапозону.
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Проверяет является ли целое число отрицательным. Если передаваемое целое число является отрицательным, выводится сообщение об ошибке.
        /// </summary>
        /// <param name="value">Целое число, которое проверяется на отрицательность.</param>
        /// <param name="MethodName"></param>
        public static void AssertOnPositiveValue(int value, [System.Runtime.CompilerServices.CallerMemberName] string MethodName = "")
        {
            if(value<0)
            {
                throw new Exception("Произошла ошибка при работе метода "+MethodName);
            }
        }
        /// <summary>
        /// Проверяет является ли вещественное число отрицательным. Если передаваемое вещественное число является отрицательным, выводится сообщение об ошибке.
        /// </summary>
        /// <param name="value">Вещественное число, которое проверяется на отрицательность.</param>
        /// <param name="MethodName"></param>
        public static void AssertOnPositiveValue(double value, [System.Runtime.CompilerServices.CallerMemberName] string MethodName = "")
        {
            if (value < 0)
            {
                throw new Exception("Произошла ошибка при работе метода " + MethodName);
            }
        }
        /// <summary>
        /// Проверяет является ли передаваемое вещественное число принадлежащим к передаемому дипазону. Если вещественное число не входит в диапозон, выводится сообщение об ошибке.
        /// </summary>
        /// <param name="value">Вещественное число, которое проверяется на пренадлежность передаваемому диапозону. Должно быть числом.</param>
        /// <param name="min">Минимальное число диапозона. Должно быть числом.</param>
        /// <param name="max">Максимальное число диапозона. Должно быть числом.</param>
        /// <param name="MethodName"></param>
        public static void AssertValueInRange(double value, double min, double max, [System.Runtime.CompilerServices.CallerMemberName] string MethodName = "")
        {
            if(value > max||value < min)
            {
                throw new Exception("Произошла ошибка при работе метода " + MethodName);
            }
        }
    }
}

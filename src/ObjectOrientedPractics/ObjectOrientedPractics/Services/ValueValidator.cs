using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Проверяет значение на наличие ошибок.
    /// </summary>
    static class ValueValidator
    {
        //Строка, содержащая символы русского алфавита.
        private static string _alphobet = "йцукенгшщзхъфывапролджэячсмитьбюёЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮЁ";
        public static int a = 0;
        /// <summary>
        /// Возвращаяет строку, содержащую символы русского алфавита.
        /// </summary>
        public static string Alphobet
        {
            get
            {
                return _alphobet;
            }
        }
        /// <summary>
        /// Проверяет длину строки. Если длина строки больше заданного значения, вызывается исключение.
        /// </summary>
        /// <param name="value">Значение должно быть строковым.</param>
        /// <param name="maxLength">Значение должно быть целочисленным.</param>
        /// <param name="propertyName"></param>
        public static void AssertStringOnLength(string value, int maxLength, [System.Runtime.CompilerServices.CallerMemberName] string propertyName = "")
        {
            if(value.Length > maxLength)
            {
                throw new Exception($"{propertyName} должно быть меньше {maxLength}");
            }
        }
        /// <summary>
        /// Проверяет строку на наличие недопустимых символов.
        /// </summary>
        /// <param name="StringToCheck">Проверяемая строка.</param>
        /// <param name="ValidCharacters">Строка содержащая допустимые символы.</param>
        public static void CheckingString(string StringToCheck, string ValidCharacters, [System.Runtime.CompilerServices.CallerMemberName] string propertyName = "")
        {
            a++;
            bool flag;
            foreach(var i in StringToCheck.ToCharArray())
            {
                flag = false;
                foreach(var j in ValidCharacters.ToCharArray())
                {
                    if(i == j)
                    {
                        flag = true;
                        break;
                    }
                }
                if(flag)
                {
                    continue;
                }
                throw new Exception($"В {propertyName} есть недопустимые символы");
            }

        }
    }
}

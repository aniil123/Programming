using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba8.Other
{
    /// <summary>
    /// Статический класс. Проверяет строку на наличие не нужных символов.
    /// </summary>
    static class AssertString
    {
        /// <summary>
        /// Проверяет строку на наличие символов отличных от символов русского алфавита.
        /// </summary>
        /// <param name="word">Проверяемая строка.</param>
        public static void CheckingCharacters(string word)
        {
            bool MainFlag = true, flag;
            string alf = "йцукенгшщзхъфывапролджэячсмитьбюЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮ";
            foreach (char i in word)
            {
                flag = false;
                foreach (char j in alf)
                {
                    if (i == j)
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == false)
                {
                    MainFlag = false;
                    break;
                }
            }
            if (MainFlag == false)
            {
                throw new Exception("Вы ввели неверный символ или недописали полное имя");
            }
        }
        /// <summary>
        /// Проверяет строку на наличие символов отличных от символов русского алфавита, но допускает символы переданные в качестве аргумента.
        /// </summary>
        /// <param name="word">Проверяемая строка.</param>
        /// <param name="exceptions">Строка содержащая символы, которые допускаются.</param>
        public static void CheckingCharactersWithExceptions(string word, string exceptions)
        {
            bool MainFlag = true, flag;
            string alf = "йцукенгшщзхъфывапролджэячсмитьбюЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮ" + exceptions;
            foreach (char i in word)
            {
                flag = false;
                foreach (char j in alf)
                {
                    if (i == j)
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == false)
                {
                    MainFlag = false;
                    break;
                }
            }
            if (MainFlag == false)
            {
                throw new Exception("Вы ввели неверный символ или недописали должность");
            }
        }
    }
}

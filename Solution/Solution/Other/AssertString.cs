using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Other
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
        /// <param name="MemberName"></param>
        public static void CheckingCharacters(string word, [System.Runtime.CompilerServices.CallerMemberName] string MemberName = "")
        {
            bool MainFlag = true, flag;
            string alf = "йцукенгшщзхъфывапролджэячсмитьбюЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮ";
            foreach(char i in word)
            {
                flag = false;
                foreach(char j in alf)
                {
                    if(i == j)
                    {
                        flag = true;
                        break;
                    }
                }
                if(flag == false)
                {
                    MainFlag = false;
                    break;
                }
            }
            if(MainFlag == false)
            {
                throw new Exception("Произошла ошибка при работе метода " + MemberName);
            }
        }
        public static void CheckingCharactersWithExceptions(string word, string exceptions,[System.Runtime.CompilerServices.CallerMemberName] string MemberName = "")
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
                throw new Exception("Произошла ошибка при работе метода " + MemberName);
            }
        }
    }
}

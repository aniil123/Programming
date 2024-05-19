using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Other
{
    /// <summary>
    /// Хранит информацию о работнике.
    /// </summary>
    class Worker
    {
        //Полное имя работника.
        private string _fullName;
        //Должность работника.
        private string post;
        //Дата трудоустройства работника.
        private DateTime date;
        //Зарплата работника.
        private int salary;
        /// <summary>
        /// Возвращает и задает полное имя работника. Должно быть строкой, количество символов которой не больше 100 и не меньше 5.
        /// </summary>
        public string FullName
        {
            get
            {
                return _fullName;
            }
            set
            {
                if(value.Length > 100 || value.Length < 5)
                {
                    throw new Exception("Количество символов в полном имени должно быть не больше 100 и не меньше 5");
                }
                string str = "";
                int KolWords = 0;
                for(int i = 0;i < value.Length;i++)
                {

                    if(value[i] == ' ' && str.Length == 0)
                    {
                        throw new Exception("Ошибка(лишний пробел в полном имени)");
                    }
                    else if(i == value.Length - 1)
                    {
                        str += value[i];
                        AssertString.CheckingCharacters(str);
                        str = "";
                        KolWords += 1;
                    }
                    else if(value[i] == ' ')
                    {
                        AssertString.CheckingCharacters(str);
                        str = "";
                        KolWords += 1;
                    }
                    else
                    {
                        str += value[i];
                    }
                }
                if(KolWords != 3)
                {
                    throw new Exception("В полном имени недостаточно слов");
                }
                string alf = "ёйцукенгшщзхъфывапролджэячсмитьбюЁЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮ";
                char[] CharValue = value.ToCharArray();
                for(int i = 0;i < value.Length;i++)
                {
                    if(i == 0 || value[i-1] == ' ' && value[i] != ' ')
                    {
                        if(alf.IndexOf(value[i]) < 33)
                        {
                            CharValue[i] = alf[alf.IndexOf(value[i]) + 33];
                        }
                    }
                    else if(value[i] != ' ')
                    {
                        if(alf.IndexOf(value[i]) > 32)
                        {
                            CharValue[i] = alf[alf.IndexOf(value[i]) - 33];
                        }
                    }
                }
                string stroka = "";
                foreach(var i in CharValue)
                {
                    stroka += i;
                }
                _fullName = stroka;
            }
        }
        /// <summary>
        /// Возвращает и задает должность работника. Должна быть строкой, количество символов которой не больше 50 и не меньше 2.
        /// </summary>
        public string Post
        {
            get
            {
                return post;
            }
            set
            {
                if(value.Length > 50 || value.Length < 2)
                {
                    throw new Exception("Количество символов в должности должно быть не больше 50 и не меньше 2");
                }
                string str = " -qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
                AssertString.CheckingCharactersWithExceptions(value, str);
                string alf = "ёйцукенгшщзхъфывапролджэячсмитьбюЁЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮ";
                char[] CharValue = value.ToCharArray();
                for (int i = 0; i < value.Length; i++)
                {
                    if (i == 0)
                    {
                        if (alf.IndexOf(value[i]) < 33 && alf.IndexOf(value[i]) != -1)
                        {
                            CharValue[i] = alf[alf.IndexOf(value[i]) + 33];
                        }
                    }
                    else
                    {
                        if (alf.IndexOf(value[i]) > 32)
                        {
                            CharValue[i] = alf[alf.IndexOf(value[i]) - 33];
                        }
                    }
                }
                string stroka = "";
                foreach (var i in CharValue)
                {
                    stroka += i;
                }
                post = stroka;
            }
        }
        /// <summary>
        /// Возвращает и задает дату трудоустройства работника. Должна быть типа DateTime.
        /// </summary>
        public DateTime Date
        {
            get
            {
                return date;
            }
            set
            {
                if(value > DateTime.Now)
                {
                    throw new Exception("Работник не мог устроиться в эту дату");
                }
                date = value;
            }
        }
        /// <summary>
        /// Возвращает и задает зарплату работника. Должна быть целым неотрицательным числом не больше 500000.
        /// </summary>
        public int Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if(value<0 || value>500000)
                {
                    throw new Exception("Зарплата не может быть меньше 0 или больше 500000");
                }
                salary = value;
            }
        }
        /// <summary>
        /// Заполняет все поля класса константами.
        /// </summary>
        public Worker()
        {
            FullName = "Неизвестно Неизвестно Неизвестно";
            Post = "Неизвестно";
            Date = new DateTime(2001,01,01);
            Salary = 0;
        }
        /// <summary>
        /// Заполняет все поля класса передаваемыми значениями.
        /// </summary>
        /// <param name="_fullName">Полное имя. Должно быть строкой.</param>
        /// <param name="post">Должность. Должна быть строкой.</param>
        /// <param name="date">Дата трудоустройства. Должна быть типа DateTime.</param>
        /// <param name="salary">Зарплата. Должна быть целым неотрицательным числом.</param>
        public Worker(string _fullName, string post, DateTime date, int salary)
        {
            FullName = _fullName;
            Post = post;
            Date = date;
            Salary = salary;
        }
    }
}

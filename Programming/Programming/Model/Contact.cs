using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит информацию о контакте в телефонной книжке.
    /// </summary>
    class Contact
    {
        //Хранит номер телефона.
        private string phone_number;
        //Хранит имя.
        private string name;
        //Хранит фамилию.
        private string sur_name;
        //Хранит количество пропущенных звонков.
        private int kol_prop;
        /// <summary>
        /// Возвращает и задает имя. Должно быть строкой.
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                AssertStringContainsOnlyLetters(value);
                name = value;
            }
        }
        /// <summary>
        /// Возвращает и задает фамилию. Должна быть строкой.
        /// </summary>
        public string SurName
        {
            get
            {
                return sur_name;
            }
            set
            {
                AssertStringContainsOnlyLetters(value);
                sur_name = value;
            }
        }
        /// <summary>
        /// Возвращает и задает номер телефона. Должен быть строкой, содержать в себе только цифры, начинаться с символа '8' и состоять из 11-и символов.
        /// </summary>
        public string PhoneNumber
        {
            get
            {
                return phone_number;
            }
            set
            {
                if (value[0] == '8' && value.Length == 11 && long.TryParse(value, out long a) == true)
                {
                    phone_number = value;
                }
                else
                {
                   throw new Exception("Неверный номер телефона");
                }
            }
        }
        /// <summary>
        /// Возвращает и задает количество пропущенных звонков. Должно быть целым положительным числом.
        /// </summary>
        public int KolProp
        {
            get
            {
                return kol_prop;
            }
            set
            {
                Validator.AssertOnPositiveValue(value);
                kol_prop = value;
            }
        }
        /// <summary>
        /// Заполняет поля класса константами.
        /// </summary>
        public Contact()
        {
            PhoneNumber = "89001233219";
            Name = "Sasha";
            SurName = "Gaberu";
            KolProp = 3;
        }
        /// <summary>
        /// Заполняет поля класса передаваемыми значениями.
        /// </summary>
        /// <param name="phone_number">Номер телефона. Должен быть строкой.</param>
        /// <param name="name">Имя. Должно быть строкой.</param>
        /// <param name="sur_name">Фамилия. Должна быть строкой.</param>
        /// <param name="kol_prop">Количество пропущенных звонков. Должно быть целым положительным числом.</param>
        public Contact(string phone_number, string name, string sur_name, int kol_prop)
        {
            PhoneNumber = phone_number;
            Name = name;
            KolProp = kol_prop;
            SurName = sur_name;
        }
        /// <summary>
        /// Проверяет строку на наличие лишних символов. Если в строке содержаться символы, которые не являются латинскими буквами, появляется сообщение об ошибке.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="memberName"></param>
        private void AssertStringContainsOnlyLetters(string value, [System.Runtime.CompilerServices.CallerMemberName] string memberName = "")
        {
            foreach(var i in value)
            {
                if((Convert.ToInt32(i)<65 || Convert.ToInt32(i)>90) && (Convert.ToInt32(i)<97 || Convert.ToInt32(i)>122))
                {
                    throw new Exception("При вызове метода " + memberName + " произошла ошибка");
                }
            }
        }

    }
}

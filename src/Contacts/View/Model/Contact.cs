using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Model
{
    //Контактные данные человека
    class Contact
    {
        //Имя
        private string _name;
        //Телефонный номер
        private int _phoneNumber;
        //Почта
        private string _email;
        //Возвращает и задает имя. Должно быть строковым и размером не больше 50-и.
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if(value.Length < 50)
                {
                    _name = value;
                }
                else
                {
                    throw new Exception("Размер имени больше 50-и");
                }
            }
        }
        //Возвращает и задает номер телефона. Должно быть положительным целочисленным с количеством символов равном 11-и и с символом 8 на первом месте.
        public int PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                if(value > 0 && Convert.ToString(value).Length == 11  && value / Math.Pow(10, 11) == 8)
                {
                    _phoneNumber = value;
                }
                else
                {
                    throw new Exception("Неправильный номер");
                }
            }
        }
        //Возвращает и задает почту. Должно быть строковым.
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                Email = value;
            }
        }
        public Contact(){}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Model
{
    /// <summary>
    /// Контактные данные человека
    /// </summary>
    public class Contact
    {
        //Имя
        private string _name;
        //Телефонный номер
        private string _phoneNumber;
        //Почта
        private string _email;
        /// <summary>
        /// Возвращает и задает имя. Должно быть строковым и размером не больше 50-и.
        /// </summary>
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
        /// <summary>
        /// Возвращает и задает номер телефона. 
        /// Должно быть строковым с размером 11 символов.
        /// </summary>
        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                _phoneNumber = value;
            }
        }
        /// <summary>
        /// Возвращает и задает почту. Должно быть строковым.
        /// </summary>
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
        /// <summary>
        /// Заполняет поля класса значениями по умолчанию.
        /// </summary>
        public Contact()
        {
            Name = "Игорь";
            PhoneNumber = "89992223334";
            Email = "standart_email@gmail.com";
        }
    }
}

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
        /// Возвращает и задает имя.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        /// <summary>
        /// Возвращает и задает номер телефона. 
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
        /// Возвращает и задает почту.
        /// </summary>
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }
        public Contact(){}
    }
}

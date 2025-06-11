using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Contact
    {
        /// <summary>
        /// Имя.
        /// </summary>
        private string _name = "";

        /// <summary>
        /// Номер телефона.
        /// </summary>
        private string _phoneNumber = "";

        /// <summary>
        /// Почта.
        /// </summary>
        private string _email = "";

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

        /// <summary>
        /// Создает объект класса <see cref="Contact"/>.
        /// </summary>
        public Contact() { }
    }
}

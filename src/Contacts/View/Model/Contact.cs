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
        /// <summary>
        /// Имя
        /// </summary>
        private string _name;

        /// <summary>
        /// Телефонный номер
        /// </summary>
        private string _phoneNumber;

        /// <summary>
        /// Почта
        /// </summary>
        private string _email;

        /// <summary>
        /// Возвращает и задает имя.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает и задает номер телефона. 
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Возвращает и задает почту.
        /// </summary>
        public string Email { get; set; }

        public Contact(){}
    }
}

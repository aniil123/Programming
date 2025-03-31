using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.ViewModel
{
    class MainVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Контактные данные человека.
        /// </summary>
        private Model.Contact Contact;
        /// <summary>
        /// Возвращает и задает имя. Должно быть строковым и размером не больше 50-и.
        /// </summary>
        public string Name
        {
            get
            {
                return Contact.Name;
            }
            set
            {
                Contact.Name = value;
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
                return Contact.PhoneNumber;
            }
            set
            {
                Contact.PhoneNumber = value;
            }
        }
        /// <summary>
        /// Возвращает и задает почту. Должно быть строковым.
        /// </summary>
        public string Email
        {
            get
            {
                return Contact.Email;
            }
            set
            {
                Contact.Email = value;
            }
        }
        public MainVM()
        {
            Contact = new Model.Contact();
        }
    }
}

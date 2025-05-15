using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace View.ViewModel
{
    public class ContactVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Событие, которое вызывается при изминении свойств класса.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Контактные данные.
        /// </summary>
        public Model.Contact Contact { get; set; }

        /// <summary>
        /// Возвращает и задает значение свойства Name объекта Contact типа <see cref="Model.Contact"/>. Должно быть типа string.
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
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Name"));
                }
            }
        }

        /// <summary>
        /// Возвращает и задает значение свойства PhoneNumber объекта Contact типа <see cref="Model.Contact"/>. Должно быть типа string.
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
                if(PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("PhoneNumber"));
                }
            }
        }

        /// <summary>
        /// Возвращает и задает значение свойства Email объекта Contact типа <see cref="Model.Contact"/>. Должно быть типа string.
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
                if(PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Email"));
                }
            }
        }

        /// <summary>
        /// Присваивает переменной Contact объект типа <see cref="Model.Contact"/>.
        /// </summary>
        public ContactVM()
        {
            Contact = new Model.Contact();
        }

        /// <summary>
        /// Присваивает переменной Contact объект типа <see cref="Model.Contact"/>.
        /// </summary>
        public ContactVM(Model.Contact contact)
        {
            Contact = contact;
        }
    }
}

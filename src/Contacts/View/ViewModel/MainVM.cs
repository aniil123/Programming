using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.ViewModel
{
    public class MainVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        //Контактные данные человека.
        public Model.Contact Contact{ get; set; }
        /// <summary>
        /// Возвращает и задает имя.
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
            }
        }
        /// <summary>
        /// Возвращает и задает номер телефона. 
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PhoneNumber"));
            }
        }
        /// <summary>
        /// Возвращает и задает почту.
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Email"));
            }
        }
        public void NameChanged(string name)
        {
            Name = name;
        }
        public void PhoneNumberChanged(string phoneNumber)
        {
            PhoneNumber = phoneNumber;
        }
        public void EmailChanged(string email)
        {
            Email = email;
        }
        public MainVM()
        {
            Contact = new Model.Contact();
        }
    }
}

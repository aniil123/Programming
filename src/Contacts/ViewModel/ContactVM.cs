using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ViewModel
{
    public class ContactVM : INotifyPropertyChanged, IDataErrorInfo
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
                    PropertyChanged(this, new PropertyChangedEventArgs("Name"));
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
                bool acceptableValue = true;
                string acceptableCharacters = "0123456789-+()";
                foreach (char valueChar in value)
                {
                    acceptableValue = false;
                    foreach (char acceptableCharacter in acceptableCharacters)
                    {
                        if (valueChar == acceptableCharacter)
                        {
                            acceptableValue = true;
                            break;
                        }
                    }
                    if (!acceptableValue)
                        break;
                }
                if (acceptableValue)
                {
                    Contact.PhoneNumber = value;
                    if (PropertyChanged != null)
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
                    PropertyChanged(this, new PropertyChangedEventArgs("Email"));
            }
        }

        public string this[string columnName]
        {
            get
            {
                string error = String.Empty;
                switch (columnName)
                {
                    case "Name":
                        if (Name == "")
                        {
                            error = "Имя не должно быть пустым.";
                        }
                        else if (Name.Length > 100)
                        {
                            error = "Имя не должно содержать больше 100 символов.";
                        }
                        break;
                    case "PhoneNumber":
                        if (PhoneNumber == "")
                        {
                            error = "Номер телефона не должен быть пустым.";
                            break;
                        }
                        if (PhoneNumber.Length > 100)
                        {
                            error = "Номер телефона не должен содержать больше 100 символов.";
                            break;
                        }
                        break;
                    case "Email":
                        if (Email == "")
                        {
                            error = "Почта не должна быть пустой.";
                            break;
                        }
                        if (Email.Length > 100)
                        {
                            error = "Почта не должна содержать больше 100 символов.";
                            break;
                        }
                        bool acceptable = false;
                        foreach (char emailSim in Email)
                        {
                            if (emailSim == '@')
                            {
                                if (acceptable)
                                {
                                    error = "Должен быть только 1 символ @.";
                                    break;
                                }
                                acceptable = true;
                            }
                        }
                        if (!acceptable)
                        {
                            error = "В почте должен быть символ @.";
                        }
                        break;
                }
                return error;
            }
        }

        public string Error
        {
            get
            {
                throw new NotImplementedException();
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

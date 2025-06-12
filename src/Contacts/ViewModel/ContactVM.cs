using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ViewModel
{
    public class ContactVM : ObservableObject, IDataErrorInfo
    {
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
                OnPropertyChanged();
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
                    OnPropertyChanged();
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
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Возвращает не пустую строку, если поле с названием columnName содержит некорректное значение, или пустую - если нет.
        /// </summary>
        public string this[string columnName]
        {
            get
            {
                string error = String.Empty;
                if (columnName == null || columnName == "Name")
                {
                    if (Name == "")
                    {
                        error = "Имя не должно быть пустым.";
                    }
                    else if (Name.Length > 100)
                    {
                        error = "Имя не должно содержать больше 100 символов.";
                    }
                }
                if (columnName == null || columnName == "PhoneNumber")
                {
                    if (PhoneNumber == "")
                    {
                        error = "Номер телефона не должен быть пустым.";
                    }
                    else if (PhoneNumber.Length > 100)
                    {
                        error = "Номер телефона не должен содержать больше 100 символов.";
                    }
                }
                if (columnName == null || columnName == "Email")
                {
                    if (Email == "")
                    {
                        error = "Почта не должна быть пустой.";
                    }
                    else if (Email.Length > 100)
                    {
                        error = "Почта не должна содержать больше 100 символов.";
                    }
                    else
                    {
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
                    }
                }
                if (columnName != null)
                    OnPropertyChanged("HaveError");
                return error;
            }
        }

        /// <summary>
        /// Возвращает не пустую строку, если в полях объекта есть некорректные значения, или пустую - если их нет.
        /// </summary>
        public string Error
        {
            get
            {
                return this[null];
            }
        }

        /// <summary>
        /// Возвращает true, если в полях этого объекта нет некорректных значений, или false - если есть.
        /// </summary>
        public bool HaveError
        {
            get
            {
                return Error == "";
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows;
using View.ViewModel.Commands;
using System.Windows.Navigation;
using System.Windows.Input;
using System.Windows.Forms;

namespace View.ViewModel
{
    /// <summary>
    ///  Главный класс слоя ViewModel.
    /// </summary>
    public class MainVM : INotifyPropertyChanged, IDataErrorInfo
    {
        /// <summary>
        /// Состояние приложения.
        /// </summary>
        private Modes _mode = Modes.Viewing;

        /// <summary>
        /// Объект класса <see cref="ContactVM"/>, выбранный в данный момент в ListBox.
        /// </summary>
        private ContactVM _currentContactVM;

        /// <summary>
        /// Объект класса <see cref="ContactVM"/> для заполнения через текстовые поля.
        /// </summary>
        private ContactVM _inputContactVM = new ContactVM();

        /// <summary>
        /// Содержит значение true, если свойство Name объекта InputContactVM содержит допустимое значение, false - если нет.
        /// </summary>
        private bool _acceptableName;

        /// <summary>
        /// Содержит true, если свойство PhoneNumber объекта InputContactVM содержит допустимое значение, false - если нет.
        /// </summary>
        private bool _acceptablePhoneNumber;

        /// <summary>
        /// Содержит true, если свойство Email объекта InputContactVM содержит допустимое значение, false - если нет.
        /// </summary>
        private bool _acceptableEmail;

        /// <summary>
        /// Коллекция объектов <see cref="ContactVM"/>.
        /// </summary>
        public ObservableCollection<ContactVM> Contacts { get; set; }

        /// <summary>
        /// Событие, которое вызывается при изменении свойств класса.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Возвращает и задает состояние приложения. Должно быть типа <see cref="Modes"/>.
        /// </summary>
        public Modes Mode
        {
            get
            {
                return _mode;
            }
            set
            {
                _mode = value;
                OnPropertyChanged();
                OnPropertyChanged("CanAdd");
                OnPropertyChanged("CanEditAndRemove");
            }
        }

        /// <summary>
        /// Возвращает и задает выбранный в данный момент в ListBox объект <see cref="ContactVM"/>.
        /// </summary>
        public ContactVM CurrentContactVM
        {
            get
            {
                return _currentContactVM;
            }
            set
            {
                _currentContactVM = value;
                OnPropertyChanged();
                OnPropertyChanged("Name");
                OnPropertyChanged("PhoneNumber");
                OnPropertyChanged("Email");
                OnPropertyChanged("CanEditAndRemove");
            }
        }

        /// <summary>
        /// Возвращает объект <see cref="ContactVM"/> для заполнения через текстовые поля.
        /// </summary>
        public ContactVM InputContactVM
        {
            get
            {
                return _inputContactVM;
            }
        }

        /// <summary>
        /// Возвращает true, если в списке контактов выбран объект, или false - если нет.
        /// </summary>
        public bool CanAdd
        {
            get
            {
                return Mode == Modes.Viewing;
            }
        }

        /// <summary>
        /// Возвращает true, если приложение находится в режиме просмотра и в списке контактов выбран объект, или false - если нет.
        /// </summary>
        public bool CanEditAndRemove
        {
            get
            {
                return CurrentContactVM != null && Mode == Modes.Viewing;
            }
        }

        /// <summary>
        /// Возвращает и задает значение определяющее, является ли свойство Name объекта InputContactVM допустимым.
        /// </summary>
        private bool AcceptableName
        {
            get
            {
                return _acceptableName;
            }
            set
            {
                _acceptableName = value;
                OnPropertyChanged("AcceptableValues");
            }
        }

        /// <summary>
        /// Возвращает и задает значение определяющее, является ли свойство PhoneNumber объекта InputContactVM допустимым.
        /// </summary>
        private bool AcceptablePhoneNumber
        {
            get
            {
                return _acceptablePhoneNumber;
            }
            set
            {
                _acceptablePhoneNumber = value;
                OnPropertyChanged("AcceptableValues");
            }
        }

        /// <summary>
        /// Возвращает и задает значение определяющее, является ли свойство Email объекта InputContactVM допустимым.
        /// </summary>
        private bool AcceptableEmail
        {
            get
            {
                return _acceptableEmail;
            }
            set
            {
                _acceptableEmail = value;
                OnPropertyChanged("AcceptableValues");
            }
        }

        /// <summary>
        /// Возвращает true, если свойства объекта InputContactVM содержат допустимые значения, false - если нет.
        /// </summary>
        public bool AcceptableValues
        {
            get
            {
                return AcceptableName == AcceptablePhoneNumber && AcceptablePhoneNumber == AcceptableEmail && AcceptableEmail == true;
            }
        }

        /// <summary>
        /// Возвращает и задает значение свойства Name объекта Contact типа <see cref="ContactVM"/>. Должно быть типа string.
        /// </summary>
        public string Name
        {
            get
            {
                if (Mode == Modes.Viewing)
                {
                    if (CurrentContactVM == null)
                    {
                        return "";
                    }
                    return CurrentContactVM.Name;
                }
                return InputContactVM.Name;
            }
            set
            {
                InputContactVM.Name = value;
            }
        }

        /// <summary>
        /// Возвращает и задает значение свойства PhoneNumber объекта Contact типа <see cref="ContactVM"/>. Должно быть типа string.
        /// </summary>
        public string PhoneNumber
        {
            get
            {
                if (Mode == Modes.Viewing)
                {
                    if (CurrentContactVM == null)
                    {
                        return "";
                    }
                    return CurrentContactVM.PhoneNumber;
                }
                return InputContactVM.PhoneNumber;
            }
            set
            {
                bool acceptableValue = true;
                string acceptableCharacters = "0123456789-+()";
                foreach(char valueChar in value)
                {
                    acceptableValue = false;
                    foreach (char acceptableCharacter in acceptableCharacters)
                    {
                        if(valueChar == acceptableCharacter)
                        {
                            acceptableValue = true;
                            break;
                        }
                    }
                    if (!acceptableValue)
                        break;
                }
                if (acceptableValue)
                    InputContactVM.PhoneNumber = value;
            }
        }

        /// <summary>
        /// Возвращает и задает значение свойства Email объекта Contact типа <see cref="ContactVM"/>. Должно быть типа string.
        /// </summary>
        public string Email
        {
            get
            {
                if (Mode == Modes.Viewing)
                {
                    if (CurrentContactVM == null)
                    {
                        return "";
                    }
                    return CurrentContactVM.Email;
                }
                return InputContactVM.Email;
            }
            set
            {
                InputContactVM.Email = value;
            }
        }

        public string this[string columnName]
        {
            get
            {
                string error = String.Empty;
                if (Mode != Modes.Viewing)
                {
                    switch (columnName)
                    {
                        case "Name":
                            if(Name == "")
                            {
                                error = "Имя не должно быть пустым.";
                            }
                            else if (Name.Length > 100)
                            {
                                error = "Имя не должно содержать больше 100 символов.";
                            }
                            break;
                        case "PhoneNumber":
                            if(PhoneNumber == "")
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
                            if(Email == "")
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
                }
                if(columnName == "Name")
                {
                    AcceptableName = error == String.Empty;
                }
                else if(columnName == "PhoneNumber")
                {
                    AcceptablePhoneNumber = error == String.Empty;
                }
                else
                {
                    AcceptableEmail = error == String.Empty;
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
        /// Присваивание переменной Contact объект типа <see cref="ContactVM"/>
        /// и загружает нее объекты типа <see cref="ContactVM"/>.
        /// </summary>
        public MainVM()
        {
            Contacts = new ObservableCollection<ContactVM>();
            foreach(Model.Contact contact in Model.Services.ContactSerializer.LoadContacts())
            {
                Contacts.Add(new ContactVM(contact));
            }
        }

        public void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName]string propName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
    }
}

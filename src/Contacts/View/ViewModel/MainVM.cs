using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows;
using View.ViewModel.Commands;

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
        /// Коллекция объектов <see cref="ContactVM"/>.
        /// </summary>
        public ObservableCollection<ContactVM> Contacts { get; set; }

        /// <summary>
        /// Объект класса <see cref="ContactVM"/>, выбранный в данный момент в ListBox.
        /// </summary>
        private ContactVM _currentContactVM;

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
                OnPropertyChanged(new List<string>() { "CurrentContactVM", "Name", "PhoneNumber", "Email" });
            }
        }

        /// <summary>
        /// Возвращает и задает значение свойства Name объекта Contact типа <see cref="ContactVM"/>. Должно быть типа string.
        /// </summary>
        public string Name
        {
            get
            {
                if(CurrentContactVM == null)
                {
                    return "";
                }
                return CurrentContactVM.Name;
            }
            set
            {
                CurrentContactVM.Name = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Возвращает и задает значение свойства PhoneNumber объекта Contact типа <see cref="ContactVM"/>. Должно быть типа string.
        /// </summary>
        public string PhoneNumber
        {
            get
            {
                if(CurrentContactVM == null)
                {
                    return "";
                }
                return CurrentContactVM.PhoneNumber;
            }
            set
            {
                CurrentContactVM.PhoneNumber = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Возвращает и задает значение свойства Email объекта Contact типа <see cref="ContactVM"/>. Должно быть типа string.
        /// </summary>
        public string Email
        {
            get
            {
                if (CurrentContactVM == null)
                {
                    return "";
                }
                return CurrentContactVM.Email;
            }
            set
            {
                CurrentContactVM.Email = value;
                OnPropertyChanged();
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
                                error = "Имя не должно быть больше 100 символов.";
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
                                error = "Номер телефона больше 100 символов.";
                                break;
                            }
                            string acceptableCharacters = "01234567890+-()";
                            foreach (char phoneSim in PhoneNumber)
                            {
                                bool acceptable = false;
                                foreach (char ch in acceptableCharacters)
                                {
                                    if (phoneSim == ch)
                                    {
                                        acceptable = true;
                                        break;
                                    }
                                }
                                if (!acceptable)
                                {
                                    error = "В номере телефона недопустимые символы (могут быть только цифры и +-()).";
                                    break;
                                }
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
                                error = "Почта больше 100 символов.";
                                break;
                            }
                            bool acceptable2 = false;
                            foreach (char emailSim in Email)
                            {
                                if (emailSim == '@')
                                {
                                    if (acceptable2)
                                    {
                                        error = "Должен быть только 1 символ @.";
                                        break;
                                    }
                                    acceptable2 = true;
                                }
                            }
                            if (!acceptable2)
                            {
                                error = "В почте должен быть символ @.";
                            }
                            break;
                    }
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

        public void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName]string propName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }

        public void OnPropertyChanged(List<string> propNames)
        {
            if(PropertyChanged != null)
            {
                foreach(string propName in propNames)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(propName));
                }
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
    }
}

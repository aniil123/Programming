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
    public class MainVM : INotifyPropertyChanged
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
        /// Объект класса <see cref="ContactVM"/>, для заполнения через текстовые поля.
        /// </summary>
        private ContactVM _inputContactVM = new ContactVM();

        /// <summary>
        /// Событие, которое вызывается при изменении свойств класса.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Возвращает и задает коллекцию объектов <see cref="ContactVM"/>.
        /// </summary>
        public ObservableCollection<ContactVM> Contacts { get; set; }

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

        private void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName]string propName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
    }
}

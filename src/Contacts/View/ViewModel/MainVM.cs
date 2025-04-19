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
    public class MainVM : DependencyObject, INotifyPropertyChanged
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

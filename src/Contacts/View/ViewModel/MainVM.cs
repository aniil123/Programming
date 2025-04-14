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

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Состояние приложения.
        /// </summary>
        private Modes _mode = Modes.Nothing;

        /// <summary>
        /// Список объектов типа <see cref="ContactVM"/>.
        /// </summary>
        public ObservableCollection<ContactVM> Contacts { get; set; }

        /// <summary>
        /// Объект типа <see cref="ContactVM"/>, выбранный из колекции Contacts.
        /// </summary>
        private ContactVM _currentContactVM;

        /// <summary>
        /// Команда <see cref="AddCommand"/>.
        /// </summary>
        public AddCommand AddCommand { get; set; }

        /// <summary>
        /// Команда <see cref="EditCommand"/>.
        /// </summary>
        public EditCommand EditCommand { get; set; }

        /// <summary>
        /// Команда <see cref="RemoveCommand"/>.
        /// </summary>
        public RemoveCommand RemoveCommand { get; set; }

        /// <summary>
        /// Команда <see cref="ApplyCommand"/>.
        /// </summary>
        public ApplyCommand ApplyCommand { get; set; }

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
                OnPropertyChanged(new List<string>() { "Mode", "AddCommandAvailability", "EditCommandAvailability", "RemoveCommandAvailability", "ApplyCommandAvailability"});
            }
        }

        /// <summary>
        /// Возвращает и задает CurrentContactVM.
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
                Mode = Modes.Nothing;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Возвращает true, если Mode содержит значение Nothing,
        /// false - если содержит любые другие возможные значения для типа <see cref="Modes"/>.
        /// </summary>
        public bool AddCommandAvailability
        {
            get
            {
                return Mode == Modes.Nothing;
            }
        }

        /// <summary>
        /// Возвращает true, если Mode содержит значение Nothing и выбран элемент в ListBox,
        /// false - если Mode содержит любые другие возможные значения для типа <see cref="Modes"/>
        /// или в ListBox не выбран ни один элемент.
        /// </summary>
        public bool EditCommandAvailability
        {
            get
            {
                return Mode == Modes.Nothing && CurrentContactVM != null;
            }
        }

        /// <summary>
        /// Возвращает true, если Mode содержит значение Nothing и выбран элемент в ListBox,
        /// false - если Mode содержит любые другие возможные значения для типа <see cref="Modes"/>
        /// или в ListBox не выбран ни один элемент.
        /// </summary>
        public bool RemoveCommandAvailability
        {
            get
            {
                return Mode == Modes.Nothing && CurrentContactVM != null;
            }
        }

        /// <summary>
        /// Возвращает true, если Mode содержит Add или Edit.
        /// </summary>
        public bool ApplyCommandAvailability
        {
            get
            {
                return Mode != Modes.Nothing;
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
        /// Обработчик события Exit у Application.Current, который сохраняет обекты, находящиеся в коллекции Contacts.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveContacts(object sender, ExitEventArgs e)
        {
            List<Model.Contact> contacts = new List<Model.Contact>();
            foreach(ContactVM contact in Contacts)
            {
                contacts.Add(contact.Contact);
            }
            Model.Services.ContactSerializer.SaveContacts(contacts);
        }

        /// <summary>
        /// Присваивание переменной Contact объект типа <see cref="ContactVM"/>
        /// и загружает в коллекцию Contacts объекты типа <see cref="ContactVM"/>.
        /// </summary>
        public MainVM()
        {
            Contacts = new ObservableCollection<ContactVM>();
            Application.Current.Exit += SaveContacts;
            List<Model.Contact> contacts = Model.Services.ContactSerializer.LoadContacts();
            foreach (Model.Contact contact in contacts)
            {
                Contacts.Add(new ContactVM(contact));
            }
        }

    }
}

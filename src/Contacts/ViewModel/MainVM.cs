using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
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
        /// Объект класса <see cref="ContactVM"/> хранящий корректную копию объекта _currentContactVM.
        /// </summary>
        private ContactVM _cloneContactVM = new ContactVM();

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
                OnPropertyChanged("CanEditAndRemove");
            }
        }

        /// <summary>
        /// Возвращает true, если доступно добавление, или false - если нет.
        /// </summary>
        public bool CanAdd
        {
            get
            {
                return Mode == Modes.Viewing;
            }
        }

        /// <summary>
        /// Возвращает true, если доступно редактирование и удаление, или false - если нет.
        /// </summary>
        public bool CanEditAndRemove
        {
            get
            {
                return Mode == Modes.Viewing && CurrentContactVM != null;
            }
        }

        /// <summary>
        /// Присваивание переменной Contact объект типа <see cref="ContactVM"/>
        /// и загружает нее объекты типа <see cref="ContactVM"/>.
        /// </summary>
        public MainVM()
        {
            Contacts = new ObservableCollection<ContactVM>();
            foreach (Model.Contact contact in Model.Services.ContactSerializer.LoadContacts())
            {
                Contacts.Add(new ContactVM(contact));
            }
        }

        public void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }

        /// <summary>
        /// Делает копию текущего выбранного контакта.
        /// </summary>
        public void MakeClone()
        {
            if (CurrentContactVM != null)
            {
                _cloneContactVM.Name = CurrentContactVM.Name;
                _cloneContactVM.PhoneNumber = CurrentContactVM.PhoneNumber;
                _cloneContactVM.Email = CurrentContactVM.Email;
            }
        }

        /// <summary>
        /// Присваивает всем полям CurrentContactVM значения соответсвующих полей объекта _copyContactVM.
        /// </summary>
        public void UseClone()
        {
            if (CurrentContactVM != null)
            {
                CurrentContactVM.Name = _cloneContactVM.Name;
                CurrentContactVM.PhoneNumber = _cloneContactVM.PhoneNumber;
                CurrentContactVM.Email = _cloneContactVM.Email;
            }
        }
    }
}

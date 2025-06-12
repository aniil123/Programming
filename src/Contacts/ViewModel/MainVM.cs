using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ViewModel
{
    public partial class MainVM : ObservableObject
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
        /// Возвращает команду для перехода в режим добавления нового контакта.
        /// </summary>
        public ICommand AddCommand { get; }

        /// <summary>
        /// Возвращает команду для перехода в режим редактирования выбранного контакта.
        /// </summary>
        public ICommand EditCommand { get; }

        /// <summary>
        /// Возвращает команду для удаления выбранного контакта.
        /// </summary>
        public ICommand RemoveCommand { get; }

        /// <summary>
        /// Возвращает команду для подтверждения добавления или редактирования контакта.
        /// </summary>
        public ICommand ApplyCommand { get; }

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
            AddCommand = new RelayCommand(Add);
            EditCommand = new RelayCommand(Edit);
            RemoveCommand = new RelayCommand(Remove);
            ApplyCommand = new RelayCommand(Apply);
        }

        /// <summary>
        /// Переводит приложение в режим добавления контакта.
        /// </summary>
        private void Add()
        {
            Mode = Modes.Adding;
            CurrentContactVM = new ContactVM();
        }

        /// <summary>
        /// Переводит приложение в режми редактирования контакта.
        /// </summary>
        private void Edit()
        {
            Mode = Modes.Editing;
            MakeClone();
        }

        /// <summary>
        /// Удаляет выбранного контакта.
        /// </summary>
        private void Remove()
        {
            int currentIndex = Contacts.IndexOf(CurrentContactVM);
            Contacts.Remove(CurrentContactVM);
            int contactsCount = Contacts.Count;
            if (contactsCount > currentIndex)
                CurrentContactVM = Contacts[currentIndex];
            else if (contactsCount <= currentIndex && contactsCount > 0)
                CurrentContactVM = Contacts[currentIndex - 1];
            Model.Services.ContactSerializer.SaveContacts(Contacts.Select(contactVM => contactVM.Contact).ToList());
        }

        /// <summary>
        /// Подтверждает добавление или редактирование контакта.
        /// </summary>
        private void Apply()
                    {
            if (Mode == Modes.Adding)
            {
                Contacts.Add(CurrentContactVM);
                CurrentContactVM = CurrentContactVM;
            }
            Mode = Modes.Viewing;
            Model.Services.ContactSerializer.SaveContacts(Contacts.Select(contactVM => contactVM.Contact).ToList());
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

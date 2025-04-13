using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace View.ViewModel
{
    /// <summary>
    ///  Главный класс слоя ViewModel.
    /// </summary>
    public class MainVM : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Список объектов типа <see cref="ContactVM"/>.
        /// </summary>
        public ObservableCollection<ContactVM> Contacts { get; set; }

        /// <summary>
        /// Объект типа <see cref="ContactVM"/>, выбранный из колекции Contacts.
        /// </summary>
        private ContactVM _currentContactVM;

        /// <summary>
        /// Состояние приложения.
        /// </summary>
        private Modes _mode = Modes.Nothing;

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
                OnPropertyChanged();
            }
        }

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
        /// Присваивание переменной Contact объекта типа <see cref="ContactVM"/>.
        /// </summary>
        public MainVM()
        {
            Contacts = new ObservableCollection<ContactVM>();
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace View.ViewModel.Commands
{
    class RemoveCommand : ICommand, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler CanExecuteChanged;

        private MainVM _mainVM;

        public MainVM mainVM
        {
            get
            {
                return _mainVM;
            }
            set
            {
                if(mainVM == null)
                {
                    _mainVM = value;
                    _mainVM.PropertyChanged += Availability_Changed;
                }
            }
        }


        public bool Availability
        {
            get
            {
                if(mainVM.Mode == Modes.Nothing && mainVM.CurrentContactVM != null)
                {
                    return true;
                }
                return false;
            }
        }

        private void Availability_Changed(object sender, PropertyChangedEventArgs e)
        {
            if(PropertyChanged != null && (e.PropertyName == "Mode" || e.PropertyName == "CurrentContactVM"))
            {
                PropertyChanged(this, new PropertyChangedEventArgs("Availability"));
                CanExecuteChanged(this, new EventArgs());
            }
        }

        public void Execute(object parameter)
        {
            int currentIndex = mainVM.Contacts.IndexOf(mainVM.CurrentContactVM);
            mainVM.Contacts.Remove(mainVM.CurrentContactVM);
            int contactsCount = mainVM.Contacts.Count;
            if (contactsCount > currentIndex)
            {
                mainVM.CurrentContactVM = mainVM.Contacts[currentIndex];
            }
            else if(contactsCount <= currentIndex && contactsCount > 0)
            {
                mainVM.CurrentContactVM = mainVM.Contacts[currentIndex - 1];
            }
            mainVM.OnPropertyChanged("Contacts");
        }

        private void Current_Exit(object sender, ExitEventArgs e)
        {
            throw new NotImplementedException();
        }

        public bool CanExecute(object parameter)
        {
            return Availability;
        }

    }
}

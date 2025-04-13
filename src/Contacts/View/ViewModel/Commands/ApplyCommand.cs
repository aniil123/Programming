using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Controls;
using System.ComponentModel;

namespace View.ViewModel.Commands
{
    class ApplyCommand : ICommand, INotifyPropertyChanged
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
                _mainVM = value;
                _mainVM.PropertyChanged += Availability_Changed;
            }
        }

        public bool Availability
        {
            get
            {
                if (mainVM.Mode == Modes.Nothing)
                {
                    return false;
                }
                return true;
            }
        }

        private void Availability_Changed(object sender, PropertyChangedEventArgs e)
        {
            if(e.PropertyName == "Mode")
            {
                PropertyChanged(this, new PropertyChangedEventArgs("Availability"));
                CanExecuteChanged(this, new EventArgs());
            }
        }

        public void Execute(object parameter)
        {
            List<object> parameterList = (List<object>)parameter;
            TextBox name = (TextBox)parameterList[0];
            TextBox phoneNumber = (TextBox)parameterList[1];
            TextBox email = (TextBox)parameterList[2];
            mainVM.Name = name.Text;
            mainVM.PhoneNumber = phoneNumber.Text;
            mainVM.Email = email.Text;
            if (mainVM.Mode == Modes.Add)
            {
                mainVM.Contacts.Add(mainVM.CurrentContactVM);
                mainVM.OnPropertyChanged("Contacts");
            }
            mainVM.Mode = Modes.Nothing;
        }

        public bool CanExecute(object parameter)
        {
            return Availability;
        }

    }
}

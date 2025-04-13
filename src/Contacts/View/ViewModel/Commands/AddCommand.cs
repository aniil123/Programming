using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using System.ComponentModel;

namespace View.ViewModel
{
    public class AddCommand : ICommand, INotifyPropertyChanged
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
                if (mainVM == null)
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
                if (mainVM.Mode == Modes.Nothing)
                {
                    return true;
                }
                return false;
            }
        }

        private void Availability_Changed(object sender, PropertyChangedEventArgs e)
        {
            if(PropertyChanged != null && e.PropertyName == "Mode")
            {
                PropertyChanged(this, new PropertyChangedEventArgs("Availability"));
            }
        }

        public void Execute(object parameter)
        {
            mainVM.CurrentContactVM = new ContactVM();
            mainVM.OnPropertyChanged(new List<string>() { "Contacts", "Name", "PhoneNumber", "Email" });
            mainVM.Mode = Modes.Add;   
        }

        public bool CanExecute(object parameter)
        {
            return Availability;
        }

    }
}

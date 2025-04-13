using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.ComponentModel;

namespace View.ViewModel.Commands
{
    class EditCommand : ICommand, INotifyPropertyChanged
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
            if (PropertyChanged != null && (e.PropertyName == "Mode" || e.PropertyName == "CurrentContactVM"))
            {
                PropertyChanged(this, new PropertyChangedEventArgs("Availability"));
                CanExecuteChanged(this, new EventArgs());
            }
        }

        public void Execute(object parameter)
        {
            mainVM.Mode = Modes.Edit;
        }

        public bool CanExecute(object parameter)
        {
            return Availability;
        }

    }
}

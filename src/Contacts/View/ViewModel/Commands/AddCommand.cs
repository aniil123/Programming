using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

namespace View.ViewModel
{
    public class AddCommand : ICommand
    {

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            MainVM mainVM = (MainVM)parameter;
            mainVM.CurrentContactVM = new ContactVM();
            mainVM.Mode = Modes.Add;   
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

    }
}

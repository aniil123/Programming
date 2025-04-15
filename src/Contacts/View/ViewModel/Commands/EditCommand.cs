using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace View.ViewModel.Commands
{
    public class EditCommand : ICommand
    {
        
        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            MainVM mainVM = (MainVM)parameter;
            mainVM.Mode = Modes.Edit;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

    }
}

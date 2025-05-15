using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace View.ViewModel.Commands
{
    public class EditCommand : ICommand
    {
        /// <summary>
        /// Событие, которое вызывается при изменении возращаемого значения метода CanExecute.
        /// </summary>
        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            MainVM mainVM = (MainVM)parameter;
            mainVM.Mode = Modes.Editing;
            mainVM.InputContactVM.Name = mainVM.CurrentContactVM.Name;
            mainVM.InputContactVM.PhoneNumber = mainVM.CurrentContactVM.PhoneNumber;
            mainVM.InputContactVM.Email = mainVM.CurrentContactVM.Email;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }
    }
}

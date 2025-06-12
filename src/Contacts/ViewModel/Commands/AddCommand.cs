using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Windows;

namespace ViewModel.Commands
{
    public class AddCommand : ICommand
    {
        /// <summary>
        /// Событие, которое вызывается при изменении возращаемого значения метода CanExecute.
        /// </summary>
        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            MainVM mainVM = (MainVM)parameter;
            mainVM.Mode = Modes.Adding;
            mainVM.InputContactVM.Name = "";
            mainVM.InputContactVM.PhoneNumber = "";
            mainVM.InputContactVM.Email = "";
            mainVM.CurrentContactVM = null;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }
    }
}

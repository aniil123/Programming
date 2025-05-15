using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Controls;
using System.Windows;

namespace View.ViewModel.Commands
{
    public class ApplyCommand : DependencyObject, ICommand
    {
        /// <summary>
        /// Событие, которое вызывается при изменении возвращаемого значения метода CanExecute.
        /// </summary>
        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            MainVM mainVM = (MainVM)parameter;
            mainVM.CurrentContactVM.Name = mainVM.InputContactVM.Name;
            mainVM.CurrentContactVM.PhoneNumber = mainVM.InputContactVM.PhoneNumber;
            mainVM.CurrentContactVM.Email = mainVM.InputContactVM.Email;
            if (mainVM.Mode == Modes.Adding)
            {
                mainVM.Contacts.Add(mainVM.CurrentContactVM);
            }
            mainVM.Mode = Modes.Viewing;
            mainVM.CurrentContactVM = mainVM.CurrentContactVM;
            Model.Services.ContactSerializer.SaveContacts(mainVM.Contacts.Select(contactVM => contactVM.Contact).ToList());
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }
    }
}

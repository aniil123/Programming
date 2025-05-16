using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

namespace ViewModel.Commands
{
    public class ApplyCommand : ICommand
    {
        /// <summary>
        /// Событие, которое вызывается при изменении возвращаемого значения метода CanExecute.
        /// </summary>
        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            MainVM mainVM = (MainVM)parameter;
            ContactVM newContactVM = new ContactVM();
            newContactVM.Name = mainVM.InputContactVM.Name;
            newContactVM.PhoneNumber = mainVM.InputContactVM.PhoneNumber;
            newContactVM.Email = mainVM.InputContactVM.Email;
            if (mainVM.Mode == Modes.Adding)
            {
                mainVM.Contacts.Add(newContactVM);
                mainVM.CurrentContactVM = newContactVM;
            }
            mainVM.Mode = Modes.Viewing;
            Model.Services.ContactSerializer.SaveContacts(mainVM.Contacts.Select(contactVM => contactVM.Contact).ToList());
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }
    }
}

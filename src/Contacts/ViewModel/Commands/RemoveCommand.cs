using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViewModel.Commands
{
    public class RemoveCommand : ICommand
    {
        /// <summary>
        /// Событие, которое вызывается при изменении возращаемого значения метода CanExecute.
        /// </summary>
        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            MainVM mainVM = (MainVM)parameter;
            int currentIndex = mainVM.Contacts.IndexOf(mainVM.CurrentContactVM);
            mainVM.Contacts.Remove(mainVM.CurrentContactVM);
            int contactsCount = mainVM.Contacts.Count;
            if (contactsCount > currentIndex)
                mainVM.CurrentContactVM = mainVM.Contacts[currentIndex];
            else if (contactsCount <= currentIndex && contactsCount > 0)
                mainVM.CurrentContactVM = mainVM.Contacts[currentIndex - 1];
            Model.Services.ContactSerializer.SaveContacts(mainVM.Contacts.Select(contactVM => contactVM.Contact).ToList());
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }
    }
}

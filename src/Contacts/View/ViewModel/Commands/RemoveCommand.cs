using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace View.ViewModel.Commands
{
    public class RemoveCommand : ICommand
    {

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            MainVM mainVM = (MainVM)parameter;
            int currentIndex = mainVM.Contacts.IndexOf(mainVM.CurrentContactVM);
            mainVM.Contacts.Remove(mainVM.CurrentContactVM);
            int contactsCount = mainVM.Contacts.Count;
            if (contactsCount > currentIndex)
            {
                mainVM.CurrentContactVM = mainVM.Contacts[currentIndex];
            }
            else if(contactsCount <= currentIndex && contactsCount > 0)
            {
                mainVM.CurrentContactVM = mainVM.Contacts[currentIndex - 1];
            }
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

    }
}

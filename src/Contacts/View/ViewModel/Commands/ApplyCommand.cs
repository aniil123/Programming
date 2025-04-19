using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Controls;

namespace View.ViewModel.Commands
{
    public class ApplyCommand : ICommand
    {
        /// <summary>
        /// Событие, которое вызывается при изменении возвращаемого значения метода CanExecute.
        /// </summary>
        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            List<object> parameterList = (List<object>)parameter;
            MainVM mainVM = (MainVM)parameterList[0];
            string name = (string)parameterList[1];
            string phoneNumber = (string)parameterList[2];
            string email = (string)parameterList[3];
            mainVM.Name = name;
            mainVM.PhoneNumber = phoneNumber;
            mainVM.Email = email;
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

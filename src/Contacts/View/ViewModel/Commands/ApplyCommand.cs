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

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            List<object> parameterList = (List<object>)parameter;
            MainVM mainVM = (MainVM)parameterList[0];
            TextBox name = (TextBox)parameterList[1];
            TextBox phoneNumber = (TextBox)parameterList[2];
            TextBox email = (TextBox)parameterList[3];
            mainVM.Name = name.Text;
            mainVM.PhoneNumber = phoneNumber.Text;
            mainVM.Email = email.Text;
            if (mainVM.Mode == Modes.Add)
            {
                mainVM.Contacts.Add(mainVM.CurrentContactVM);
            }
            mainVM.Mode = Modes.Nothing;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

    }
}

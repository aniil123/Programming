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
        /// Свойство зависимости, хранящее значение, определяющее, может ли быть использована эта команда.
        /// </summary>
        public static readonly DependencyProperty EnabledProperty;

        /// <summary>
        /// Событие, которое вызывается при изменении возвращаемого значения метода CanExecute.
        /// </summary>
        public event EventHandler CanExecuteChanged;

        /// <summary>
        /// Возвращает и задает значение свойства зависимости EnabledProperty.
        /// </summary>
        public bool Enabled
        {
            get { return (bool)GetValue(EnabledProperty); }
            set { SetValue(EnabledProperty, value); }
        }

        private static void Enabled_Changed(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
        {
            ApplyCommand applyCommand = (ApplyCommand)dependencyObject;
            if(applyCommand.CanExecuteChanged != null)
            {
                applyCommand.CanExecuteChanged(applyCommand, new EventArgs());
            }
        }

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
            return Enabled;
        }

        /// <summary>
        /// Регистрирует свойство зависимости EnabledProperty.
        /// </summary>
        static ApplyCommand()
        {
            EnabledProperty = DependencyProperty.Register("Enabled", typeof(bool), typeof(ApplyCommand), new PropertyMetadata(Enabled_Changed));
        }
    }
}

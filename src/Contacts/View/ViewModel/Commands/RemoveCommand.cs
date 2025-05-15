using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace View.ViewModel.Commands
{
    public class RemoveCommand : DependencyObject, ICommand
    {
        /// <summary>
        /// Свойство зависимости, хранящее значение, определяющее, может ли быть использована эта команда.
        /// </summary>
        public static readonly DependencyProperty EnabledProperty;

        /// <summary>
        /// Событие, которое вызывается при изменении возращаемого значения метода CanExecute.
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

        /// <summary>
        /// Обработчик события, которое вызывается при изменении значений объектов <see cref="DependencyProperty"/> этого класса.
        /// </summary>
        /// <param name="dependencyObject">Экземпляр этого класса, свойство которого изменилось.</param>
        /// <param name="e"></param>
        private static void Enabled_Changed(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
        {
            RemoveCommand removeCommand = (RemoveCommand)dependencyObject;
            if(removeCommand.CanExecuteChanged != null)
            {
                removeCommand.CanExecuteChanged(removeCommand, new EventArgs());
            }
        }

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
            Model.Services.ContactSerializer.SaveContacts(mainVM.Contacts.Select(contactVM => contactVM.Contact).ToList());
        }

        public bool CanExecute(object parameter)
        {
            return Enabled;
        }

        /// <summary>
        /// Регистрирует свойство зависимости EnabledProperty.
        /// </summary>
        static RemoveCommand()
        {
            EnabledProperty = DependencyProperty.Register("Enabled", typeof(bool), typeof(RemoveCommand), new PropertyMetadata(Enabled_Changed));
        }
    }
}

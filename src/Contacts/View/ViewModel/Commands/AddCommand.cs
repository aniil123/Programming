using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Windows;
using View.ViewModel.Commands;

namespace View.ViewModel
{
    public class AddCommand : DependencyObject, ICommand
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
            AddCommand addCommand = (AddCommand)dependencyObject;
            if(addCommand.CanExecuteChanged != null)
            {
                addCommand.CanExecuteChanged(addCommand, new EventArgs());
            }
        }

        public void Execute(object parameter)
        {
            MainVM mainVM = (MainVM)parameter;
            mainVM.Mode = Modes.Adding;
            mainVM.InputContactVM.Name = "";
            mainVM.InputContactVM.PhoneNumber = "";
            mainVM.InputContactVM.Email = "";
            mainVM.CurrentContactVM = new ContactVM();
        }

        public bool CanExecute(object parameter)
        {
            return Enabled;
        }

        /// <summary>
        /// Регистрирует свойство зависимости EnabledProperty.
        /// </summary>
        static AddCommand()
        {
            EnabledProperty = DependencyProperty.Register("Enabled", typeof(bool), typeof(AddCommand), new PropertyMetadata(Enabled_Changed));
        }
    }
}

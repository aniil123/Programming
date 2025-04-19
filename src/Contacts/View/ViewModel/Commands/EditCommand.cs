using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace View.ViewModel.Commands
{
    public class EditCommand : DependencyObject, ICommand
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
        /// Возвращает и задает значение объекта EnabledProperty типа <see cref="DependencyProperty"/>.
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
            EditCommand editCommand = (EditCommand)dependencyObject;
            if(editCommand.CanExecuteChanged != null)
            {
                editCommand.CanExecuteChanged(editCommand, new EventArgs());
            }
        }

        public void Execute(object parameter)
        {
            MainVM mainVM = (MainVM)parameter;
            mainVM.Mode = Modes.Editing;
        }

        public bool CanExecute(object parameter)
        {
            return Enabled;
        }

        /// <summary>
        /// Регистрирует объект EnabledProperty типа <see cref="DependencyProperty"/>.
        /// </summary>
        static EditCommand()
        {
            EnabledProperty = DependencyProperty.Register("Enabled", typeof(bool), typeof(EditCommand), new PropertyMetadata(Enabled_Changed));
        }
    }
}

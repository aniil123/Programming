using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Input;

namespace View.ViewModel
{
    class SaveCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        /// <summary>
        /// Сериализует объект parameter и сохраняет его в файл формата json.
        /// </summary>
        /// <param name="parameter">Объект, над которым проводится сериализация.</param>
        public void Execute(object parameter)
        {
            string serializedContact = JsonConvert.SerializeObject((Model.Contact)parameter);
            File.WriteAllText("MyDocuments\\Contact\\contact.json", serializedContact);
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Input;
using Newtonsoft.Json;

namespace View.ViewModel
{
    public class LoadCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        /// <summary>
        /// Десериализует объект, находящийся в файле формата json и присваивает ссылку на него переменной parameter.
        /// </summary>
        /// <param name="parameter">Десериализуемый объект.</param>
        public void Execute(object parameter)
        {
            string serializedContact = File.ReadAllText("MyDocuments\\Contacts\\contacts.json");
            parameter = JsonConvert.DeserializeObject<Model.Contact>(serializedContact);
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }
    }
}

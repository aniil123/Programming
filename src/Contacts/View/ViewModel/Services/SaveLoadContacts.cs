using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace View.ViewModel.Services
{
    class SaveLoadContacts
    {

        private ObservableCollection<ContactVM> Contacts { get; set; }

        /// <summary>
        /// Сохраняет объекты <see cref="ContactVM"/>, содержащиеся в коллекции Contacts, при закритии приложения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveContacts(object sender, ExitEventArgs e)
        {
            List<Model.Contact> contacts = new List<Model.Contact>();
            foreach(ContactVM contact in Contacts)
            {
                contacts.Add(contact.Contact);
            }
            Model.Services.ContactSerializer.SaveContacts(contacts);
        }

        /// <summary>
        /// Загружает объекты <see cref="ContactVM"/> в коллекцию Contacts.
        /// </summary>
        private void LoadContacts()
        {
            List<Model.Contact> contacts = Model.Services.ContactSerializer.LoadContacts();
            foreach(Model.Contact contact in contacts)
            {
                Contacts.Add(new ContactVM(contact));
            }
        }

        public SaveLoadContacts(ObservableCollection<ContactVM> contacts)
        {
            Contacts = contacts;
            Application.Current.Exit += SaveContacts;
            LoadContacts();
        }

    }
}

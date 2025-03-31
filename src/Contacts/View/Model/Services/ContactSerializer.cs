using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace View.Model.Services
{
    /// <summary>
    /// Сериализует и десереализует экземпляр класса <see cref="Model.Contact"/>.
    /// </summary>
    public static class ContactSerializer
    {
        /// <summary>
        /// Сериализует экземпляр класса <see cref="Model.Contact"/>.
        /// </summary>
        /// <param name="Contact">Экземпляр класса <see cref="Model.Contact"/>.</param>
        public static void SaveContact(Model.Contact Contact)
        {
            string serializedContact = JsonConvert.SerializeObject(Contact);
            File.WriteAllText("MyDocuments\\Contacts\\contacts.json", serializedContact);
        }
        /// <summary>
        /// Десериализует экземпляр класса <see cref="Model.Contact"/>.
        /// </summary>
        /// <returns>Экземпляр класса <see cref="Model.Contact"/>.</returns>
        public static Model.Contact LoadContact()
        {
            string serializedContact = File.ReadAllText("MyDocuments\\Contacts\\contacts.json");
            return JsonConvert.DeserializeObject<Model.Contact>(serializedContact);
        }
    }
}

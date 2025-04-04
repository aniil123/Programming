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
        /// Возвращает путь до файла с сериализованным объектом класса Contact.
        /// </summary>
        private static string Path { get; } = @"MyDocuments\Contacts\contacts.json";

        /// <summary>
        /// Сериализует экземпляр класса <see cref="Model.Contact"/>.
        /// </summary>
        /// <param name="Contact">Экземпляр класса <see cref="Model.Contact"/>.</param>
        public static void SaveContact(Model.Contact Contact)
        {
            string serializedContact = JsonConvert.SerializeObject(Contact);
            using(StreamWriter streamWriter = new StreamWriter(Path, false))
            {
                streamWriter.Write(serializedContact);
            }
        }

        /// <summary>
        /// Десериализует экземпляр класса <see cref="Model.Contact"/>.
        /// </summary>
        /// <returns>Экземпляр класса <see cref="Model.Contact"/>.</returns>
        public static Model.Contact LoadContact()
        {
            string serializedContact;
            using (StreamReader streamReader = new StreamReader(Path))
            {
                serializedContact = streamReader.ReadToEnd();
            }
            return JsonConvert.DeserializeObject<Model.Contact>(serializedContact);
        }
    }
}

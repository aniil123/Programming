using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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
        /// Сериализует и сохраняет список экземпляров класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="Contact">Экземпляр класса <see cref="Contact"/>.</param>
        public static void SaveContacts(List<Contact> contacts)
        {
            string serializedContacts = JsonConvert.SerializeObject(contacts);
            using(StreamWriter streamWriter = new StreamWriter(Path, false))
            {
                streamWriter.Write(serializedContacts);
            }
        }

        /// <summary>
        /// Загружает и десериализует список экземпляров класса <see cref="Contact"/>.
        /// </summary>
        /// <returns>Экземпляр класса <see cref="Contact"/>.</returns>
        public static List<Contact> LoadContacts()
        {
            string serializedContacts;
            using (StreamReader streamReader = new StreamReader(Path))
            {
                serializedContacts = streamReader.ReadToEnd();
            }
            return JsonConvert.DeserializeObject<List<Contact>>(serializedContacts);
        }

    }
}

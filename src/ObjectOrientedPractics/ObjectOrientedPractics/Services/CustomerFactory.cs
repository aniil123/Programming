using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Генерирует случайное количество экземпляров класса <see cref="Model.Customer"/>.
    /// </summary>
    static class CustomerFactory
    {
        private static Random rand = new Random();
        /// <summary>
        /// Создает список, содержащий экземпляры класса <see cref="Model.Customer"/>.
        /// </summary>
        /// <returns>Список экземпляров класса <see cref="Model.Customer"/>.</returns>
        public static List<Model.Customer> CreateCustomers()
        {
            List<Model.Customer> customersList = new List<Model.Customer>();
            for(int i = 0;i< rand.Next(3, 6);i++)
            {
                string nameOfCustomer = Convert.ToString((NamesOfCustomers)System.Enum.GetValues(typeof(NamesOfCustomers)).GetValue(rand.Next(0, 10)));
                string secondNameOfCustomer = Convert.ToString((SecondNamesOfCustomers)System.Enum.GetValues(typeof(SecondNamesOfCustomers)).GetValue(rand.Next(0, 10)));
                string patronymicOfCustomer = Convert.ToString((PatronymicsOfCustomers)System.Enum.GetValues(typeof(PatronymicsOfCustomers)).GetValue(rand.Next(0, 10)));
                string fullName = nameOfCustomer + " " + secondNameOfCustomer + " " + patronymicOfCustomer;
                customersList.Add(new Model.Customer(fullName, new Random().Next(100000, 999999), "Россия", "Томск", "Ленина", "40", "1000"));
            }
            return customersList;
        }
    }
}

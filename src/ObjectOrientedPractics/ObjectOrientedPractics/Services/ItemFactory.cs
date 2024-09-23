using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Генерирует случайное количество экземпляров класса <see cref="Model.Item"/>.
    /// </summary>
    static class ItemFactory
    {
        private static Random rand = new Random();
        /// <summary>
        /// Создает список, содержащий экземпляры класса <see cref="Model.Item"/>.
        /// </summary>
        /// <returns>Список экземпляров класса <see cref="Model.Item"/>.</returns>
        public static List<Model.Item> CreateItems()
        {
            List<Model.Item> itemsList = new List<Model.Item>();
            for(int i = 0;i < rand.Next(3,6);i++)
            {
                string nameOfItem = Convert.ToString((NamesOfItems)System.Enum.GetValues(typeof(NamesOfItems)).GetValue(rand.Next(0, 10)));
                string infoOfItem = Convert.ToString((InfoOfItems)System.Enum.GetValues(typeof(InfoOfItems)).GetValue(rand.Next(0, 10)));
                itemsList.Add(new Model.Item(nameOfItem, infoOfItem, rand.Next(0, 100000)));
            }
            return itemsList;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Различные методы для обработки данных.
    /// </summary>
    public static class DataTools
    {
        public delegate bool SortingCriteria(Item item1, Item item2);
        public static bool NumberIsGreater(Item item1)
        {
            return item1.Cost > 5000;
        }
        public static bool OneCategoryItems(Item item1)
        {
            return item1.Category == (Category)0;
        }
        public static bool PresenceOfSubstring(Item item, string subString)
        {
            char[] name = item.Name.ToCharArray();
            for(int i = 0;i < name.Length - subString.Length + 1;i++)
            {
                string str = "";
                for(int j = 0;j < subString.Length;j++)
                {
                    str += name[i + j];
                }
                if(subString == str)
                {
                    return true;
                }
            }
            return false;
        }
        public static List<Item> FilteringData(List<Item> items, Func<Item, bool> filteringCriteria)
        {
            List<Item> newItems = new List<Item>();
            foreach(var i in items)
            {
                if(filteringCriteria(i))
                {
                    newItems.Add((Item)i.Clone());
                }
            }
            return newItems;
        }
        public static bool SortingName(Item item1, Item item2)
        {
            return ValueValidator.Alphobet.IndexOf(item1.Name[0]) > ValueValidator.Alphobet.IndexOf(item2.Name[0]);
        }
        public static bool CostAscending(Item item1, Item item2)
        {
            return item1.Cost > item2.Cost;
        }
        public static bool CostDescending(Item item1, Item item2)
        {
            return item1.Cost < item2.Cost;
        }
        public static void SortingData(List<Item> items, SortingCriteria sortingCriteria)
        {
            for(int i = 0;i < items.Count - 1;i++)
            {
                int index = i;
                Item minCrit = items[i];
                for(int j = i + 1;j < items.Count;j++)
                {
                    if(sortingCriteria(minCrit, items[j]))
                    {
                        minCrit = items[j];
                        index = j;
                    }
                }
                Item obmen = items[i];
                items[i] = items[index];
                items[index] = obmen;
            }
        }
    }
}

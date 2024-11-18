using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Товар.
    /// </summary>
    public class Item : ICloneable, IEquatable<Item>, IComparable<Item>
    {
        /// <summary>
        /// Категория товара.
        /// </summary>
        public Category Category { get; set; }
        private static int _counter = 0;
        //Уникальный номер товара.
        private int _id;
        //Название товара.
        private string _name;
        //Информация о товаре.
        private string _info;
        //Цена товара.
        private double _cost;
        private bool _active = true;
        /// <summary>
        /// Возвращает уникальный номер товара.
        /// </summary>
        public int ID
        {
            get
            {
                return _id;
            }
            private set
            {
                _id = value;
            }
        }
        /// <summary>
        /// Возвращяет и присваивает имя товара. Значение должно быть строковым с количеством символов меньше 200.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                Services.ValueValidator.AssertStringOnLength(value, 200);
                Services.ValueValidator.CheckingString(value, Services.ValueValidator.Alphobet + " ");
                _name = value;
            }
        }
        /// <summary>
        /// Возвращает и присваивает информацию о товаре. Значение должно быть строковым с количеством символов меньше 1000.
        /// </summary>
        public string Info
        {
            get
            {
                return _info;
            }
            set
            {
                Services.ValueValidator.AssertStringOnLength(value, 1000);
                Services.ValueValidator.CheckingString(value, Services.ValueValidator.Alphobet + " .,()-");
                _info = value;
            }
        }
        /// <summary>
        /// Возвращает и присваивает цену товара. Значение должно быть вещественным не меньше 0 и не больше 100000.
        /// </summary>
        public double Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                if(value >= 0 && value <= 100000)
                {
                    _cost = value;
                }
            }
        }
        public bool Active
        {
            get
            {
                return _active;
            }
            set
            {
                _active = value;
            }
        }
        public object Clone()
        {
            return new Item(Name, Info, Cost, Category);
        }
        public bool Equals(Item other)
        {
            return (Name == other.Name && Info == other.Info && Cost == other.Cost && Category == other.Category);
        }
        public int CompareTo(Item other)
        {
            if(Cost > other.Cost)
            {
                return 1;
            }
            else if(Cost == other.Cost)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
        /// <summary>
        /// Присваивает случайные значения полням с названием, информацией, и ценой товара.
        /// </summary>
        public Item()
        {
            _counter++;
            ID = _counter;
            Type[] TypesOfEnums = { typeof(NamesForAutoParts), typeof(NamesForChemistry), typeof(NamesForClothes), typeof(NamesForElectronics), typeof(NamesForFood), typeof(NamesForFurniture), typeof(NamesForPetSupplies) };
            int numCategory = new Random().Next(0, Enum.GetValues(typeof(Category)).Length);
            string[] infoOfItems = Enum.GetNames(typeof(InfoOfItems));
            string[] namesForItems = Enum.GetNames(TypesOfEnums[numCategory]);
            Name = namesForItems[new Random().Next(0, namesForItems.Length)];
            Info = infoOfItems[new Random().Next(0, infoOfItems.Length)];
            Cost = new Random().Next(234, 21355);
            Category = (Category)numCategory;
        }
        /// <summary>
        /// Присваивает значения полям с названием, информацией и ценой товара.
        /// </summary>
        /// <param name="name">Значение должно быть строковым с количеством символов меньше 200.</param>
        /// <param name="info">Значение должно быть строковым с количеством символов меньше 1000.</param>
        /// <param name="cost">Значение должно быть вещественным не меньше 0 и не больше 100000.</param>
        /// <param name="category">Категория товара.</param>
        public Item(string name, string info, double cost, Category category)
        {
            _counter++;
            ID = _counter;
            Name = name;
            Info = info;
            Cost = cost;
            Category = category;
        }
    }
}

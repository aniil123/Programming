using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Address : ICloneable, IEquatable<Address>
    {
        //Почтовый индекс.
        private int _index;
        //Страна/регион.
        private string _country;
        //Город.
        private string _city;
        //Улица
        private string _street;
        //Номер дома.
        private string _building;
        //Номер квартиры/помещение.
        private string _apartment;
        /// <summary>
        /// Возвращает и присваивает почтовый индекс. Значение должно быть целым неотрицательным числом, состоящим из 6-и цифр.
        /// </summary>
        public int Index
        {
            get
            {
                return _index;
            }
            set
            {
                if((value.ToString().ToCharArray().Length == 6 && value > 0) || value == 0)
                {
                    _index = value;
                }
                else
                {
                    throw new Exception("Индекс должен состоять из 6-и цифр");
                }
            }
        }
        /// <summary>
        /// Возвращает и присваивает страну/регион. Значение должно быть строковым с количеством символо не больше 50-и.
        /// </summary>
        public string Country
        {
            get
            {
                return _country;
            }
            set
            {
                if(value.Length <= 50)
                {
                    Services.ValueValidator.CheckingString(value, Services.ValueValidator.Alphobet + " ");
                    _country = value;
                }
                else
                {
                    throw new Exception("В названии страны должно быть не больше 50-и символов");
                }
            }
        }
        /// <summary>
        /// Возвращает и присваивает город. Значение должно быть строковым с количеством символов не больше 50-и.
        /// </summary>
        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                if(value.Length <= 50)
                {
                    Services.ValueValidator.CheckingString(value, Services.ValueValidator.Alphobet + " ");
                    _city = value;
                }
                else
                {
                    throw new Exception("В названии города должно быть не больше 50-и символов");
                }
            }
        }
        /// <summary>
        /// Возвращает и задает улицу. Значение должно быть строковым с количеством символом не больше 100-а.
        /// </summary>
        public string Street
        {
            get
            {
                return _street;
            }
            set
            {
                if(value.Length <= 100)
                {
                    Services.ValueValidator.CheckingString(value, Services.ValueValidator.Alphobet + " ");
                    _street = value;
                }
                else
                {
                    throw new Exception("В названии улицы должно быть не больше 100-а символов");
                }
            }
        }
        /// <summary>
        /// Возвращает и присваивает номер дома. Значение должно быть строковым с количеством символом не больше 10-и.
        /// </summary>
        public string Building
        {
            get
            {
                return _building;
            }
            set
            {
                if(value.Length <= 10)
                {
                    Services.ValueValidator.CheckingString(value, Services.ValueValidator.Alphobet + " 1234567890.,/");
                    _building = value;
                }
                else
                {
                    throw new Exception("");
                }
            }
        }
        /// <summary>
        /// Возвращает и задает номер квартиры/помещения. Значение должно быть строковым с количесвом символов не больше 10-и.
        /// </summary>
        public string Apartment
        {
            get
            {
                return _apartment;
            }
            set
            {
                if(value.Length <= 10)
                {
                    Services.ValueValidator.CheckingString(value, Services.ValueValidator.Alphobet + " 1234567890,./");
                    _apartment = value;
                }
                else
                {
                    throw new Exception("Длина номера квартиры должна быть не больше 10-и.");
                }
            }
        }
        public object Clone()
        {
            return new Address(Index, Country, City, Street, Building, Apartment);
        }
        public bool Equals(Address other)
        {
            return (Index == other.Index && Country == other.Country && City == other.City && Street == other.Street && Building == other.Building && Apartment == other.Apartment);
        }
        /// <summary>
        /// Заполняет поля с почтовым индексом, страной, городом, улицей, номером улицы, номером квартиры константами.
        /// </summary>
        public Address()
        {
            Index = 0;
            Country = "";
            City = "";
            Street = "";
            Building = "";
            Apartment = "";
        }
        /// <summary>
        /// Заполняет поля класса полученными значениями.
        /// </summary>
        /// <param name="index">Почтовый индекс. Значение должно быть целым неотрицательным числом с количеством символов равным 6-и.</param>
        /// <param name="country">Страна/регион. Значение должно быть строковым с количеством символов не больше 50-и.</param>
        /// <param name="city">Город. Значение должно быть строковым с количеством символов не больше 50-и.</param>
        /// <param name="street">Улица. Значение должно быть строковым с количеством символов не больше 100-и.</param>
        /// <param name="building">Номер дома. Значение должно быть строковым с количеством символом не больше 10-и.</param>
        /// <param name="apartment">Номер квартиры/помещение. Значение должно быть строковым с количеством символом не больше 10-и.</param>
        public Address(int index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }
    }
}

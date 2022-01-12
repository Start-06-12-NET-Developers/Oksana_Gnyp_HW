using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address
{
    class Address
    {
        private int index, house, apt;
        private string country, city, street;

        //public int Index { get { return index; } set { index = value; } }
        //public int House { get { return house; } set { house = value; } }
        //public int Apt { get { return apt; } set { apt = value; } }
        //public string Country { get { return country; } set { country = value; } }
        //public string City { get { return city; } set { city = value; } }
        //public string Street { get { return street; } set { street = value; } }

        public int Index { get; set; }
        public int House { get; set; }
        public int Apt { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Address adr = new Address();

            Console.Write("Введите индекс: ");
            adr.Index = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите страну: ");
            adr.Country = Console.ReadLine();
            Console.Write("Введите город: ");
            adr.City = Console.ReadLine();
            Console.Write("Введите улицу: ");
            adr.Street = Console.ReadLine();
            Console.Write("Введите дом: ");
            adr.House = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите квартиру: ");
            adr.Apt = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Индекс: " + adr.Index);
            Console.WriteLine("Страна: " + adr.Country);
            Console.WriteLine("Город: " + adr.City);
            Console.WriteLine("Улица: " + adr.Street);
            Console.WriteLine("Дом: " + adr.House);
            Console.WriteLine("Квартира: " + adr.Apt);

            Console.ReadKey();
        }
    }
}

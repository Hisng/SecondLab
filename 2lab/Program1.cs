using System;

namespace _1
{
    class Program1
    {
        
        static void Main(string[] args)
        {
            Address MyAddress = new Address();
            MyAddress.Index = 3222323;
            MyAddress.Country = "Ukraine";
            MyAddress.City = "Kyiv";
            MyAddress.Street = "Khreshtyk";
            MyAddress.House = 15;
            MyAddress.Apartment = 64;
            Console.WriteLine("Index: " + MyAddress.Index);
            Console.WriteLine("Country: " + MyAddress.Country);
            Console.WriteLine("City: " + MyAddress.City);
            Console.WriteLine("Street: " + MyAddress.Street);
            Console.WriteLine("House: " + MyAddress.House);
            Console.WriteLine("Apartment: " + MyAddress.Apartment);
            Console.ReadKey();
        }
    }
}

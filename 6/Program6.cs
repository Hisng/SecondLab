using System;

namespace _6
{
    class Program6
    {
        static void Main(string[] args)
        {
            Converter rate = new Converter(28.24, 33.51, 0.38);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("100 Uah To Usd = " + rate.FromUahToUsd(100));
            Console.WriteLine();
            Console.WriteLine("2000 Uah To Eur = " + rate.FromUahToEur(2000));
            Console.WriteLine();
            Console.WriteLine("500 Uah To Rub = " + rate.FromUahToRub(500));
            Console.WriteLine();
            Console.WriteLine("200 Usd To Uah = " + rate.FromUsdToUah(200));
            Console.WriteLine();
            Console.WriteLine("300 Eur To Uah = " + rate.FromEurToUah(300));
            Console.WriteLine();
            Console.WriteLine("5000 Rub To Uah = " + rate.FromRubToUah(5000));
        }
    }
}

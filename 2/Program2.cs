using System;

namespace _2
{
    class Program2
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторону A:");
            double SideA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите сторону B:");
            double SideB = Convert.ToDouble(Console.ReadLine());


            Rectangle solution = new Rectangle(SideA, SideB);


            Console.WriteLine("Площадь прямоугольника:" + solution.AreaCalculator());
            Console.WriteLine("Периметр прямоугольника:" + solution.PerimeterCalculator());
            Console.ReadKey();


        }
    }
}

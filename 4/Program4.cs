using System;

namespace _4
{
    class Program4
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Enter the name of the figure:");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the length of first side:");
            int sideA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the length of second side:");
            int sideB = Convert.ToInt32(Console.ReadLine());

            Point figure1 = new Point(sideA, sideB, name);
            Figure figure = new Figure(figure1);
            double area = figure.AreaCalculator(figure1);
            double perimeter = figure.PerimeterCalculator(figure1);

            Console.Clear();
            Console.WriteLine("The area of " + figure1.Name + " is: " + area);
            Console.WriteLine("The perimeter of " + figure1.Name + " is: " + perimeter);
        }
    }
}

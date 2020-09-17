using System;

namespace _7
{
    class Program7
    {
        static void Main(string[] args)
        {
            Employee worker = new Employee("Nikita", "Strogalev");
            worker.Rang = 3;
            worker.Experience = 8;
            worker.ShowSalary();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace _7
{
    class Employee
    {
        private string name;
        private string surname;
        private int rang;
        private int experience;

        public Employee(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public int Rang
        {          
            set
            {
                if (value > 0 && value < 6)
                {
                    rang = value;
                }
            }
        }

        public int Experience
        {
            set
            {
                if (value >= 0 && value < 50)
                {
                    experience = value;
                }
            }
        }

        public void ShowSalary()
        {
            double temp1 = rang * 0.5;
            double temp2 = experience * 0.03;
            double salary = (temp1 + 1) * (temp2 + 1) * 5000 * 0.82; // 18% налог = *0.82
            Console.WriteLine(name + " " + surname + "'s salary = " + salary);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace _5
{
    class User
    {
        // логин, имя, фамилия, возраст, дата заполнения анкеты
        private string login;
        private string name;
        private string surname;
        private int age;
        private string date;

        public User(string login, string name, string surname, int age, string date)
        {
            this.login = login;
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.date = date;
        }

        public string Login
        {
            get
            {
                return login;
            }
            set
            {
                login = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public string Date
        {
            get
            {
                return date;
            }
          
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("User's login: " + login);
            Console.WriteLine("User's name: " + name);
            Console.WriteLine("User's surname: " + surname);
            Console.WriteLine("User's age: " + age);
            Console.WriteLine("User's date of registration: " + date);
        }
    }
}

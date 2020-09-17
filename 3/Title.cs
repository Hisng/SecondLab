using System;
using System.Collections.Generic;
using System.Text;

namespace _3
{
    class Title
    {
        public string title { get; set; }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Название книги:");
            Console.WriteLine(title);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace _3
{
    class Content
    {
        public string content { get; set; }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Содержание книги:");
            Console.WriteLine(content);
        }
    }
}

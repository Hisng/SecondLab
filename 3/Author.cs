using System;
using System.Collections.Generic;
using System.Text;

namespace _3
{
    class Author
    {
        public string author { get; set; }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Автор книги:");
            Console.WriteLine(author);
        }
    }
}

using System;
using System.Text;

namespace _3
{
    class Program3
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введите название книги:");
            Title title = new Title();
            title.title = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Введите автора книги:");
            Author author = new Author();
            author.author = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Введите описание книги:");
            Content content = new Content();
            content.content = Convert.ToString(Console.ReadLine());

            Book book = new Book(title, author, content);

            Console.Clear();

            book.Show();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Text;

namespace _3
{
    class Book
    {
        Title _title;
        Author _author;
        Content _content;

        public  Book (Title title, Author author, Content content)
        {
            _title = title;
            _content = content;
            _author = author;
        }
        public void Show()
        {
            _title.Show();
            _author.Show();
            _content.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask
{
    public class Library
    {
        public string Name;
        public Book[] Books = Array.Empty<Book>(); // 0 -> 1;  


        public void AddBook(Book book)
        {
            Array.Resize(ref Books, Books.Length + 1);
            Books[^1] = book;
        }

        public void ShowAllBooks()
        {
            foreach (Book book in Books)
            {
                Console.WriteLine($"Book name: {book.Name} Price: {book.Price} Code: {book.Code}");
            }
        }
    }
}

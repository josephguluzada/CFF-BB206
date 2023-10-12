using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Models
{
    public class Library
    {
        public Book[] Books;

        public Library()
        {
            Books = Array.Empty<Book>();
            //Books = new Book[0];
        }

        public void AddBook(Book book)
        {
            Array.Resize(ref Books, Books.Length + 1);
            Books[^1] = book;
        }

        public void AddBook(ref Book[] array,Book book)
        {
            Array.Resize(ref array, array.Length + 1);
            array[^1] = book;
        }

        public Book[] GetFilteredBooks(string genre)
        {
            Book[] filteredBooks = Array.Empty<Book>();

            foreach (Book book in Books)
            {
                if(book.Genre.ToLower() == genre.ToLower())
                {
                    AddBook(ref filteredBooks, book);
                }
            }

            return filteredBooks;
        }

        public Book[] GetFilteredBooks(double minPrice, double maxPrice)
        {
            Book[] filteredBooks = Array.Empty<Book>();
            foreach (Book book in Books)
            {
                if(book.Price >= minPrice && book.Price <= maxPrice)
                {
                    AddBook(ref filteredBooks, book);
                }
            }

            return filteredBooks;
        }

        public void ShowAllBook()
        {
            foreach (Book book in Books)
            {
                Console.WriteLine($"Genre: {book.Genre} Price: {book.Price} Name: {book.Name}");
            }
        }
    }
}

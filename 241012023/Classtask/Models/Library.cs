using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classtask.Models
{
    internal class Library
    {
        public List<Book> books = new List<Book>();

        public List<Book> FindAllBooksByName(string name)
        {
            return books.FindAll(book => book.Name.ToLower().Contains(name.ToLower()));
        }

        public void RemoveAllBooksByName(string name)
        {
            books.RemoveAll(book => book.Name.ToLower() == name.ToLower());
        }

        public List<Book> SearchBooks(string value)
        {
            return books.FindAll(book =>
                                   book.Name.ToLower().Contains(value.ToLower()) ||
                                   book.AuthorName.ToLower().Contains(value.ToLower()) ||
                                   book.PageCount.ToString() == value);
        }

        public List<Book> FindAllBooksByPageCountRange(int min, int max)
        {
            return books.FindAll(book => book.PageCount >= min && book.PageCount <= max);
        }

        public void RemoveBookByCode(string bookCode)
        {
            Book wantedBook = books.Find(book => book.Code.ToLower() == bookCode.ToLower());

            if (wantedBook != null) books.Remove(wantedBook);
        }
    }
}

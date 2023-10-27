using Classtask.Models;

namespace Classtask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Elmarin Maceralari");
            book1.PageCount = 99;
            book1.AuthorName = "Elmar Efendiyev";
            Book book2 = new Book("Elvinin Maceralari");
            book2.PageCount = 199;
            book2.AuthorName = "Elvin Eliyev";
            Book book3 = new Book("Shahinin Maceralari");
            book3.PageCount = 299;
            book3.AuthorName = "Shahin Mirzaliyev";
           
            Library library = new Library();

            library.books.Add(book1);
            library.books.Add(book2);
            library.books.Add(book3);

            

            
            //foreach (var item in library.FindAllBooksByName("Elma"))
            //{
            //    Console.WriteLine(item);
            //}

            //library.RemoveAllBooksByName("Elmarin Maceralar");

            library.RemoveBookByCode(book1.Code);
            foreach (var item in library.books)
            {
                Console.WriteLine(item);
            }

        }
    }
}
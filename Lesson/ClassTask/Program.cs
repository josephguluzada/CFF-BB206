
using AccessModifiers;

namespace ClassTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Harry Potter")
            {
                Price = 24
            };

            Book book2 = new Book("Larry Kotter")
            {
                Price = 29
            };

            Book book3 = new Book("Jarry Hotter")
            {
                Price = 99
            };

            string name = "   Yusif    Guluzada  ";

            //string nameStr = name.Trim();
            int index = name.Trim().LastIndexOf(" ");

            Console.WriteLine(name.Substring(index+1));

            Library library = new Library();
            library.Name = "Resedxana";

            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);

            library.ShowAllBooks();

            Library library2 = new Library();
            library2.AddBook(book1);
            Console.WriteLine("Library 2 ==================================================");
            library2.ShowAllBooks();

            Human human = new Human();
        }
    }
}
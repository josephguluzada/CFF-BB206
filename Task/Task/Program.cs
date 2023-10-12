using Task.Models;

namespace Task
{
    internal class Program
    {
        static Book[] books = new Book[0];
        static void Main(string[] args)
        {
            //Book book1 = new Book("Qorxu");
            //book1.Name = "Dracula";
            //book1.Price = 5;

            //Book book2 = new Book("Action");
            //book2.Name = "Cont";
            //book2.Price = 9;

            //Book book3 = new Book("Qorxu");
            //book3.Name = "Navi";
            //book3.Price = 15;

            //Library library = new Library();

            //library.AddBook(book1);
            //library.AddBook(book2);
            //library.AddBook(book3);

            //library.ShowAllBook();


            //foreach (Book book in library.GetFilteredBooks("acTIon"))
            //{
            //    book.ShowInfo();
            //}

            //foreach (Book book in library.GetFilteredBooks(5,15))
            //{
            //    book.ShowInfo();
            //}



            //Console.Write("Enter book name: ");
            //string name = Console.ReadLine();

            //Console.Write("\nEnter book genre: ");
            //string genre = Console.ReadLine();


            //double bookPrice;
            //string priceStr;

            //do
            //{
            //    Console.Write("\nEnter book price:");
            //    priceStr = Console.ReadLine();

            //} while (!double.TryParse(priceStr, out bookPrice));


            //Book book = new Book(name, genre, bookPrice);

            //book.ShowInfo();

            

            
            int choice;
            do
            {
                Console.WriteLine("\nChoose operation");
                Console.WriteLine("1. Kitab Yarat" +
                    "\n2. Kitab add ele" +
                    "\n3. Kitab infosu" +
                    "\n0. Proqrami bitir");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CreateBook();
                        break;
                    case 2:
                        ShowAllBooks();
                        break;
                    case 3:
                        Console.Write("Bir nomre daxil edin");
                        int nomre = int.Parse(Console.ReadLine());
                        Console.WriteLine("Book infosu");
                        ShowBookInfo(nomre);
                        break;
                    default:
                        break;
                }
            } while (choice != 0);
        }

        public static void ShowBookInfo(int no)
        {
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i].No == no)
                {
                    books[i].ShowInfo();
                }
            }
        }

        public static void CreateBook()
        {
            Book book = null;
            Console.Write("Enter book No: ");
            int no = int.Parse(Console.ReadLine());

            Console.Write("Enter book name: ");
            string name = Console.ReadLine();

            Console.Write("\nEnter book genre: ");
            string genre = Console.ReadLine();


            double bookPrice;
            string priceStr;

            do
            {
                Console.Write("\nEnter book price:");
                priceStr = Console.ReadLine();

            } while (!double.TryParse(priceStr, out bookPrice));


            book = new Book(no, name, genre, bookPrice);

            Array.Resize(ref books, books.Length + 1);
            books[^1] = book;
        }

        public static void ShowAllBooks()
        {
            foreach (var item in books)
            {
                item.ShowInfo();
            }
        }
    }
}
namespace _17102023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            string password;
            do
            {
                Console.WriteLine("Enter Username:");
                name = Console.ReadLine();

            }while (!Helper.CheckUsername(name));

            do
            {
                Console.WriteLine("Enter password:");
                password = Console.ReadLine();

            } while (!Helper.CheckPassword(password));

            User user = new User();
            user.Username = name;
            user.Password = password;
            Console.WriteLine($"Tebrikler {user.Username} bey!");

        }
    }
}
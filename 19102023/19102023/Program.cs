using _19102023.Models;
using _19102023.MyExceptions;

namespace _19102023
{
    internal class Program
    {
        static void Main(string[] args)
        {
			//try
			//{
			//             Console.WriteLine("1. Ededi daxil edin:");
			//             int number1 = Convert.ToInt32(Console.ReadLine());
			//             Console.WriteLine("2. Ededi daxil edin:");
			//             int number2 = Convert.ToInt32(Console.ReadLine());
			//             Console.WriteLine("Netice:");
			//             int result = number1 / number2;
			//             Console.WriteLine(result);
			//             Console.WriteLine("Yasinizi daxil edin:");
			//             byte age = Convert.ToByte(Console.ReadLine());

			//         }
			//         catch (FormatException)
			//         {
			//             Console.WriteLine("Format exception!");
			//         }
			//catch (DivideByZeroException)
			//{
			//             Console.WriteLine("0a bolme xetasi!");
			//         }
			//         catch (Exception ex)
			//         {
			//             Console.WriteLine($"{ex.Message}");
			//         }
			//         finally
			//         {
			//             Console.WriteLine("Finally");
			//         }

			//         Console.WriteLine("Salamlar, davam edir!");
			//         Console.WriteLine("Salam Reqsane");

			try
			{
                User user = new User();
                Console.WriteLine("User name daxil edin:");
                string name = Console.ReadLine();
                Console.WriteLine("2. Ededi daxil edin:");
                int number2 = Convert.ToInt32(Console.ReadLine());
                user.Name = name;
            }
			catch(InvalidUserNameException ex)
			{
                Console.WriteLine(ex.Message);
            }
			catch (FormatException ex)
			{
				throw new InvalidUserNameException(ex.Message, ex);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
            }
        }
    }
}
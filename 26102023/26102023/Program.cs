namespace _26102023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(PrintA);
            thread1.Start();
            thread1.Join();
            Thread thread2 = new Thread(PrintB);
            thread2.Start();
            thread2.Join();

            for (int i = 0; i < 1000; i++)
            {
                Console.Write("Salam");
            }

        }

        static void PrintA()
        {
            for (int i = 0; i <= 1000; i++) 
            { 
                Console.Write("A ");
            }
        }

        static void PrintB()
        {
            for (int i = 0; i <= 1000; i++)
            {
                Console.Write("B ");
            }
        }
    }
}
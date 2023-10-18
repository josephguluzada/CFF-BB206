namespace Extensions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 5;

            int num2 = number.Add(10);

            num2.Add(20);
            Console.WriteLine(num2);


            string name = "El9999i";
            string newName = string.Empty;
            if (name.CheckName())
            {
                newName = name.Capitalize();
            }

            Console.WriteLine(newName);
        }
    }
}
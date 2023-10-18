namespace _18102023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id = 30;
            Human human = new Human(17,"Eli","Rasimoglu");
            ChangeId(human.Id);

            Console.WriteLine(human.Id );

        }

        static void ChangeId(int id)
        {
            id = 99;
        }
    }
}
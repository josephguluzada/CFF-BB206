namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            human.Surname = "Test";
            

            Doctor doctor = new Doctor();

            doctor.ShowFullInfo();
        }
    }
}
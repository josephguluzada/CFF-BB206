namespace ClassTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Programmer programmer = new Programmer();
            programmer.Name = "Eda";
            programmer.Surname = "Shukurova";
            programmer.Age = -29;
            programmer.Speciality = "Backend Developer";
            programmer.Experience = -10;

            programmer.ShowFullInfo();
        }
    }


}
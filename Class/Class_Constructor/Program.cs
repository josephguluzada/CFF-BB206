namespace Class_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student student = new Student();
            //student.Name = "Enver";
            //student.Surname = "Zohrabov";
            //student.Age = 35;
            //student.Point = 88;

            //Teacher teacher2 = new Teacher();
            //Teacher teacher3 = teacher1;

            Teacher teacher1 = new Teacher("Yusif","Guluzada",25);
            teacher1.Salary = 6500;

            //Console.WriteLine(teacher1.GetFullInfo());
            teacher1.ShowFullInfo();

            //Teacher teacher2 = new Teacher();


            //Console.WriteLine(teacher1.Name + " " + teacher1.Surname + " " + teacher1.Age);
            //Console.WriteLine(teacher2.Name + " " + teacher2.Surname + " " + teacher2.Age);
        }
    }


}
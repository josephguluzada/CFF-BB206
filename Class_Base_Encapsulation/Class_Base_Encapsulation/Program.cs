namespace Class_Base_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Elsever","Asadov",13,33,0);

            Console.WriteLine(student.Name +" " + student.Surname + " " + student.Age + " " + student.Point + " " + student.Grant);
        }
    }
}
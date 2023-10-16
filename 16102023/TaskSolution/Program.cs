using TaskSolution.Models;

namespace TaskSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher();
            teacher.Name = "Enver";
            teacher.Surname = "Zohrabov";
            teacher.Age = 39;
            teacher.Experience = 20;

            teacher.SayFullname();
            teacher.SayFullData();

            Student student = new Student();
            student.Name = "Inci";
            student.Surname = "Zohrabova";
            student.Age = 39;
            student.Point = 20;

            student.SayFullname();
            student.SayFullData();
        }
    }
}
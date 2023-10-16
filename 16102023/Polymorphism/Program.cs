using Polymorphism.Models;

namespace Polymorphism
{
    public class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            human.Name = "Eli";
            human.Surname = "Eliyev";
            human.Age = 30;

            human.ShowFullData();

            Student student = new Student();
            student.Name = "Veli";
            student.Surname = "Veliyev";
            student.Age = 19;
            student.Point = 99;

            student.ShowFullData();

            Human human1 = student;
            human1.ShowFullData();

            Teacher teacher = new Teacher();
            teacher.Name = "Pirveli";
            teacher.Surname = "Eliyev";
            teacher.Age = 27;
            teacher.Experience = 9;

            teacher.ShowFullData();

            Human human2 = teacher;
            human2.ShowFullData();
           
        }
    }
}
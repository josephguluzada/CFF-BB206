using Indexer.Models;

namespace Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student()
            {
                Fullname = "Elsever Asadov",
                Point = 88
            };
            Student student2 = new Student()
            {
                Fullname = "Ulker Valiyeva",
                Point = 77
            };
            Student student3 = new Student()
            {
                Fullname = "Tanzila Abdiyeva",
                Point = 66
            };

            Course course = new Course()
            {
                Name = "BB206"
            };

            course.Add(student1);
            course.Add(student2);

            course[0] = student3; // course._students[0] = student3;
            Console.WriteLine(course[0]); // course._students[0]


            for (int i = 1; i < course.Length; i++)
            {
                Console.WriteLine(course[i]);
            }

            
        }
    }
}
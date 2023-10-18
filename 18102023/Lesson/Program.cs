using Lesson.Models;

namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee()
            {
                Fullname = "Enver Zohrabov",
                Experience = 10,
                Position = Position.Boss
            };
            Employee employee2 = new Employee()
            {
                Fullname = "Eli Eliyev",
                Experience = 6,
                Position = Position.Engineer
            };
            Employee employee3 = new Employee()
            {
                Fullname = "Inci Memmedyarova",
                Experience = 9,
                Position = Position.Engineer
            };
            Employee employee4 = new Employee()
            {
                Fullname = "Elsever Asadov",
                Experience = 5,
                Position = Position.HR
            };
            Employee employee5 = new Employee()
            {
                Fullname = "Ulker Valiyeva",
                Experience = 5,
                Position = Position.HR
            };

            Employee[] employees = { employee1, employee2, employee3, employee4, employee5 };

            Company company = new Company()
            {
                Name = "NASA"
            };

            company.AddEmployee(employees);

            Employee[] wantedEmployees = company.GetEmployeesByPosition(0);

            foreach (var item in wantedEmployees)
            {
                Console.WriteLine(item);
            }



        }
    }
}
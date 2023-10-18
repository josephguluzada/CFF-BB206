using Task.Models;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            employee1.Fullname = "Eli ELiyev";

            Employee employee2 = new Employee();
            employee2.Fullname = "Veli ELiyev";

            Employee employee3 = new Employee();
            employee3.Fullname = "Pirveli ELiyev";

            Department department = new Department();
            department.AddEmployee(employee1);
            department.AddEmployee(employee2);
            department.AddEmployee(employee3);

            Employee wantedEmployee = department.GetEmployee(2);

            Console.WriteLine(wantedEmployee.No + " - " + wantedEmployee.Fullname );
        }
    }
}
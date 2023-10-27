using _241012023.Models;

namespace _241012023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee() { Name = "Eli", Age = 27, Salary = 1800};
            Employee employee2 = new Employee() { Name = "Veli", Age = 28, Salary = 2700};
            Employee employee3 = new Employee() { Name = "Pir27veli", Age = 37, Salary = 3800};

            Department department = new Department() { Name = "Deliler", EmployeeLimit = 15 };


            department.AddEmployee(employee1);
            department.AddEmployee(new List<Employee>() { employee2, employee3 });

            department.RemoveEmployee(3);


            var filteredEmployees = department.SearchEmployee("27");

            foreach (var item in filteredEmployees)
            {
                Console.WriteLine(item);
            }
        }
    }
}
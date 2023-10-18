using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson.Models
{
    internal class Company
    {
        public string Name { get; set; }
        public Employee[] Employees;
        public Company()
        {
            Employees = new Employee[0];
        }

        public void AddEmployee(Employee employee)
        {
            Array.Resize(ref Employees, Employees.Length+1);
            Employees[^1] = employee;
        }

        public void AddEmployee(ref Employee[] newEmployees,Employee employee)
        {
            Array.Resize(ref newEmployees, newEmployees.Length + 1);
            newEmployees[^1] = employee;
        }

        public void AddEmployee(Employee[] employees)
        {
            for (int i = 0; i < employees.Length; i++)
            {
                AddEmployee(employees[i]);
            }
        }

        public Employee[] GetEmployeesByPosition(string position)
        {
            Employee[] filteredEmployees = new Employee[0];

            foreach (Employee employee in Employees)
            {
                if (employee.Position.ToString().ToLower() == position.Trim().ToLower()) 
                {
                    AddEmployee(ref filteredEmployees, employee);
                }
            }

            return filteredEmployees;
        }

        public Employee[] GetEmployeesByPosition(int positionNo)
        {
            Employee[] filteredEmployees = new Employee[0];

            foreach (Employee employee in Employees)
            {
                if ((int)employee.Position == positionNo)
                {
                    AddEmployee(ref filteredEmployees, employee);
                }
            }

            return filteredEmployees;
        }
    }
}

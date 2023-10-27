using _241012023.CustomExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _241012023.Models
{
    internal class Department
    {
        public string Name { get; set; }
        public int EmployeeLimit { get; set; }
        public List<Employee> Employees = new List<Employee>();


        public void AddEmployee(Employee employee)
        {
            if (EmployeeLimit > Employees.Count && employee != null)
                Employees.Add(employee);
            else throw new CapacityLimitException("Limiti ashdiniz!");
        }

        public void AddEmployee(List<Employee> employees)
        {
            if(EmployeeLimit > Employees.Count + employees.Count)
            {
                Employees.AddRange(employees);
            }
        }

        public void RemoveEmployee(int id)
        {
            for (int i = 0; i < Employees.Count; i++)
            {
                if (Employees[i].Id == id)
                    Employees.RemoveAt(i);
            }
        }

        public List<Employee> SearchEmployee(string value)
        {
            List<Employee> filteredEmployees = new List<Employee>();

            foreach (var employee in Employees)
            {
                if(employee.Name.ToLower().Contains(value.ToLower()) || 
                   employee.Salary.ToString().Contains(value.ToLower()) || 
                   employee.Age.ToString().Contains(value.ToLower()))
                {
                    filteredEmployees.Add(employee);
                }
            }

            return filteredEmployees;
        }
    }
}

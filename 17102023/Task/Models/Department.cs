using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Models
{
    public class Department
    {
        public string Name { get; set; }
        private Employee[] _employees;

        public Department()
        {
            _employees = new Employee[0];
        }

        public void AddEmployee(Employee employee)
        {
            Array.Resize(ref _employees, _employees.Length+1);
            _employees[^1] = employee;
        }

        public Employee GetEmployee(int employeeNo)
        {
            foreach (Employee employee in _employees)
            {
                if (employee.No == employeeNo) return employee;
            }
            return null;
        }
    }
}

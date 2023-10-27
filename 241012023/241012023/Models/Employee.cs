using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _241012023.Models
{
    internal class Employee : IPerson
    {
        private static int _id;
        public Employee()
        {
            _id++;
            Id = _id;
        }

        public int Id { get; private set; }
        public string Name { get ; set ; }
        public byte Age { get ; set ; }
        public double Salary { get; set; }

        public string ShowInfo()
        {
            return $"{Id} {Name} {Age} {Salary}";
        }

        public override string ToString()
        {
            return ShowInfo();
        }
    }
}

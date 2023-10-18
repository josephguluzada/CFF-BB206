using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Models
{
    public class Employee
    {
        static Employee()
        {
            _counter = 0;
        }

        public Employee()
        {
            _counter++;
            No = _counter;
        }

        private static int _counter;
        public int No { get; }
        public string Fullname { get; set; }
        public byte Experience { get; set; }
    }
}

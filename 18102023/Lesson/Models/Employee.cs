using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson.Models
{
    internal class Employee
    {
        private static int _counter;
        public int Id { get; }
        public string Fullname { get; set; }
        public double Experience { get; set; }
        public Position Position { get; set; }

        static Employee()
        {
            _counter = 0;
        }
        public Employee()
        {
            _counter++;
            Id = _counter;
        }

        public override string ToString()
        {
            return $"Id: {Id} Fullname: {Fullname} Position: {Position} ";
        }
    }
}

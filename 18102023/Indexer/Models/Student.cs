using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer.Models
{
    internal class Student
    {
        public string Fullname { get; set; }
        public double Grant { get; set; }
        public double Point { get; set; }

        public override string ToString()
        {
            return $"Fullname {Fullname} Point {Point}";
        }
    }
}

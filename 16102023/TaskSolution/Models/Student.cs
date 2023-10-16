using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSolution.Models
{
    public class Student : Person, IInformable
    {
        public double Point { get; set; }

        public void SayFullData()
        {
            Console.WriteLine($"Fullname : {Name} {Surname} Age: {Age} Point: {Point}");
        }
    }
}

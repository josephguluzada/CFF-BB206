using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSolution.Models
{
    public abstract class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get; set; }

        public void SayFullname()
        {
            Console.WriteLine($"Fullname : {Name} {Surname}");
        }
        
    }
}

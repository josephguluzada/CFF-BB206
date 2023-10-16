using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Models
{
    public class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get; set; }

        public virtual void ShowFullData()
        {
            Console.WriteLine($"Fullname : {Name} {Surname} Age: {Age}");
        }
    }
}

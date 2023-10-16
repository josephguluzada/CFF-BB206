using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16102023.Models
{
    public class Dog : Animal
    {
        private string _name;
       

        public override void MakeSound()
        {
            Console.WriteLine("Hav Hav");
        }
    }
}

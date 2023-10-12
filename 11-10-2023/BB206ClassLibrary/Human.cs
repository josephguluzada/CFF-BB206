using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB206ClassLibrary
{
    public class Human
    {
        private protected string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get; set; }


        public void SayName()
        {
            Console.WriteLine($"{Name} {Surname}");
        }
    }

    public class Test : Human
    {
        
        public Test()
        {
        }
    }
}

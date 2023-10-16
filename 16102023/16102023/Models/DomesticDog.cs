using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16102023.Models
{
    public class DomesticDog : Dog
    {
        public override string Name { get => base.Name; set => base.Name = value; }
        public override void MakeSound()
        {
            Console.WriteLine("Huav Huav Chuava");
        }
    }
}

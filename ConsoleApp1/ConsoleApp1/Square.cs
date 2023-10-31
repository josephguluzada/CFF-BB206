using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Square:Figure
    {
        public int Kenar { get; set; }

        public override double AreaCalc()
        {
            return Math.Pow(Kenar, 2) * Math.PI;

        }
    }
}

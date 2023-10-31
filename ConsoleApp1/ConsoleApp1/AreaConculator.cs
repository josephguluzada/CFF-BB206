using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class AreaConculator
    {

        public double Area { get; set; }

        //public double AreaCalc(object figure)
        //{
        //    if(figure is Circle)
        //    {
        //        Circle circle = (Circle)figure;
        //        Area = Math.Pow(circle.Radius, 2) * Math.PI;
                
        //    }
        //    else if(figure is Square)
        //    {
        //        Square square = (Square)figure;
        //        Area = Math.Pow(square.Kenar, 2);
        //    }

        //    return Area;
        //}

        public double AreaCalc(Figure figure)
        {
            return figure.AreaCalc();
        }
    }
}

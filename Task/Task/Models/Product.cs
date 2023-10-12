using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Models
{
    public class Product
    {
        private double _price;
        private double _count;
        public int No { get; set; }
        public string Name { get; set; }
        public double Price 
        {
            get => _price;
            set
            {
                if(value > 0) _price = value;
            } 
        }
        public double Count 
        {
            get => _count;
            set
            {
                if (value >= 0) _count = value;
            }
        }

    }
}

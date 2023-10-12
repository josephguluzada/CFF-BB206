using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask
{
    public class Book
    {
        private double _price;
        public string Name;
        public string Code;

        public Book(string name)
        {
            Name = name;
            Code = name.Substring(0, 2).ToUpper(); // Harry Potter ==> HP
        }

        public double Price
        {
            get => _price;
            set 
            {
                if(value >0)
                {
                    _price = value;
                }
            }
        }
    }
}

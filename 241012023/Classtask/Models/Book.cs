using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classtask.Models
{
    internal class Book
    {
        private static int _counter=10;
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public string Code { get; set; }

        public Book(string name)
        {
            _counter++;
            Name = name;
            Code = name.Substring(0,2).ToUpper() + _counter.ToString();
        }


        public override string ToString()
        {
            return $"{Code} - {Name} {AuthorName} {PageCount}";
        }
    }
}

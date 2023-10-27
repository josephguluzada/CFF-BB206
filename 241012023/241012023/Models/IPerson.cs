using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _241012023.Models
{
    internal interface IPerson
    {
        public string Name { get; set; }
        public byte Age { get; set; }
        string ShowInfo();
    }
}

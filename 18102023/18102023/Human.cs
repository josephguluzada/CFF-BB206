using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18102023
{
    internal struct Human : ITest
    {
        public Human(int id, string name, string surname)
        {
            Id = id; 
            Name = name; 
            Surname = surname;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    interface ITest
    {
        public byte Age { get; set; }
    }

    struct Test2
    {

    }
}

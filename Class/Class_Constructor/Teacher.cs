using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Constructor
{
    public class Teacher
    {
        public Teacher()
        {
            Console.WriteLine("Teacher Obyekti Yarandi");
        }

        public Teacher(string name) : this()
        {
            this.Name = name;
        }

        public Teacher(string name, string surname) : this(name)
        {
            this.Surname = surname;
        }

        public Teacher(string name, string surname, byte age) : this(name,surname)
        {
            this.Age = age;
        }

        public string Name;
        public string Surname;
        public byte Age;
        public double Salary;

        public string GetFullInfo()
        {
            return $"{this.Name} {this.Surname} {this.Age} {this.Salary}";
        }

        public void ShowFullInfo()
        {
            Console.WriteLine(GetFullInfo());
        }
    }
}

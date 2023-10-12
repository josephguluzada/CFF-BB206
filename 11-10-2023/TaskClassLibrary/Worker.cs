using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskClassLibrary
{
    public class Worker
    {
        private sbyte _experience;
        public string Name { get; set; }
        public string Surname { get; set; }
        public string WorkerCode { get; set; }

        public Worker(string name, string surname, sbyte experience)
        {
            this.Name = name;
            this.Surname = surname;
            this.Experience = experience;
            this.WorkerCode = name.Substring(0,1).ToUpper() + surname.Substring(0,1).ToUpper();
        }

        public sbyte Experience 
        { 
            get => _experience;
            set
            {
                if(value >=0) 
                {
                    _experience = value;
                }
            }
        }

        public void ShowAllInfo()
        {
            Console.WriteLine($"Fullname: {this.Name} {this.Surname} WorkerCode: {this.WorkerCode} ");
        }
    }
}

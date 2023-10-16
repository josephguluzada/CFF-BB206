using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSolution.Models
{
    public class Teacher : Person, IInformable
    {
        public byte Experience { get; set; }

        public void SayFullData()
        {
            Console.WriteLine($"Fullname : {Name} {Surname} Age: {Age} Experince: {Experience}");
        }
    }
}

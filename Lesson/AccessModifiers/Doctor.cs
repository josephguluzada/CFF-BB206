using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class Doctor : Human
    {
        public Doctor()
        {
            Name = "Eli";
            Surname = string.Empty;
        }
        public double Experience { get; set; }

        public void ShowFullInfo()
        {
            Console.WriteLine($"Doctor name: {Name}");
        }
    }
}

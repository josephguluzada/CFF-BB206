using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask
{
    public class Programmer : Human
    {
        private double _experience;
        public string Speciality { get; set; }


        public double Experience 
        {
            get => _experience;
            set
            {
                if(value > 0 && value < 70)
                {
                    _experience = value;
                }
            }
        }

        public void ShowFullInfo()
        {
            Console.WriteLine(GetFullInfo());
        }

        public string GetFullInfo()
        {
            return $"Name: {Name} Surname: {Surname} Age: {Age} \nSpeciality: {Speciality} Experience: {Experience}";
        }
    }
}

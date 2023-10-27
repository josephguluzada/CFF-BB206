using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask.Models
{
    internal class Farm
    {
        private Animal[] _animals;

        public Farm()
        {
            _animals = new Animal[0];
        }

        public void AddAnimal(Animal animal)
        {
            Array.Resize(ref _animals, _animals.Length + 1);
            _animals[^1] = animal;
        }

        public void ShowAllAnimals()
        {
            foreach (Animal animal in _animals)
            {
                if(animal is Sheep)
                {
                    Sheep sheep = (Sheep) animal;
                    Console.WriteLine($"{sheep.Gender} - {sheep.Age} - {sheep.Type}");
                }
                else if (animal is Horse)
                {
                    Horse horse = animal as Horse;
                    Console.WriteLine($"{horse.Gender} - {horse.Age} - {horse.Sort}");
                }
            }
        }
    }
}

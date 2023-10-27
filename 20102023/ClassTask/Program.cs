using ClassTask.Models;

namespace ClassTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal horseAnimal1 = new Horse() {Age = 3, Sort = "Garabagh sort" };
            Animal horseAnimal2 = new Horse() {Age = 5, Sort = "Garabagh sort Pro version" };

            Animal sheepAnimal1 = new Sheep() { Age = 3, Type = "Kababliq" };
            Animal sheepAnimal2 = new Sheep() { Age = 1, Type = "Basdirmaliq ve ya shishlik" };

            Farm farm = new Farm();

            farm.AddAnimal(horseAnimal1);
            farm.AddAnimal(horseAnimal2);
            farm.AddAnimal(sheepAnimal2);
            farm.AddAnimal(sheepAnimal1);

            farm.ShowAllAnimals();
        }
    }
}
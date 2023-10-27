using _20102023.Models;

namespace _20102023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // UpCasting
            //Type Variable name   |  Value
            Animal animalDog = new Dog() { Gender = "Male", Age = 2, Type = "Choban iti" };
            //Type Variable name   |  Value
            Animal animalCat = new Cat() { Gender = "Female" , Age = 1, TailLength = 40};
            Animal animal = new Animal();





            // Downcasting
            //Cat catDog = (Cat)animalDog; // cevire bilmese exception
            //Cat cat = animalDog as Cat; // cevire bilmese null set edir

            //Dog dog1 = (Dog)animalDog;
            //Cat cat1 = animalCat as Cat;


            Animal[] animals = new Animal[] { animalDog, animalCat};

            foreach (Animal anm in animals)
            {
                if (anm is Dog)
                {
                    Dog dog = (Dog)anm;
                    Console.WriteLine(dog.Type);
                }
                else if (anm is Cat)
                {
                    Cat cat = anm as Cat;
                    Console.WriteLine(cat.TailLength);
                }
            }

            //Console.WriteLine(cat.TailLength);
            // 255 256 257 258
            //long a = 2570000000000000;
            //string ageStr = Console.ReadLine();


        }
        //static void Test(int? a)
        //{
        //    if(a == null)
        //    {
        //        Console.WriteLine("Nulldir");
        //    }
        //    else
        //    {
        //        Console.WriteLine(a);
        //    }
        //}
    }
}
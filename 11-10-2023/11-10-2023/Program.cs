using _11_10_2023.Classes;
using _11_10_2023.Classes.Models;
using BB206ClassLibrary;
using System.Text;
using StringBuilder = System.Text.StringBuilder;


namespace _11_10_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Person person = new Person();
            Doctor person2 = new Doctor();
            Car car = new Car();
            StringBuilder sb = new StringBuilder();
            Human human = new Human();

            //human.Name = "Eli";
            human.Surname = "Eliyev";

            human.SayName();

        }

    }

   
}
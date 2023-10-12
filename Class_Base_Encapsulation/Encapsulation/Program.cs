namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Brand = "Toyota";
            car.Model = "Prius";
            car.CurrentFuel = 50;
            car.FuelFor1Km = 3;
            car.Millage = -200;

            Console.WriteLine(car.Millage);
            //Console.WriteLine(car.FuelFor1Km);
            //car.FuelFor1KmSetter(500);

            //Console.WriteLine(car.FuelFor1KmGetter());
            car.Drive(5);

            //Console.WriteLine(car.GetFullInfo());
        }
    }
}
namespace Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CarRecord carRecord = new CarRecord("BMW", 95000, 130000);

            ////(string name, double price, double costPrice) = carRecord;

            ////Console.WriteLine(price + " " + costPrice);

            //CarRecord carRecord2 = new CarRecord("BMW",45000, 400000);
            //CarRecord carRecord3 = carRecord with { Price = 90000 , Name = "Eli"};

            //Console.WriteLine(carRecord3.Name + " " + carRecord3.Price + " " + carRecord3.CostPrice);
            //carRecord.Name = "Mercedes";
            //Console.WriteLine(carRecord.Name);
            //Console.WriteLine(carRecord.Price);
            //Console.WriteLine(ReferenceEquals(carRecord,carRecord3));

            //CarClass carClass = new CarClass("BMW M5", 6645000);

            //(string name, double price) = carClass;
            //Console.WriteLine(name + " " + price);

            //CarClass carClass2 = new CarClass("BMW", 45000);

            //Console.WriteLine(ReferenceEquals(carClass, carClass2));
            ////Console.WriteLine(carRecord.Name);
            ////Console.WriteLine(carRecord.Price);

            //CarRecord2 carRecord4 = new CarRecord2()
            //{
            //    Name = "Mercedes",
            //    Price = 70000
            //};


            //(string name, double price) = carRecord4;
            ////carRecord2.Name = "Bmw";

            //Console.WriteLine(name + " " + price);


            Book book = new Book("Harry Potter", 29, 3);
            var ( name,  sellPrice,  costPrice) = book;

            Custom custom = new Custom("Sherlock Holmes", 55, 1);
            var (name1, sellPrice1, costPrice1) = custom;
            Console.WriteLine(name1);
        }
    }

    public record Book(string Name, double SellPrice, double CostPrice);

    public record Custom
    {
        public string Name { get; init; }
        public double SellPrice { get; init; }
        public double CostPrice { get; init; }
        public Custom(string name, double sellPrice, double costPrice)
        {
            //this.Name = name;
            //this.SellPrice = sellPrice;
            //this.CostPrice = costPrice;
            (this.Name,this.SellPrice,this.CostPrice) = (name,sellPrice,costPrice);
        }

        public void Deconstruct(out string name,out double sellPrice,out double costPrice)
        {
            name = this.Name;
            sellPrice = this.SellPrice; 
            costPrice = this.CostPrice;
        }
    }

    public record CarRecord(string Name, double Price, double CostPrice);

    public record CarRecord2
    {
        public string Name { get; init; }
        public double Price { get; init; }

        public void Deconstruct(out string name,out double price)
        {
            name = this.Name;
            price = this.Price;
        }
    }

    public class CarClass
    {

        public CarClass(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public string Name { get; set; }
        public double Price { get; set; }

        public void Deconstruct(out string name, out double price)
        {
            name = this.Name;
            price = this.Price;
        }
    }
}
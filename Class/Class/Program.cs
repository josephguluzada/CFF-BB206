namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string name1 = "Elvin";
            //string surname1 = "Sarkarov";
            //byte age1 = 19;

            //string name2 = "Shahin";
            //string surname2 = "Ismayilov";
            //byte age2 = 19;

            //string[] names = { "Elvin", "Shahin", "Ulker", "Sebine", "Hemid" };
            //string[] surnames = { "Sarkarov", "Ismayilov", "Valiyeva", "Hashimova", "Garacayev", "Eliyev" };
            //byte[] ages = {19,19,19,19 ,19, 20};

            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine($"{names[i]} {surnames[i]} {ages[i]}");
            //}

            //var std1 = new
            //{
            //    Name = "Elvin",
            //    Surname = "Sarkarov",
            //    Age = 19
            //};

            //var std2 = new
            //{
            //    Name = "Shahin",
            //    Surname = "Ismayilov",
            //    Age = 19,
            //    Stipendiya = 0
            //};

            //var std3 = new
            //{
            //    Name = "Ulker",
            //    Surname = "Valiyeva",
            //    Age = 19,
            //    Point = 76
            //};

            //Student std1 = new Student();
            //std1.Name = "Rasim";
            //std1.Surname = "Eliyev";
            //std1.Age = 18;
            //std1.Point = 99;

            //Student std2 = new Student()
            //{
            //    Name = "Eli",
            //    Surname = "Valiyev",
            //    Point = 97,
            //    Age = 18
            //};

            //Teacher tch1 = new Teacher();
            //tch1.Name = "Yusif";
            //tch1.Surname = "Guluzada";
            //tch1.Age = 25;
            //tch1.Salary = 6.500;
            //Console.WriteLine(std2.Age);


            //tch1.SayName();

            //Human human1 = new Human();
            //human1.Name = "Elsever";
            //human1.Surname = "Asadov";
            //human1.Age = 20;


            //Human human2 = new Human();
            //human2.Name = "Eli";
            //human2.Surname = "Asadov";
            //human2.Age = 30;

            //human1.SayName();

           Student std1 = new Student();
            std1.Name = "Eli";
            std1.Surname = "Eliyev";
            std1.Point = 100;
            std1.Age = 30;
            std1.ShowInfo();

            Teacher teacher1 = new Teacher();
            teacher1.Name = "Enver";
            teacher1.Surname = "Zohrabov";

            Teacher teacher2 = new Teacher();
            teacher2.Name = "Rasim";
            teacher2.Surname = "Balayev";

            Teacher[] teachers = { teacher1, teacher2};

            foreach (Teacher tch in teachers)
            {
                tch.ShowInfo();
            }

        }

    }

    //class Human
    //{
    //    public string Name;
    //    public string Surname;
    //    public byte Age;

    //    public void SayName()
    //    {
    //        Console.WriteLine($"{Name} {Surname} {Age}");
    //    }
    //}

    //class Student : Human
    //{
    //    public double Point;
    //}

    //class Teacher : Human
    //{
    //    public double Salary;
    //}



    class Human
    {
        public string Name;
        public string Surname;
        public byte Age;
    }

    class Student : Human
    {
        public double Point;
        public void ShowInfo()
        {
            Console.WriteLine($"{this.Name} {this.Surname} {this.Age} {this.Point}");
        }
    }

    class Teacher : Human
    {
        public double Salary;
        public void ShowInfo()
        {
            Console.WriteLine($"{this.Name} {this.Surname} {this.Age} {this.Salary}");
        }
    }

}
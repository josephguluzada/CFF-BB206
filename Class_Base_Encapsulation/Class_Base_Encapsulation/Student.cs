namespace Class_Base_Encapsulation
{
    public class Student :  Human
    {
        public Student()
        {
            
        }

        public Student(string name) : base(name)
        {

        }

        public Student(string name, string surname) : base(name, surname)
        {

        }

        public Student(string name, string surname, byte age) : base(name, surname, age)
        {

        }

        public Student(string name, string surname, byte age, double point) : base(name, surname, age)
        {
            this.Point = point;
        }

        public Student(string name, string surname, byte age, double point, double grant) : this(name, surname, age, point)
        {
            this.Grant = grant;
        }

        public double Point;
        public double Grant;
    }
}

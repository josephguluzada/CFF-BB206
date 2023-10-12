namespace Class_Base_Encapsulation
{
    public class Human
    {
        public string Name;
        public string Surname;
        public byte Age;

        public Human(){}

        public Human(string name)
        {
            this.Name = name;
        }

        public Human(string name, string surname) : this(name)
        {
            this.Surname = surname;
        }

        public Human(string name, string surname, byte age) : this(name,surname)
        {
            this.Age = age;
        }
    }
}

namespace ClassTask
{
    public class Human
    {
        private sbyte _age;
        private string _name;
        public string Surname { get; set; }
        public string Name 
        { 
            get => _name;
            set
            {
                if(value != null && value.Length > 2) 
                {
                    _name = value;
                }
            }
        }

        public sbyte Age 
        {
            get => _age;
            set
            {
                if(value > 0 && value < 186)
                {
                    _age = value;
                }
            }
        }
    }
}
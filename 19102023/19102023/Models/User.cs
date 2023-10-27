using _19102023.MyExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19102023.Models
{
    internal class User
    {

        public int Id { get; set; }
        private string _name;

        public string Name
        {
            get =>  _name; 
            set 
            { 
                if(value.Length >2)
                {
                    _name = value;
                }
                else
                {
                    throw new InvalidUserNameException("Name length was incorrect. Min: 3 character length");
                }
            }
        }

        public string Surname { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17102023
{
    public class User
    {
        private string _password;
        static User()
        {
            StaticCount = 5;
        }

        public User()
        {
            StaticCount+=1;
            No = StaticCount;
        }
        public string Username;
        public string Password { 
            get { return _password; }
            set
            {
                if (Helper.CheckPassword(value))
                {
                    _password = value;
                }
            }
        }
        public int No { get;}
        public static int StaticCount { get; set; }
    }
}

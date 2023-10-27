using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19102023.MyExceptions
{
    internal class InvalidUserNameException : Exception
    {
        public InvalidUserNameException(){}

        public InvalidUserNameException(string message) : base(message){}

        public InvalidUserNameException(string message, Exception innerException) : base(message, innerException){}
    }
}

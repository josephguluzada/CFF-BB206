using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _241012023.CustomExceptions
{
    internal class CapacityLimitException : Exception
    {
        public CapacityLimitException()
        {
            
        }

        public CapacityLimitException(string message) : base(message)
        {
            
        }
    }
}

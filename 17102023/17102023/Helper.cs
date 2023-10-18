using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17102023
{
    public static class Helper
    {
        static Helper()
        {

        }
        private static readonly string test;
        private static  string Test2 { get; set; }
        public static bool CheckPassword(string password)
        {
            if (!string.IsNullOrEmpty(password) && password.Length > 7 && password.Length < 16)
            {
                return true;
            }
            return false;
        }

        public static bool CheckUsername(string username)
        {
            if(!string.IsNullOrWhiteSpace(username) && username.Length > 2)
            {
                return true;
            }
            return false;
        }
    }
}

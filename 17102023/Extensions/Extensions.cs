using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    public static class Extensions
    {
        public static int Add(this int num, int addedNum)
        {
            return num= num + addedNum;
        }

        public static string Capitalize(this string str)
        {
            var newStr = str.Trim();
            return newStr = char.ToUpper(newStr[0]) + newStr.Substring(1);
        }

        public static bool CheckName(this string str)
        {
            if(str == null) return false;
            for (int i = 0; i < str.Length; i++)
            {
                if (!char.IsLetter(str[i]))
                {
                    return false;
                }
            }

            return true;
        }
    }
}

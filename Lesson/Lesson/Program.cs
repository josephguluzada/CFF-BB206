namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region String Methods
            string nameStr = "Mehebbet-Mehebbetzade-Salam";

            Console.WriteLine(nameStr.TrimEnd());
            Console.WriteLine(nameStr.TrimStart());
            Console.WriteLine(nameStr.Trim());
            Console.WriteLine(nameStr.ToLower());
            Console.WriteLine(nameStr.ToUpper());
            Console.WriteLine(nameStr.Contains('s'));
            Console.WriteLine(nameStr.Trim().Length);
            Console.WriteLine(nameStr.Replace(" ", ""));
            Console.WriteLine(nameStr.Trim().Replace(" ", ""));
            Console.WriteLine(nameStr.EndsWith("bet"));
            Console.WriteLine(nameStr.StartsWith("M"));
            Console.WriteLine(nameStr.Substring(2, 3));
            var stringArr = nameStr.Split("-");

            Console.WriteLine("Split method: ");
            foreach (var item in stringArr)
            {
                Console.WriteLine(item);
            }

            string[] testArr = { "Tenzile", "Remzi", "Maga" };

            Console.WriteLine(String.Join("&", testArr));
            #endregion

            #region Array Methods
            Console.WriteLine(stringArr.Length);

            Array.Resize(ref stringArr, stringArr.Length + 1);
            stringArr[^1] = "Elsever";
            Console.WriteLine("Yeni array: ");
            foreach (var item in stringArr)
            {
                Console.WriteLine(item);
            }

            int[] numberArr = { 1,5,3,9,7,8 };
            //Array.Reverse(numberArr);
            //Console.WriteLine("Yeni array Reversed: ");
            //foreach (var item in numberArr)
            //{
            //    Console.WriteLine(item);
            //}

            //Array.Sort(numberArr);
            //Array.Reverse(numberArr);
            //Console.WriteLine("Yeni array Sorted: ");
            //foreach (var item in numberArr)
            //{
            //    Console.WriteLine(item);
            //}

            //Array.Clear(numberArr,2,2);

            //foreach (var item in numberArr)
            //{
            //    Console.WriteLine(item);
            //}

            int[] copiedArr = new int[numberArr.Length];

            foreach (var item in numberArr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Copy process");

            Array.Copy(numberArr, 3, copiedArr, 3, 3);


            foreach (var item in copiedArr)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Char Methods

            Console.WriteLine(char.IsDigit('9'));
            Console.WriteLine(char.IsLetter('l'));
            Console.WriteLine(char.IsLetterOrDigit('&'));
            Console.WriteLine(char.IsLower('L'));
            Console.WriteLine(char.IsUpper('L'));
            Console.WriteLine(char.ToUpper('a'));

            #endregion


        }
    }
}
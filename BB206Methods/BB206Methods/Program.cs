using System.Xml.Linq;

namespace BB206Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PrintAllChars("Elishko");
            //PrintAllChars("Yusif");

            //PrintName("Elsever");

            //int[] nums = { 1, 3, 4, 5, 6, 99, 100, 200 };

            //PrintNumbers(1, 2, 3, 4, 5, 6, 7, 8, 9, 00, 99, 88, 77, 66);

            //static void PrintNumbers( int num1, int num2, params int[] numbers)
            //{
            //    Console.WriteLine($"Num1 : {num1} Num2: {num2}");
            //    for (int i = 0; i < numbers.Length; i++)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //string[] names = { "Yusif", "Hemid", "Remzi" };

            //PrintAllNames("Yusif", "Hemid", "Remzi");

            //Console.WriteLine(Reverse("Ulker"));

            //int sum =  Sum(9 , 7);
            //sum += 8;

            //Console.WriteLine(sum);

            CombineAndPrint("Yusif", "Guluzada");

            string word = CombineAndReturn("Eli","Eliyev");

            Console.WriteLine(word);

            //Sum(5, 6.6);

            Console.WriteLine(Sum(7,90));

            Console.WriteLine(90/3);



        }

        // ReturnType void, Parameter qebul etmir

        static void PrintName()
        {
            Console.WriteLine("Elsever");
        }
        static void Test()
        {
            PrintName();
        }

        // ReturnType void, Parameter qebul edir

        static void CombineAndPrint(string word1, string word2)
        {
            Console.WriteLine($"{word1} {word2}");
        }
        static void PrintAllNames(params string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
        static void PrintAllChars(string name)
        {
            if (name.Length >= 5)
            {
                for (int i = 0; i < name.Length; i++)
                {
                    Console.WriteLine(name[i]);
                }
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }

        // ReturnType var, Parameter qebul edir

        static string CombineAndReturn(string word1, string word2)
        {
            return word1 + " " + word2;
        }
        static string Reverse(string name)
        {
            string reversedName = "";
            for (int i = name.Length-1; i >=0; i--)
            {
                reversedName += name[i];
            }
            return reversedName;
        }
        

        // ReturnType var, Parameter qebul etmir

        static int NotExistInArray()
        {
            return -1;
        }





        static int Sum(int num1, int num2 = 10)
        {
            return num1 + num2;
        }

        static double Sum(int num1, double num2)
        {
            return num1 + num2;
        }

        static double Sum(double num1, int num2)
        {
            return num1 + num2;
        }

        static int Sum(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        static int Sum(int num1, int num2, int num3, int num4)
        {
            return num1 + num2 + num3 + num4;
        }

        //static int Sum(params int[] array)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        sum+= array[i];
        //    }

        //    return sum;
        //}

    }
}
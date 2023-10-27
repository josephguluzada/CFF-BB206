namespace Delegates
{
    internal class Program
    {
        //delegate bool CheckNum(int value);
        //delegate int SumOfTwo(int value1, int value2);
        delegate bool YoxlaGorBolunur(int value);
        static void Main(string[] args)
        {
            //var sumOfAll = SumOfAll(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10}, BeseBolunen);
            //var sumOfOdds = SumOfOdds(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });


            //Console.WriteLine($"Cutlerin cemi {sumOfAll}");
            //Console.WriteLine($"Teklerin cemi {sumOfOdds}");

            //CheckNum check = BeseBolunen;
            //check = delegate (int num) { return num % 7 == 0; };
            //check = (int num) => num % 8 == 0;


            //SumOfTwo sumOfTwo = delegate (int value1, int value2) {  return value1 + value2; };
            //sumOfTwo = (int num1, int num2) => num1 + num2;
            //sumOfTwo = SumOfTwoElem;

            //Console.WriteLine(check(88));


            Console.WriteLine(Sum(new List<int> { 1, 2, 3, 40, 5, 6, 70, 8, 9, 10 }, 
               CheckNum));


        }

        static bool CheckNum(int num)
        {
            return num % 10 == 0;  
        }

        static int Sum(List<int> list, YoxlaGorBolunur method)
        {
            int sum = 0;
            foreach (int item in list)
            {
                if (method(item))
                {
                    sum += item;
                }
            }
            return sum;
        }

       // static int SumOfTwoElem(int value1, int value2)
       // {
       //     return value1 + value2;
       // }

       // static bool IsEven(int number)
       // {
       //     return number % 2 == 0;
       // }

       //static bool IsOdd(int number)
       // {
       //     return number % 2 == 1;
       // }

       // static bool BeseBolunen(int number)
       // {
       //     return number % 5 == 0;
       // }

       // static int SumOfAll(List<int> ints, CheckNum check)
       // {
       //     int sum = 0;
       //     foreach (var item in ints)
       //     {
       //         if (check(item))
       //         {
       //             sum += item;
       //         }
       //     }

       //     return sum;
       // }

       // static int SumOfEvens(List<int> ints)
       // {
       //     int sum = 0;
       //     foreach (var item in ints)
       //     {
       //         if(item % 2 == 0)
       //         {
       //             sum += item;
       //         }
       //     }

       //     return sum;
       // }

       // static int SumOfOdds(List<int> ints)
       // {
       //     int sum = 0;
       //     foreach (var item in ints)
       //     {
       //         if (item % 2 == 1)
       //         {
       //             sum += item;
       //         }
       //     }

       //     return sum;
       // }

       // static int SumOfDivideByFive(List<int> ints)
       // {
       //     int sum = 0;
       //     foreach (var item in ints)
       //     {
       //         if (item % 5 == 0)
       //         {
       //             sum += item;
       //         }
       //     }

       //     return sum;
       // }
    }
}
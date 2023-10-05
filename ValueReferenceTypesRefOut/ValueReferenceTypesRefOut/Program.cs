using System.Threading.Channels;

namespace ValueReferenceTypesRefOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            //int b = ref(a0b)a; //5
            //a = 7;

            //int[] nums1 = { 1, 2, 3, 4, 5 };
            //int[] nums2 = nums1;
            //nums1[0] = 55;
            //nums2[^1] = 100;

            //for (int i = 0; i < nums1.Length; i++) 
            //{
            //    Console.WriteLine(nums1[i]);
            //}
            //Console.WriteLine("----------------------------------------------------");
            //for (int i = 0; i < nums2.Length; i++)
            //{
            //    Console.WriteLine(nums2[i]);
            //}


            //MakeNumberHundred(ref a);
            //Console.WriteLine($"Methoddan sonra {a}");

            //Console.WriteLine(b);


            //string[] names1 = { "Eli", "Enver", "Zohrab", "Rasim", "Orxan" };
            //string[] names2 = names1;
            //names2[2] = "Elimohsum";

            //for (int i = 0; i < names1.Length; i++)
            //{
            //    Console.WriteLine(names1[i]);
            //}
            //Console.WriteLine("=======================================");
            //for (int i = 0; i < names2.Length; i++)
            //{
            //    Console.WriteLine(names2[i]);
            //}
            //int number = int.Parse(Console.ReadLine());


            //Console.WriteLine("Number = :" + number);
            //Console.WriteLine("Bir eded daxil edin:");
            //string word = Console.ReadLine();
            //CheckValue(word);
            //int negativeNumber = -17;
            //MakeNumberHundred(out negativeNumber);

            //MakePositive(ref negativeNumber);

            //Console.WriteLine(negativeNumber+100);

            //SumWithHundred(ref negativeNumber);

            int[] numbers = new int[5] { 1, 2, 3, 4, 5 };

            ResizeArray(ref numbers, 95);
            ResizeArray(ref numbers, 96);
            Console.WriteLine("===================");
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }

        }

        static void ResizeArray(ref int[] numbers , int num) 
        {
            int[] newArray = new int[numbers.Length+1];
            
            for (int i = 0; i < numbers.Length; i++)
            {
                newArray[i] = numbers[i];
            }
            newArray[^1] = num;

            numbers = newArray;
        }

        static void CheckValue(string value)
        {
            if(int.TryParse(value,out int result))
            {
                Console.WriteLine($"{result} Numberdir");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }

        static void MakeNumberHundred(out int b)
        {
            b = 100;
            Console.WriteLine(b);
        }

        static int MakePositive(ref int number)
        {
            if (number < 0) number *= -1;

            return number;
        }

        static void SumWithHundred(ref int number)
        {
            Console.WriteLine(number+100);
        }
    }
}
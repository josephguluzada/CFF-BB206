using System.Net.Http.Headers;

namespace DelegatesContinue
{
    internal class Program
    {
        delegate void Show(string message1, string message2);
        delegate double Doubler(double parameter);
        static void Main(string[] args)
        {
            Doubler doubler = Test;

            Console.WriteLine(doubler(99.7));
            Console.WriteLine(doubler.Invoke(88.8));

            //Show show = ShowMessage;

            //show("Salam", "BB206");
            //show.Invoke("Salam", "Elmar");

            List<int> numbers = new List<int>() { 1,2,3,4,5,67,88};


            Func<string, string, bool> func;
            func = delegate (string str1,string str2) 
            {
                Console.WriteLine(str1);
                return true; 
            };
            func = (string word1, string word2) => true;

            
            TestMethod(9, func);

            TestMethod2(4, 33, (x,y) => (x*14) > y);

            Action<string, string> action = ShowMessage;
            action = delegate (string message1, string message2) { Console.WriteLine(message1 + " " + message2); };

            action = (string word1, string word2) => { Console.WriteLine("Salam" + word1 + " " + word2); };

            action.Invoke("BB206", "Test");

            Predicate<string> predicate = Test3;
            predicate = delegate (string num) { return true; };

            predicate = (string word1) => word1.Length >5;


            List<string> names = new List<string>() { "Yusif", "Elvin", "Esneme", "Elshen", "ByElvin"};

            names.RemoveAll(x => x.Length <= 6);
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            //for (int i = 0; i < names.Count; i++)
            //{
            //    if (names[i].Length > 5)
            //    {
            //        names.Remove(names[i]);
            //    }
            //}

        }

        static bool CheckNameLength(string name)
        {
            return name.Length >= 5;
        }


        static double Test(double parameter)
        {
            return parameter;
        }

        static void ShowMessage(string message1, string word2) 
        {
            Console.WriteLine(message1 + " " + word2);
        }

        static bool CompareInts(int num1, int num2)
        {
            return num1 >= num2;
        }

        static bool Test3(string salam)
        {
            return true;
        }

        static void TestMethod(int num1,Func<string, string, bool> method)
        {
            Console.WriteLine("isledi");
        }

        static void TestMethod2(int Tenzile, int Ulker,Func<int, int, bool> func)
        {
            if(func(Tenzile,Ulker))
            {
                Console.WriteLine("Boyukdur");
            }
            else
            {
                Console.WriteLine("Kicikdir");
            }
        }


    }
}
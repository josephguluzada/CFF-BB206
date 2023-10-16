namespace Tuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (int , int ,int) tuple = (5, 19, 20);

            (int, int, double) tuple2 = tuple;
            Console.WriteLine(tuple2.Item1 + " " + tuple2.Item2);

            int[] numbers = {1,2,3,4,5,6,7};

            (int first, int last) filteredTuple= FilterFirstLast(numbers);

            Console.WriteLine(filteredTuple.first + " " + filteredTuple.last);
        }

        static (int,int) FilterFirstLast(int[] ints)
        {
            int firstElement = ints[0];
            int lastElement = ints[^1];

            return (firstElement, lastElement);
        }
    }
}
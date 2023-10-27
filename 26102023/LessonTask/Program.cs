using System.Threading.Channels;

namespace LessonTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task.Run(() =>
            //{
            //    Console.WriteLine("Task run oldu");

            //});
            //Console.ReadLine();



            //while (task.IsCompleted == false)
            //{
            //    Console.WriteLine("Loading...");
            //}

            //Console.WriteLine("Finished!");


            ShowGoogleSourceCode().ContinueWith(x => Console.WriteLine(x.Result));

            for (int i = 0; i < 10000; i++)
            {
                Console.WriteLine("Salam"); 
            }

            Console.ReadLine();
        }

        static Task<string> GetSource()
        {
            HttpClient client = new HttpClient();

            var task = Task.Run(() =>
            {
                return client.GetStringAsync("https://google.com");
            });

            return task;
        }


        static async Task<string> ShowGoogleSourceCode()
        {
            HttpClient httpClient = new HttpClient();

            var task = await httpClient.GetStringAsync("https://google.com");

            return task;
        }
    }
}
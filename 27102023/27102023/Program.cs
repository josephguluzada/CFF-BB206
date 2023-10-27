namespace _27102023
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //var a = Task.Run(() =>
            //{
            //    Thread.Sleep(1000);
            //    return "Salam, BB206";
            //});
            //Console.WriteLine(a.Result);

            var a = GetStringSouce();

            while (!a.IsCompleted)
            {
                Console.WriteLine("Loading..");
            }
            Console.WriteLine("Finished!");

            Console.WriteLine("Salam, BB206");
            Console.WriteLine("Salam, BB205");
            Console.WriteLine("Salam, BB204");

            Console.ReadLine();
        }

        public static string GetString()
        {
            HttpClient client = new HttpClient();

            return client.GetStringAsync("https://www.google.com").Result;
        }

        public static async Task<string> GetStringSouce()
        {
            HttpClient client = new HttpClient();

            return await client.GetStringAsync("https://www.google.com");
        }
    }
}
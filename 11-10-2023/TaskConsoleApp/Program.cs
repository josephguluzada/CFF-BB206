using TaskClassLibrary;

namespace TaskConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker worker1 = new Worker("Elsever","Asadov",3);
            Worker worker2 = new Worker("Ilham","Valiyev",2);


            Department department = new Department();
            department.Name = "Code LLC";

            department.AddWorker(worker1);
            department.AddWorker(worker2);

            department.ShowAllWorkers();

            Worker wantedWorker = department.SearchWorker("lham"); // => null.ShowAllInfo()
            wantedWorker?.ShowAllInfo();

            bool check = 5>0;

            //if(check == true)
            //{
            //    Console.WriteLine("True yazilib");
            //}
            //else
            //{
            //    Console.WriteLine("False yazilib");
            //}
            Console.WriteLine(check ? "duz yazilib" : "sehv yazilib"); 


            //if(wantedWorker != null)
            //{
            //    wantedWorker.ShowAllInfo();
            //}
            //else
            //{
            //    Console.WriteLine("Bele bir isci yoxdur!");
            //}
        }
    }
}
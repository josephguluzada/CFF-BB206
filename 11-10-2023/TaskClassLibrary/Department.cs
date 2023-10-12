using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskClassLibrary
{
    public class Department
    {
        public string Name { get; set; }
        public Worker[] Workers;

        public Department()
        {
            Workers = Array.Empty<Worker>();
        }

        public void AddWorker(Worker worker)
        {
            Array.Resize(ref Workers, Workers.Length+1);
            Workers[^1] = worker; 
        }

        public Worker SearchWorker(string name)
        {
            for (int i = 0; i < Workers.Length; i++)
            {
                if (Workers[i].Name.ToLower() == name.ToLower())
                {
                    return Workers[i];
                }
            }

            return null;
        }

        public void ShowAllWorkers()
        {
            foreach (Worker worker in Workers)
            {
                Console.WriteLine($"Fullname: {worker.Name} {worker.Surname} WorkerCode: {worker.WorkerCode} ");
            }
        }

    }
}

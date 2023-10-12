using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Models
{
    public class Book : Product
    {
        public string Genre { get; set; }

        public Book(int no ,string name, string genre, double price)
        {
            this.No = no;
            this.Name = name;
            this.Genre = genre;
            this.Price = price;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"No: {this.No} Genre: {this.Genre} Price: {this.Price} Name: {this.Name}");
        }
    }
}

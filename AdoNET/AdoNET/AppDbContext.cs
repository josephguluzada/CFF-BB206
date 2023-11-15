using AdoNET.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNET
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=CATALYST\\SQLEXPRESS;Database=EFCOREBB206;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Student> Students { get; set; }
    }
}

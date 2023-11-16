using FTB.Models;
using Microsoft.EntityFrameworkCore;

namespace FTB
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Slider> Sliders { get; set; }
    }
}

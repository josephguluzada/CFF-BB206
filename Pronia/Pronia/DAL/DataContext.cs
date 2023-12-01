using Microsoft.EntityFrameworkCore;
using Pronia.Models;

namespace Pronia.DAL;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    public DbSet<Slider> Sliders { get; set; }
}

using Microsoft.EntityFrameworkCore;
using Pustok.Models;

namespace Pustok.DAL;

public class PustokContext : DbContext
{
    public PustokContext(DbContextOptions<PustokContext> options) : base(options){}

    public DbSet<Slider> Sliders { get; set; }
}

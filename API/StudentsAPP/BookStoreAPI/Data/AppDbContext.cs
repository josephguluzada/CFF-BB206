using BookStoreAPI.Configurations;
using BookStoreAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookStoreAPI.Data
{
	public class AppDbContext : DbContext
	{
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			//modelBuilder.ApplyConfiguration(new BookConfiguration());
			//modelBuilder.ApplyConfiguration(new CategoryConfiguration());
			modelBuilder.ApplyConfigurationsFromAssembly(typeof(BookConfiguration).Assembly);

			base.OnModelCreating(modelBuilder);
		}
	}
}

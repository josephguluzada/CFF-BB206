using AuthorBook.Configurations;
using AuthorBook.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuthorBook.Data
{
	public class AppDbContext : DbContext
	{
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(typeof(BookConfiguration).Assembly);
			base.OnModelCreating(modelBuilder);
		}
	}
}

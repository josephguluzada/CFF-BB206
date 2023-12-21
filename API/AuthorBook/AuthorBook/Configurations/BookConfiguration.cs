using AuthorBook.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AuthorBook.Configurations
{
	public class BookConfiguration : IEntityTypeConfiguration<Book>
	{
		public void Configure(EntityTypeBuilder<Book> builder)
		{
			builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
			builder.Property(x => x.SalePrice).IsRequired().HasColumnType("decimal(18,2)");
			builder.Property(x => x.CostPrice).IsRequired().HasColumnType("decimal(18,2)");
			builder.HasOne(x => x.Author)
					.WithMany(x => x.Books)
					.HasForeignKey(x => x.AuthorId)
					.OnDelete(DeleteBehavior.NoAction);
		}
	}
}

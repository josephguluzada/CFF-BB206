using BookStoreAPI.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStoreAPI.Configurations
{
	public class BookConfiguration : IEntityTypeConfiguration<Book>
	{
		public void Configure(EntityTypeBuilder<Book> builder)
		{
			builder.Property(x => x.Name)
					.IsRequired()
					.HasMaxLength(200);
			builder.Property(x=>x.CostPrice)
					.IsRequired()
					.HasColumnType("decimal(18,2)");
			builder.Property(x => x.Price)
					.IsRequired()
					.HasColumnType("decimal(18,2)");

			builder.HasOne(x => x.Category)
					.WithMany(x => x.Books);
		}
	}
}

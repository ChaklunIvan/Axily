using Axily.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Axily.Infrastructure.Configurations
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products")
                .HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .IsRequired();

            builder.Property(p => p.Name)
                .HasMaxLength(40)
                .IsRequired();

            builder.Property(p => p.Description)
                .HasMaxLength(400);

            builder.Property(p => p.Price)
                .HasPrecision(7, 2);

            builder.HasOne(p => p.Category)
                .WithMany(c => c.Products);
        }
    }
}

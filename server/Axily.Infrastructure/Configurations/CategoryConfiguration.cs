using Axily.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Axily.Infrastructure.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category")
                .HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .IsRequired();

            builder.Property(c => c.Name)
                .HasMaxLength(32);

            builder.HasIndex(c => c.Name)
                .IsUnique();

            builder.HasMany(c => c.Products)
                .WithOne(p => p.Category);
        }
    }
}

using Ambev.DeveloperEvaluation.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ambev.DeveloperEvaluation.ORM.Mapping;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("Products");

        builder.HasKey(u => u.Id);
        builder.Property(u => u.Id)
            .UseIdentityAlwaysColumn();

        builder.Property(u => u.Title).IsRequired().HasMaxLength(100);
        builder.Property(u => u.Price)
            .IsRequired()
            .HasColumnType("decimal(10,2)");

        builder.Property(u => u.Description)
            .IsRequired()
            .HasMaxLength(1000);

        builder.Property(u => u.Image)
            .IsRequired()
            .HasColumnType("bytea"); ;

        builder.Property(p => p.Category)
          .IsRequired()
          .HasMaxLength(50);

        builder.OwnsOne(p => p.Rating, r =>
        {
            r.Property(rate => rate.Rate)
                .HasColumnName("Rate")
                .IsRequired()
                .HasMaxLength(10);

            r.Property(rate => rate.Count)
                .HasColumnName("Count")
                .IsRequired()
                .HasMaxLength(10);
        });

        builder.Property(p => p.Status)
        .HasConversion<string>()
        .HasMaxLength(20);

        builder.Property(p => p.CreatedAt)
           .HasDefaultValueSql("NOW()")
           .ValueGeneratedOnAdd();

        builder.Property(p => p.UpdatedAt)
            .ValueGeneratedOnUpdate();

    }
}

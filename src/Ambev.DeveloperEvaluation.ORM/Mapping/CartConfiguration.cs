using Ambev.DeveloperEvaluation.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ambev.DeveloperEvaluation.ORM.Mapping;

public class CartConfiguration : IEntityTypeConfiguration<Cart>
{
    public void Configure(EntityTypeBuilder<Cart> builder)
    {
        builder.ToTable("Carts");

        builder.HasKey(c => c.Id);

        builder.Property(c => c.Date)
            .IsRequired();

        builder.Property(c => c.UserId).IsRequired();
    }
}

public class CartProductConfiguration : IEntityTypeConfiguration<CartProducts>
{
    public void Configure(EntityTypeBuilder<CartProducts> builder)
    {
        builder.ToTable("CartProducts");

        builder.HasKey(cp => cp.Id);

        builder.Property(cp => cp.Quantity)
            .IsRequired();

        builder.Property(cp => cp.ProductId).IsRequired();

        builder.HasOne(cp => cp.Cart)
            .WithMany(c => c.CartProducts)
            .HasForeignKey(cp => cp.CartId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(cp => cp.Product)
            .WithMany()
            .HasForeignKey(cp => cp.ProductId);
    }
}

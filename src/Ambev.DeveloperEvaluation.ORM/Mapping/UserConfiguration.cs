using Ambev.DeveloperEvaluation.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ambev.DeveloperEvaluation.ORM.Mapping;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("Users");

        builder.HasKey(u => u.Id);
        builder.Property(u => u.Id).HasColumnType("uuid").HasDefaultValueSql("gen_random_uuid()");

        builder.Property(u => u.Username).IsRequired().HasMaxLength(50);
        builder.Property(u => u.Password).IsRequired().HasMaxLength(100);

        builder.OwnsOne(u => u.Name, n =>
        {
            n.Property(p => p.FirstName).HasColumnName("FirstName")
             .IsRequired()
             .HasMaxLength(50);

            n.Property(p => p.LastName).HasColumnName("LastName")
             .IsRequired().HasMaxLength(100);
        });

        builder.OwnsOne(u => u.Address, n =>
        {
            n.Property(p => p.City).HasColumnName("City")
            .IsRequired().HasMaxLength(100);

            n.Property(p => p.Street).HasColumnName("Street").IsRequired();
            n.Property(p => p.Number).HasColumnName("Number").IsRequired();
            n.Property(p => p.ZipCode).HasColumnName("ZipCode").IsRequired();


            n.OwnsOne(u => u.Geolocation, n =>
            {
                n.Property(p => p.Lat).HasColumnName("Lat").IsRequired();
                n.Property(p => p.Long).HasColumnName("Long").IsRequired();
            });
        });

        builder.Property(u => u.Email).IsRequired().HasMaxLength(100);
        builder.Property(u => u.Phone).HasMaxLength(20);

        builder.Property(u => u.Status)
            .HasConversion<string>()
            .HasMaxLength(20);

        builder.Property(u => u.Role)
            .HasConversion<string>()
            .HasMaxLength(20);

        builder.Property(u => u.CreatedAt)
            .HasDefaultValueSql("NOW()")
            .ValueGeneratedOnAdd();

        builder.Property(u => u.UpdatedAt)
            .HasColumnName("UpdatedAt")
            .ValueGeneratedOnUpdate();

    }
}

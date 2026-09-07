using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GymManagment.DAL.Models;

namespace GymManagment.DAL.DbContexts.Configuration
{
    public class GymUserConfigurations<T> : IEntityTypeConfiguration<T> where T : GymUser
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(X=>X.Name)
                .HasColumnType("varchar")
                .HasMaxLength(50);
            builder.Property(X => X.Email)
                .HasColumnType("varchar")
                .HasMaxLength(100);
            builder.HasIndex(X => X.Email)
                .IsUnique();
            builder.HasIndex(X => X.Phone)
                .IsUnique();

            builder.ToTable(tb =>
            {
                tb.HasCheckConstraint("EmailCheck", "Email LIKE '_%@_%._%'");
                tb.HasCheckConstraint("PhoneCheck", "Phone LIKE '010%'or Phone LIKE '011%'or Phone LIKE '012%' or Phone LIKE '015%' ");

            });

            builder.OwnsOne(X => X.Address, address =>
            {
                address.Property(X => X.Street)
                        .HasColumnName("Street")
                        .HasColumnType("varchar")
                        .HasMaxLength(30);
                address.Property(X => X.City)
                        .HasColumnName("City")
                        .HasColumnType("varchar")
                        .HasMaxLength(30);

            });
        }
    }
}

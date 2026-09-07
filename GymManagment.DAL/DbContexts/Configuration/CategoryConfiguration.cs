using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymManagment.DAL.DbContexts.Configuration
{
    internal class CategoryConfiguration :IEntityTypeConfiguration<Models.Category>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Models.Category> builder)
        {

            builder.Property(c => c.CategoryName)
                   .HasColumnType("Varchar")
                   .HasMaxLength(20);
            builder.Property(x => x.CreatedAt)
                   
                   .HasDefaultValueSql("getdate()");

            builder.HasData(
                new Models.Category { Id = 1, CategoryName = "Cardio" },
                new Models.Category { Id = 2, CategoryName = "Strength" },
                new Models.Category { Id = 3, CategoryName = "Boxing" },
                new Models.Category { Id = 4, CategoryName = "Yoga" },
                new Models.Category { Id = 5, CategoryName = "CrossFit" }
            );
        }
    }
}

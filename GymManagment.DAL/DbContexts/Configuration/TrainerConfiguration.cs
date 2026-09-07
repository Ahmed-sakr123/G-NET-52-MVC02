using GymManagment.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagment.DAL.DbContexts.Configuration
{
    public class TrainerConfiguration : GymUserConfigurations<Trainer>, IEntityTypeConfiguration<Trainer>
    {
        public new void Configure(EntityTypeBuilder<Trainer> builder)
        {

            builder.Property(t => t.CreatedAt)
                .HasColumnName("HireDate")
                .HasDefaultValueSql("GETDATE()");
            base.Configure(builder);

        }
    }
}

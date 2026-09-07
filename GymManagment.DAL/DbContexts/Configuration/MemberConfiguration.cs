using GymManagment.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagment.DAL.DbContexts.Configuration
{
    public class MemberConfiguration : GymUserConfigurations<Member>, IEntityTypeConfiguration<Member>
    {
        public new void Configure(EntityTypeBuilder<Member> builder)
        {

            builder.Property(X => X.CreatedAt)
                 .HasColumnName("JoinDate")
                 .HasDefaultValueSql("Getdate()");

            base.Configure(builder); // Call the base class Configure method to apply common configurations
        }
    }
}


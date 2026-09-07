using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GymManagment.DAL.Models;

namespace GymManagment.DAL.DbContexts.Configuration
{
    public class SessionConfiguration : IEntityTypeConfiguration<Models.Session>
    {
        public void Configure(EntityTypeBuilder<Models.Session> builder)
        {
            builder.ToTable(tb =>
            {
                tb.HasCheckConstraint(
                    "SessionCapacityCheck",
                    "Capacity BETWEEN 1 AND 25");

                tb.HasCheckConstraint(
                    "SessionEndDateCheck",
                    "EndDate > StartDate");
            });
        }
    }
}
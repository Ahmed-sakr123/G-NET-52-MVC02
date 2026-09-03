using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace GymManagment.DbContexts.Configuration
{
    public class PlanConfiguration: IEntityTypeConfiguration<Models.Plan>
    {
       public void Configure(EntityTypeBuilder<Models.Plan> builder)
        {
            builder.Property(X => X.Name)
                 .HasColumnType("varchar")
                 .HasMaxLength(50);
            builder.Property(X => X.Description)
                .HasMaxLength(200);
            builder.Property(X => X.Price)
                .HasPrecision(10, 2);

            builder.Property(X => X.CreatedAt)
                .HasDefaultValueSql("GETDATE()");// Set default value to current date and time


            // CHECK CONSTRAINT: DurationDays must be between 1 and 365
            builder.ToTable(Tb =>
            {
                Tb.HasCheckConstraint("PlanDurationCheck", "DurationDays Between 1 And 365");
                
                
                
            });
        }
    }
}

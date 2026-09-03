using Microsoft.EntityFrameworkCore;
namespace GymManagment.DbContexts
{
    public class GymDbContext :DbContext
    {
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-GQ69MJF\\MSSQL;Database=GymSystem;Trusted_Connection=True;TrustServerCertificate=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Models.Plan>(new Configuration.PlanConfiguration());
        }

        public DbSet<Models.Plan> Plans { get; set; } 
    }
}

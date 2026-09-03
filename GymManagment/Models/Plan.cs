namespace GymManagment.Models
{
    public class Plan
    {
        // BY CONVENTION, EF CORE WILL CONSIDER THE PROPERTY NAMED "Id" AS THE PRIMARY KEY OF THE ENTITY.
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public decimal Price { get; set; }
        public int DurationDays { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        /*
        1) create plan model with the following properties:
        2) install package Microsoft.EntityFrameworkCore
        3)create DbContext class and add DbSet<Plan> Plans { get; set; }


         
         
         */

    }
}

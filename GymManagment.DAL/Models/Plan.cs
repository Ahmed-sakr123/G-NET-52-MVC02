namespace GymManagment.DAL.Models

{
    public class Plan : BaseEntity
    {
        // BY CONVENTION, EF CORE WILL CONSIDER THE PROPERTY NAMED "Id" AS THE PRIMARY KEY OF THE ENTITY.
       
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public decimal Price { get; set; }
        public int DurationDays { get; set; }
        public bool IsActive { get; set; }
       
       

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace GymManagment.DAL.Models
{
    public class HealthRecord : BaseEntity
    {
        public decimal Hight { get; set; }
        public decimal Weight { get; set; }
        public string? Note { get; set; }
        public string BloodType { get; set; }

        // lastupdate == updatedAt ==>fluntApi
    }
}

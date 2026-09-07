using GymManagment.DAL.DbContexts;
using GymManagment.DAL.Models;
using GymManagment.DAL.Repositiories.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace GymManagment.DAL.Repositiories.Classes
{
    public class PlanRepository :IPlanRepository
    {

        // concacte data base context

        private readonly GymDbContext dbcontext;

        public PlanRepository(GymDbContext _dbContext)
        {
            dbcontext = _dbContext; // Hard coded connection string, consider using dependency injection and configuration
        }
        public Task<int> AddAsync(Plan plan, CancellationToken ct = default)
        {
           dbcontext.Plans.Add(plan); // Add the plan to the DbSet The Memory representation of the entity set
            return dbcontext.SaveChangesAsync(ct); // Save changes to the database asynchronously
        }
         
        public Task<int> DeleteAsync(Plan plan, CancellationToken ct = default)
        {
            dbcontext.Plans.Remove(plan);
            return dbcontext.SaveChangesAsync(ct);

        }
        public async Task<IEnumerable<Plan>> GetAllAsync(bool tracking = false, CancellationToken ct = default)
        {
            //if(tracking)
            //    return await dbcontext.Plans.ToListAsync(ct); // Return all plans with tracking enabled
            //else
            //    return await dbcontext.Plans.AsNoTracking().ToListAsync(ct); // Return all plans without tracking

            IQueryable<Plan> query = tracking ? dbcontext.Plans : dbcontext.Plans.AsNoTracking();// From Database context, get the plans based on tracking option
            return await query.ToListAsync(ct); // Return all plans based on tracking option
        }
        public async Task<Plan?> GetByIdAsync(int id, CancellationToken ct = default)
        {
         return await dbcontext.Plans.FindAsync(id, ct); // Find the plan by id asynchronously
           
        }

        public Task<int> UpdateAsync(Plan plan, CancellationToken ct = default)
        {
            dbcontext.Plans.Update(plan); // Update the plan in the DbSet The Memory representation of the entity set
            return dbcontext.SaveChangesAsync(ct); // Save changes to the database asynchronously
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace GymManagment.DAL.Repositiories.Interface
{
    public interface IPlanRepository
    {
        // Get all plans , Get plan by id, Add plan, Update plan, Delete plan

        // Get all plans
        Task< IEnumerable<Models.Plan>> GetAllAsync(bool tracking = false , CancellationToken ct=default);
        // Get plan by id
        Task<Models.Plan?> GetByIdAsync(int id, CancellationToken ct = default);

        // Add plan
        Task<int> AddAsync(Models.Plan plan, CancellationToken ct = default);

        // Update plan
        Task<int> UpdateAsync(Models.Plan plan, CancellationToken ct = default);
        
        Task<int> DeleteAsync(Models.Plan plan, CancellationToken ct = default);
    }

}

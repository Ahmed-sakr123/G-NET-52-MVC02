using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GymManagment.Controllers
{
    public class PlanController : Controller
    {
        //conect to the database using GymDbContext

        private readonly DbContexts.GymDbContext dbcontext;
        public PlanController() 
        {
            dbcontext = new DbContexts.GymDbContext();
        }
        // GET: Plan
        // Get all plans from the database and return to the view use async and await
        public async Task<IActionResult> Index()
        {
            var plans = await dbcontext.Plans.ToListAsync();
            return View(plans);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var plan = await dbcontext.Plans.FindAsync(id);
            if(plan == null)
                 return RedirectToAction(nameof(Index));
            else
                 return View(plan);

        }
    }
}

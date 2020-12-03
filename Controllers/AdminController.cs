using CleanTrack.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CleanTrack.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {

            using (var context = new AdminContext())
            {
                var CleaningSessions = context.Sessions
                        .Include(cleaningsession => cleaningsession.FinishedTasks);
            }

            return View();
        }
    }
}

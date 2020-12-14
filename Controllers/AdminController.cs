using SqueakyClean.Data;
using SqueakyClean.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace SqueakyClean.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            using (var context = new AdminContext())
            {
                var CleaningSessions = context.Sessions
                    .Include(session => session.SessionTasks)
                    .ThenInclude(sessionTask => sessionTask.Task)
                    .ToList();



                return View(new AdminModel() { SessionList = CleaningSessions });
            }
        }
    }
}

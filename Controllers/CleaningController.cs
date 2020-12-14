using System;
using System.Linq;
using SqueakyClean.Data;
using SqueakyClean.Models;
using Microsoft.AspNetCore.Mvc;
using static SqueakyClean.Data.AdminContext;

namespace SqueakyClean.Controllers
{
    public class CleaningController : Controller
    {
        public IActionResult Index()
        {
            var data = new CleaningModel();

            return View(data);
        }

        public IActionResult StartCleaning(CleaningModel data)
        {
            data.StartTime = DateTime.Now;
            
            // data.StartTime = DateTime.ParseExact(startTime, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            return View("Index", data);
        }

        public IActionResult EndCleaning(CleaningModel data)
        {
            data.EndTime = DateTime.Now;
            var finishedCleaningModel = new FinishedCleaningModel();
            if (data != null)
            {
                var totalTime = data.EndTime.Subtract(data.StartTime);

                finishedCleaningModel.TotalTime = totalTime.Hours + ":" + totalTime.Minutes + ":" + totalTime.Seconds;
            }

            finishedCleaningModel.FinishedTasks = data.FinishedTasks;

            // TODO: Put in database

            using (var context = new AdminContext())
            {
                var sess = new CleaningSession() { EndTime = data.EndTime, StartTime = data.StartTime };
                context.Sessions.AddRange(sess);
                foreach (var task in data.FinishedTasks)
                {
                    var id = context.Tasks.Select(t => t).Where(t => t.Name == task).ToList()[0];
                    context.SessionTasks.AddRange(new SessionTask() {  Session = sess, Task = id });
                }

                context.SaveChanges();
            }

                return View("CleaningDone", finishedCleaningModel);
        }

        public IActionResult FinishTask(string taskName)
        {

            return View("Index");
        }
    }
}

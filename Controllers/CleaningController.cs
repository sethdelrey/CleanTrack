using System;
using CleanTrack.Models;
using Microsoft.AspNetCore.Mvc;

namespace CleanTrack.Controllers
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

            return View("CleaningDone", finishedCleaningModel);
        }

        public IActionResult FinishTask(string taskName)
        {

            return View("Index");
        }
    }
}

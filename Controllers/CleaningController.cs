using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
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

        public IActionResult StartCleaning()
        {
            CleaningModel data = new CleaningModel
            {
                StartTime = DateTime.Now
            };
            // data.StartTime = DateTime.ParseExact(startTime, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);


            return View("Index", data);
        }

        public IActionResult EndCleaning(CleaningModel data)
        {


            return View("CleaningDone", data);
        }
    }
}

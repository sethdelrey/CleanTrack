using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SqueakyClean.Models
{
    public class FinishedCleaningModel
    {
        public string TotalTime { get; set; }

        public IList<string> FinishedTasks { get; set; }

    }
}

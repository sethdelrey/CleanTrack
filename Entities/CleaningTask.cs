using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static SqueakyClean.Data.AdminContext;

namespace SqueakyClean.Entities
{
    public class CleaningTask
    {

        public int TaskId { get; set; }
        public string Name { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public bool IsDone { get; set; }

        public bool IsInDoubleClean { get; set; }


        public List<SessionTask> SessionTasks { get; set; }
    }
}
 
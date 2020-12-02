using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanTrack.Entities
{
    public class Task
    {
        public string Name { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public string Description { get; set; }
    }
}
 
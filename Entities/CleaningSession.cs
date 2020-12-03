using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CleanTrack.Entities
{
    public class CleaningSession
    {
        [Key]
        public int CleaningId { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime StartTime { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime EndTime { get; set; }

        public bool IsBigMop { get; set; }

        public List<CleaningTask> FinishedTasks { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using static CleanTrack.Data.AdminContext;

namespace CleanTrack.Entities
{
    public class CleaningSession
    {
        public int CleaningId { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime StartTime { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime EndTime { get; set; }

        public bool IsBigMop { get; set; }


        public List<SessionTask> SessionTasks { get; set; }
    }
}

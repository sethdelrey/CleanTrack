using SqueakyClean.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SqueakyClean.Models
{
    public class CleaningModel
    {
        [Required]
        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public bool IsDoubleClean { get; set; }

        public IList<string> FinishedTasks { get; set; }

        public List<CleaningTask> Tasks = new List<CleaningTask> { 
            new CleaningTask() {Name = "Take Out Trash", IsInDoubleClean = true}, 
            new CleaningTask() { Name = "Dust Mop", IsInDoubleClean = true }, 
            new CleaningTask() { Name = "Vacuum", IsInDoubleClean = true },
            new CleaningTask() { Name = "Mop", IsInDoubleClean = true },
            new CleaningTask() { Name = "Clean Kitchens", IsInDoubleClean = false },
            new CleaningTask() { Name = "Clean Bathrooms", IsInDoubleClean = false },
            new CleaningTask() { Name = "Dust", IsInDoubleClean = false },
            new CleaningTask() { Name = "Wash Dishes", IsInDoubleClean = false },
            new CleaningTask() { Name = "Clean Windows", IsInDoubleClean = true }
        };

    }
}

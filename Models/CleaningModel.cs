using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CleanTrack.Models
{
    public class CleaningModel
    {
        [Required]
        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        //public bool IsBigMop { get; set; }

        public List<Task> Tasks { get; set; }

        /*public List<string> DoublesTasks = new List<string> { "Take Out Trash", "Dush Mop", "Vacuum", "Mop" };

        public List<string> SinglesTasks = new List<string> { "Take Out Trash", "Dush Mop", "Vacuum", "Mop", "Clean Kitchens", "Clean Bathrooms", "Dust", "Wash Dishes", "Clean Windows", "" };*/
    }
}

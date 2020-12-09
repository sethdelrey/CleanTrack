using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static CleanTrack.Data.AdminContext;

namespace CleanTrack.Models
{
    public class AdminModel
    {

        public List<CleaningSession> SessionList { get; set; }
    }
}

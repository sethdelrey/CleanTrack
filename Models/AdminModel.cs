using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static SqueakyClean.Data.AdminContext;

namespace SqueakyClean.Models
{
    public class AdminModel
    {

        public List<CleaningSession> SessionList { get; set; }
    }
}

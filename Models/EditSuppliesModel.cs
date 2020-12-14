using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SqueakyClean.Models
{
    public class EditSuppliesModel
    {
        public List<string> NeededSupplies { get; set; }
        public List<SelectListItem> AllSupplies { get; set; }

        public EditSuppliesModel()
        {
            NeededSupplies = new List<string>();
            AllSupplies = new List<SelectListItem>();

        }

    }
}

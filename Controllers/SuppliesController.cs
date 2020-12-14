using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SqueakyClean.Data;
using SqueakyClean.Entities;
using SqueakyClean.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SqueakyClean.Controllers
{
    public class SuppliesController : Controller
    {
        public IActionResult Index()
        {
            using var context = new SuppliesContext();
            var data = new SuppliesModel
            {
                Supplies = context.Supplies.Select(s => s).Where(s => s.OutOf == true).ToList()
            };

            return View(data);

        }

        public IActionResult EditList()
        {
            using var context = new SuppliesContext();
            var supplies = context.Supplies.ToList();

            var data = new EditSuppliesModel
            {
                AllSupplies = GetSupplies(supplies),
                NeededSupplies = GetNeededSupplies(supplies)
            };

            return View(data);
        }
        
        [HttpPost]
        public IActionResult EditList(EditSuppliesModel data)
        {

            using var context = new SuppliesContext();

            var supplies = context.Supplies;

            if (supplies != null)
            {
                foreach (var item in supplies)
                {
                    if (data.NeededSupplies.Contains(item.Name)) {
                        item.OutOf = true;
                    }
                    else
                    {
                        item.OutOf = false;
                    }
                    
                }
            }

            context.SaveChanges();

            var suppliesModel = new SuppliesModel
            {
                Supplies = supplies.Select(s => s).Where(s => s.OutOf == true).ToList()
            };

            return View("Index", suppliesModel);
        }

        private List<SelectListItem> GetSupplies(List<SupplyItem> supplies)
        {
            var sli = new List<SelectListItem>();

            foreach (var item in supplies)
            {
                sli.Add(new SelectListItem { Text = item.Name, Value = item.Name});
            }

            return sli;
        }

        private List<string> GetNeededSupplies(List<SupplyItem> supplyItems)
        {
            var neededSupplies = new List<string>();

            foreach (var item in supplyItems)
            {
                if (item.OutOf)
                {
                    neededSupplies.Add(item.Name);
                }
            }

            return neededSupplies;
        }

    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hackville2022.Controllers
{
    public class ResourcesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GovernmentResources()
        {
            return View("GovernmentResources");
        }

        public IActionResult ClothingResources()
        {
            return View("ClothingResources");
        }

        public IActionResult HealthResources()
        {
            return View("HealthResources");
        }

        public IActionResult PrintingResources()
        {
            return View("PrintingResources");
        }

        public IActionResult TriftShopMap()
        {
            return View("TriftShopMap");
        }

        public IActionResult HealthMap()
        {
            return View("HealthMap");
        }
    }
}

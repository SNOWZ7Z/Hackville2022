using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hackville2022.Controllers
{
    public class saveOnFood : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult saveonfood()
        {
            return View("saveonfood");
        }

        public IActionResult sfRecipes()
        {
            return View("sfRecipes");
        }

    }
}

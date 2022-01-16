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
            return View("Index");
        }

        public IActionResult saveonfood()
        {
            return View("saveonfood");
        }

        public IActionResult sfRecipes()
        {
            return View("sfRecipes");
        }

        public IActionResult sfDir()
        {
            return View("sfDir");
        }
    }
}

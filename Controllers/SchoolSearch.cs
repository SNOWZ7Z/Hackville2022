using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hackville2022.Controllers
{
    public class SchoolSearch : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

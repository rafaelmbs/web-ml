using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace web_ml.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Items(string search)
        {
            ViewData["search"] = search;

            return View();
        }

        public ActionResult Item(string id)
        {
            ViewData["id"] = id;

            return View();
        }
    }
}

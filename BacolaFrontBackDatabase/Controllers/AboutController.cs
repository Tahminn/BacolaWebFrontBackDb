using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BacolaFrontBackDatabase.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {            
            ViewBag.Title = "About";
            ViewBag.Javascript = "about";            
            return View();
        }
    }
}

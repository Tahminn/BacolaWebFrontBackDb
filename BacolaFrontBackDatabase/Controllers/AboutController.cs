using Microsoft.AspNetCore.Mvc;

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

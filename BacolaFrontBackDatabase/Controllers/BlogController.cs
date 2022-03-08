using Microsoft.AspNetCore.Mvc;

namespace BacolaFrontBackDatabase.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Blog";
            ViewBag.Javascript = "blog";
            return View();
        }
    }
}

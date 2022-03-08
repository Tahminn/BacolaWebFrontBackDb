using Microsoft.AspNetCore.Mvc;

namespace BacolaFrontBackDatabase.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Contact";
            ViewBag.Javascript = "contac";
            return View();
        }
    }
}

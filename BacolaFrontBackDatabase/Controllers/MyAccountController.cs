using Microsoft.AspNetCore.Mvc;

namespace BacolaFrontBackDatabase.Controllers
{
    public class MyAccountController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "My Account";
            ViewBag.Javascript = "my-account";
            return View();
        }
    }
}

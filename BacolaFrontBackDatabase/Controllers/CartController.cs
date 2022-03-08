using Microsoft.AspNetCore.Mvc;

namespace BacolaFrontBackDatabase.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Cart";
            ViewBag.Javascript = "cart";
            return View();
        }
    }
}

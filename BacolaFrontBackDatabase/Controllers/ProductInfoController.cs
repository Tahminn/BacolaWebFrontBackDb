using Microsoft.AspNetCore.Mvc;

namespace BacolaFrontBackDatabase.Controllers
{
    public class ProductInfoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Product Info";
            ViewBag.Javascript = null;
            return View();
        }
    }
}

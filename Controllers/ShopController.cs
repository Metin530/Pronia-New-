using Microsoft.AspNetCore.Mvc;

namespace almaarmudgoz.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Wishlist()
        {
            return View();
        }
    }
}

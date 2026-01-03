using Microsoft.AspNetCore.Mvc;

namespace almaarmudgoz.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

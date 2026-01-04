using Microsoft.EntityFrameworkCore;
using almaarmudgoz.DAL;
using almaarmudgoz.Models;
using almaarmudgoz.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace almaarmudgoz.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

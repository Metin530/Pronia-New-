using almaarmudgoz.DAL;
using almaarmudgoz.Models;
using almaarmudgoz.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Drawing;
using System.Reflection.Metadata;
using almaarmudgoz.Models.Base; 

namespace almaarmudgoz.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        

        public IActionResult Index()
        {

            //            List<Slide> slides = new List<Slide>
            //{
            //                new Slide
            //                {
            //                //Id = 1,
            //                Title = "Bitki 1",
            //                Discount = 30,
            //                Description = "Yaz sezonuna özel %30 indirim fırsatı!",
            //                Image = "1-2-270x300.jpg",
            //                Order = 1
            //                },
            //                new Slide
            //                {
            //                //Id = 2,
            //                Title = "Bitki 2",
            //                Discount = 20,
            //                Description = "Yeni sezon ürünlerde kaçırılmayacak indirim.",
            //                Image = "1-1-270x300.jpg",
            //                Order = 2
            //                },
            //                new Slide
            //                {
            //                //Id = 3,
            //                Title = "Bitki 3",
            //                Discount = 50,
            //                Description = "Seçili ürünlerde %50'ye varan indirimler.",
            //                Image = "1-1-570x633.jpg",
            //                Order = 3
            //                }
            //                };
            List<Product> products = new List<Product>
                {
                new Product
                {
                Name = "Bitki 1 ",
                Price = 67.45m,
               

                },
                new Product
                {
                Name = "Bitki-2",
                Price = 20.00m,
               

                },
                new Product
                {
                Name = "Bitki 3",
                Price = 23.45m,
             

    }
};
            //            List<Blog> blogs = new List<Blog>
            //{
            //                new Blog
            //                {
            //                     Id = 1,
            //                CreatedAt = new DateTime(2025, 12, 17),
            //                Title = "Ev Bitkiləri Baxımı",
            //                Description = "Ev bitkilərinizi sağlam saxlamaq üçün əsas qaydalar.",
            //                ImageUrl = "1-3-270x300.jpg"
            //                },
            //                new Blog
            //                {
            //                Id = 2,
            //                CreatedAt = new DateTime(2025, 11, 30),
            //                Title = "Sukulentlər haqqında Bilməli olduğunuz 5 Fakt",
            //                Description = "Sukulentlərin necə qulluq edilməsi və çoxaldılması haqqında praktiki məsləhətlər.",
            //                ImageUrl = "1-3-370x300.jpg"
            //                },
            //                new Blog
            //                {
            //                Id = 3,
            //                CreatedAt = new DateTime(2025, 10, 15),
            //                Title = "Bağçılıqda Təbii Gübrələr",
            //                Description = "Bitkilər üçün ekoloji təmiz və effektiv gübrələrin istifadəsi.",
            //                ImageUrl = "1-1-310x220.jpg"
            //                }
            //                };
            //_context.Products.AddRange(products);
            //_context.SaveChanges();

            HomeVM homeVM = new HomeVM
            {
                Slides = _context.Sliders.ToList(),
                Products = _context.Products.Include(p=>p.ProductImages).ToList(),
                Blogs = _context.Blogs.ToList() 

            };
            return View(homeVM);


        }
    }
}


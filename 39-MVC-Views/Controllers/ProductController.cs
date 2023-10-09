using _39_MVC_Views.Models;
using Microsoft.AspNetCore.Mvc;

namespace _39_MVC_Views.Controllers
{
    public class ProductController : Controller
    {
        IList<Product> products = new List<Product>()
        {
            new Product { Id=1, Title="Kalem-1", Price=25},
            new Product { Id=2, Title="Kalem-2", Price=35},
            new Product { Id=3, Title="Kalem-3", Price=45},
            new Product { Id=4, Title="Kalem-4", Price=55},
            new Product { Id=5, Title="Kalem-5", Price=60},
            new Product { Id=6, Title="Kalem-6", Price=50}
        };
        public IActionResult Index()
        {
            ViewBag.Subject = "Başlık";
            ViewBag.Products = products;

            ViewData["Subject2"] = "View Data ile getir";
            ViewData["ProductsVD"]= products;
            return View(products);
        }
        public IActionResult Detail(int Id)
        {
            var product = products.FirstOrDefault(x=>x.Id==Id);
            return View(product);
        }
    }
}

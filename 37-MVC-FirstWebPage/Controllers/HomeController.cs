using _37_MVC_FirstWebPage.Models;
using Microsoft.AspNetCore.Mvc;

namespace _37_MVC_FirstWebPage.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //return Content("selam dünya -> ilk mvc kodum");
            Movie movie = new Movie() { Id= 1, Title="The Godfather", RelaseDate=new DateTime(1972, 2, 24) };

            return View(movie);
        }
        public IActionResult Create()
        {
            return Content("Oluşturuldu");
        }
    }
}

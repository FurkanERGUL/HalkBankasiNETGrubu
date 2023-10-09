using _42_MVC_Validation.Classes;
using _42_MVC_Validation.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _42_MVC_Validation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();

        }
        [HttpPost]
        public IActionResult Index(SystemUser systemUser)
        {
            if (ModelState.IsValid)
            {
                return Content("Başarılı");
            }
            else
            {
                return View();
            }
            
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
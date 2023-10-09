using _40_MVC_TempData.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _40_MVC_TempData.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
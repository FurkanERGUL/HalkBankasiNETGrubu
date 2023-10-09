using _42_MVC_VM2_Futbolcu.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _42_MVC_VM2_Futbolcu.Controllers
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
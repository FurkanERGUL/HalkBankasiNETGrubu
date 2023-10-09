using _48_MVC_DependencyInjection.Classes;
using _48_MVC_DependencyInjection.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _48_MVC_DependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMyService _myService;

        public HomeController(ILogger<HomeController> logger, IMyService myService)
        {
            _logger = logger;
            this._myService = myService;
        }

        public IActionResult Index()
        {
            _myService.Add();
            return View();
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
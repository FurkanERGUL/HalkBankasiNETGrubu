using _47_MVC_OptionsPattern.Classes;
using _47_MVC_OptionsPattern.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Diagnostics;

namespace _47_MVC_OptionsPattern.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppSettings _appSettings;

        public HomeController(ILogger<HomeController> logger, IOptions<AppSettings> appSettings )
        {
            //IOptions<T>: Options sınıfı üzerinden erişim sağlar. Bu örneğin value özelliği ilde döndürür.
            //IOptionsSnapshot<T>: Daha dinamik olarak çalışıren son yapılandırma ayarlarını dinamik olarak ele almanıza olanak tanır. Bir HTTP isteği sırasında güncel yapılandırma ayarlarına ihtiyacınız varsa. Çalışma zamanı esnasında kullanılır.
            //IOptionsMonitor<T>: Options pattern üzerinde gerçekleşen değişiklikleri izlemek için kullanılır. 


            _logger = logger;
            _appSettings = appSettings.Value;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Options()
        {
            string key = _appSettings.AppKey;
            int value = _appSettings.AppValue;

            return Content($"Options key {key}- value {value}");

            //Yapılandırma ayarlarını merkezi şekilde yapılmasını sağlar
            //SQL connection string vs gibi bilgilerin saklanmasını sağlar
            //Sürdürülebilirlik
            //Ortam bağımsızlığı
            //Daha düzenli bir kod

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
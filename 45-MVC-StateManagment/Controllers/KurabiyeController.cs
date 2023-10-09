using Microsoft.AspNetCore.Mvc;

namespace _45_MVC_StateManagment.Controllers
{
    public class KurabiyeController : Controller
    {
        public string KurabiyeGetir(string kurabiye)
        {
            HttpContext.Request.Cookies.TryGetValue(kurabiye, out var cookies);
            return cookies;
        }
        public IActionResult Index()
        {
            HttpContext.Response.Cookies.Append("ad", "Bilgeadam2");
            HttpContext.Response.Cookies.Append("yasi", "25");


            return View();
        }

        public IActionResult Cerez()
        {
            var adi = KurabiyeGetir("ad");
            var yasi = KurabiyeGetir("yasi");

            return Content("Adi: " + adi + " Yasi: " + yasi);
        }
    }
}

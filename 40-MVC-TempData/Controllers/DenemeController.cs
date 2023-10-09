using Microsoft.AspNetCore.Mvc;

namespace _40_MVC_TempData.Controllers
{
    public class DenemeController : Controller
    {
        public IActionResult Index()
        {
            //ViewBag.Deneme = "Deneme yazısı";
            //var denemeMessage =ViewBag.Deneme;

            TempData["ErrorMessage"] = "Bir hata gerçekleşti";

            return RedirectToAction("ErrorMessage");
        }
        public IActionResult Error()
        {
            //var denemeMessage =ViewBag.Deneme;
            var hataMessage = TempData["ErrorMessage"].ToString();
            return Content(hataMessage);
        }
    }
}

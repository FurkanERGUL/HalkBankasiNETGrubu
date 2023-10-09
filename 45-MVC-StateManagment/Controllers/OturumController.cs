using Microsoft.AspNetCore.Mvc;

namespace _45_MVC_StateManagment.Controllers
{
    public class OturumController : Controller
    {
        const string personelAdi = "ad";
        const string personelMail = "mail";
        const string personelYasi = "yasi";
        const string personelRol = "rol";
        public IActionResult Index()
        {
            HttpContext.Session.SetString(personelAdi, "Bilge Adam");
            HttpContext.Session.SetInt32(personelYasi, 24);
            HttpContext.Session.SetString(personelMail, "bilgeadam@gmail.com");
            HttpContext.Session.SetString(personelRol, "user");
            return View();
        }
        public IActionResult Oturum()
        {
            ViewBag.prsAdi=HttpContext.Session.GetString(personelAdi);
            ViewBag.prsYasi = HttpContext.Session.GetInt32(personelYasi);
            ViewBag.prsMaili = HttpContext.Session.GetString(personelMail);
            ViewBag.prsRol = HttpContext.Session.GetString(personelRol);
            return View();
        }
    }
}

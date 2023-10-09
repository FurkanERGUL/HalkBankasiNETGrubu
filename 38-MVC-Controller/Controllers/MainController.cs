using _38_MVC_Controller.Models;
using Microsoft.AspNetCore.Mvc;

namespace _38_MVC_Controller.Controllers
{
    public class MainController : Controller
    {
        //Kullanıcı isteklerini alır işler gerekirse modelle etkileşime girer ve somuç olarak view oluşturur.
        /*
         1-Kullanıcı isteklerini işleme
         2-İş mantığı işleme
         3-Modelle etkileşime girme
         4-View ile etkileşim
         5-Üretim
         */

        //Action methodları HTTP isteklerine işlemek için kullanılan methodlardır. HTTP genellikle GET ve POST isteklerini karşılar.
        //Parametre alabilirler her zaman actionresult döndürürler


        //HTTP isteklerini karşılamak için Action verb dediğimiz yapıları kullanırız
        // GET POST PUT DELETE PATCH HEAD OPTIONS
        [HttpGet]
        public IActionResult Index()
        {
            //return View("../Home/Index");
            //return Content("Anasayfaya hoşgeldiniz");
            //return Redirect("../Home/Index");
            //return RedirectPermanent("../Home/Index");

            //var data = new { Name = "FF", Yas = 24 };
            //return Json(data);

            //byte[] fileContents = GetFileContents();
            //return File(fileContents, "application/pdf", "deneme.pdf");

            //return NotFound();
            var data = new { Message="İşlem başarılı." };
            return Ok(data);

            //return View();
        }

        [HttpPost]
        public IActionResult Index(Product product)
        {
            return Content("Anasayfaya hoşgeldiniz");
        }

        [HttpGet]
        [HttpPost]
        public IActionResult Index2(Product product)
        {
            return Content("Anasayfaya hoşgeldiniz");
        }
    }
}

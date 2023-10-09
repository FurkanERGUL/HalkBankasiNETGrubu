using Microsoft.AspNetCore.Mvc;

namespace _44_MVC_Routing.Controllers
{
    [Route("products")]
    public class UrunController : Controller
    {
        [Route("product")]
        [Route("products")]//İstenilen sayıda isim verilebilir
        [Route("products/index")]
        [Route("products/index/{id?}")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("Products/{id}")]
        public IActionResult Details(int id)
        {
            return Content($"Product ID: {id}");
        }

        [Route("Create/{entryId: int}/{slugs}")]
        public IActionResult Create(int entryId, string slugs)
        {
            return Content($"Deneme {entryId}-{slugs}");
        }

        [Route("Create/{entryId: int:range(1,500)}/{slugs}")]
        public IActionResult Create2(int entryId, string slugs)
        {
            return Content($"Deneme {entryId}-{slugs}");
        }

        [Route("Urun/{id:int}")]
        public IActionResult GetProduct(int id)
        {

            string gelendeger1 = Request.Query["magaza"];
            string gelendeger2 = Request.Query["konum"];

            return Content($"Deneme {id} - magaza: {gelendeger1} - konum: {gelendeger2}");
        }
    }
}
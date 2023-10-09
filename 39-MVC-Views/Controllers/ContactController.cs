using _39_MVC_Views.Models;
using Microsoft.AspNetCore.Mvc;

namespace _39_MVC_Views.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View("GetMessage");
        }
        public IActionResult MesajGonder()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetMessage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GetMessage(MessageSave message)
        {
            if (message!= null)
            {
                ViewBag.msjDondur = "Aferim";
                return View(message);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}

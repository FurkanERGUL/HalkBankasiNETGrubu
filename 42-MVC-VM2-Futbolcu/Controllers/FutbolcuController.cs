using _42_MVC_VM2_Futbolcu.Models;
using _42_MVC_VM2_Futbolcu.Models.VMs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace _42_MVC_VM2_Futbolcu.Controllers
{
    public class FutbolcuController : Controller
    {
        public IActionResult Index()
        {
            List<ListeVM> Kulup=new List<ListeVM>();
            
            foreach (var item in Data.Futbolcular)
            {
                ListeVM listeVM = new ListeVM();
                listeVM.Futbolcu = item;
                listeVM.Mevki = Data.Mevkiler.FirstOrDefault(a => a.MevkiID == item.MevkiID);
                listeVM.Takim = Data.Takimlar.FirstOrDefault(a => a.TakimID == item.TakimID);
                Kulup.Add(listeVM);

            }
            return View(Kulup);
        }
        public IActionResult Create()
        {
            CreateVM createVM = new CreateVM();
            createVM.Mevkiler = Data.Mevkiler;
            createVM.Takimlar = Data.Takimlar;
            
            return View(createVM);
        }

        [HttpPost]
        public IActionResult Create(Futbolcu futbolcu)
        {
            Data.Futbolcular.Add(futbolcu);
            return RedirectToAction("Index");
        }
    }
}

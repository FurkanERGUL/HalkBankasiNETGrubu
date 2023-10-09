using _41_MVC_ViewModel.Models;
using _41_MVC_ViewModel.Models.Enums;
using _41_MVC_ViewModel.Models.vMs;
using Microsoft.AspNetCore.Mvc;

namespace _41_MVC_ViewModel.Controllers
{
    public class PersonelController : Controller
    {
        List<Department> departments = new List<Department>()
        {
            new Department
            {
                ID= 1,
                Name="Yazilim"
            },
            new Department
            {
                ID= 2,
                Name="Muhasebe"
            },
            new Department
            {
                ID= 1,
                Name="IT"
            },
            new Department
            {
                ID= 1,
                Name="IK"
            }
        };

        List<Personel> personels = new List<Personel>()
        {
            new Personel
            {
                ID= 1,
                Name="FRKN",
                BirthDate = new DateTime(1999,4,29), WorkingType=WorkingType.FullTime
            },
            new Personel
            {
                ID= 2,
                Name="FE",
                BirthDate = new DateTime(1999,3,3), WorkingType=WorkingType.ProjectBased
            },
            new Personel
            {
                ID= 3,
                Name="FK",
                BirthDate = new DateTime(1999,5,9), WorkingType=WorkingType.Freelance
            },
            new Personel
            {
                ID= 4,
                Name="FuRKaN",
                BirthDate = new DateTime(1978,7,15), WorkingType=WorkingType.PartTime
            },
            new Personel
            {
                ID= 2,
                Name="Ff",
                BirthDate = new DateTime(1979,8,9), WorkingType=WorkingType.FullTime
            }
        };
        public IActionResult Index()
        {
            return View(personels);
        }
        [HttpGet]
        public IActionResult Create()
        {
            CreateVM vm= new CreateVM();
            vm.Personel = new Personel();
            vm.Departments = departments;
            return View(vm);
        }
    }
}

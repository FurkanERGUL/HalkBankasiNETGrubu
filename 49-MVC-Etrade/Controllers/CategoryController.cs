using _49_MVC_Etrade.Models.DTOs;
using _49_MVC_Etrade.Models.Entities;
using _49_MVC_Etrade.Models.Entities.Deneme;
using _49_MVC_Etrade.Models.VMs;
using _49_MVC_Etrade.Services.Abstract;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace _49_MVC_Etrade.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepo _categoryRepo;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryRepo categoryRepo, IMapper mapper)
        {
            this._categoryRepo = categoryRepo;
            this._mapper = mapper;
            Employee employee = new Employee()
            {
                EmployeeId = 1,
                EmployeeName = "FRKN",
                EmployeeLastName = "ERGL",
                Department = "FF"
            };
            var empDTO = mapper.Map<Employee, EmployeeDTO>(employee);

            string id = empDTO.EmployeeId.ToString();
            string name = empDTO.EmployeeFullName;
            string depatment = empDTO.Department;

        }

        public IActionResult Index()
        {
            var cats = _categoryRepo.GetAllCategories().Select(
                c=> _mapper.Map<CategoryListVM>(c)
                );
            //List<Category> categories = new List<Category>();
            return View(cats);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CategoryDTO categoryDTO)
        {
            if (ModelState.IsValid)
            {
                var cat= _mapper.Map<Category>(categoryDTO);

                _categoryRepo.AddCategory(cat);
                return RedirectToAction("Index");
            }
            else
            {
                return View(_categoryRepo);
            }
            
        }
    }
}
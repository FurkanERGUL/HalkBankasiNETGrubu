using _49_MVC_Etrade.Models.Entities;
using _49_MVC_Etrade.Models.VMs;
using _49_MVC_Etrade.Services.Abstract;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace _49_MVC_Etrade.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepo _proRepo;
        private readonly IMapper _mapper;
        private readonly ICategoryRepo _catRepo;

        public ProductController(IProductRepo proRepo, IMapper mapper, ICategoryRepo categoryRepo)
        {
            _proRepo = proRepo;
            _mapper = mapper;
            _catRepo = categoryRepo;
        }

        public IActionResult Index()
        {
            var products = _proRepo.GetAllProducts();
            return View(products);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ProductCreateVM productCreateVM = new ProductCreateVM()
            {
                Categories = _catRepo.GetAllCategories()
            };
            return View(productCreateVM);
        }
        [HttpPost]
        public IActionResult Create(ProductCreateVM createVM)
        {   
          
            var product = _mapper.Map<Product>(createVM);
            _proRepo.AddProduct(product);
            
            return RedirectToAction("Index");
            
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var product = _proRepo.GetByProductId(id);
            return View(product);
        }
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            _proRepo.UpdateProduct(product);
            return RedirectToAction("Index");

        }
    }
}

using _49_MVC_Etrade.Contexts;
using _49_MVC_Etrade.Models.Entities;
using _49_MVC_Etrade.Models.Entities.Enums;
using _49_MVC_Etrade.Services.Abstract;

namespace _49_MVC_Etrade.Services.Concrete
{
    public class CategoryRepo : ICategoryRepo
    {
        private readonly AppDbContext _context;
        public CategoryRepo(AppDbContext context)
        {
            _context = context;
        }

        public void AddCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public void DeleteCategory(Category category)
        {
            category.Status = Status.Passive;
            category.DeleteDate = DateTime.Now;
            _context.SaveChanges();
        }

        public List<Category> GetAllCategories()
        {
            return _context.Categories.ToList();
        }

        public Category GetByCategoryId(int id)
        {
            return _context.Categories.Find(id);
        }

        public void UpdateCategory(Category category)
        {
            category.Status = Status.Modified;
            category.UpdateDate = DateTime.Now;
            _context.SaveChanges();
        }
    }
}

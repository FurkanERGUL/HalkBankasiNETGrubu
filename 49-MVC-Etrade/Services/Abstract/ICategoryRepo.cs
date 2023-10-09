using _49_MVC_Etrade.Models.Entities;

namespace _49_MVC_Etrade.Services.Abstract
{
    public interface ICategoryRepo
    {
        void AddCategory(Category category);
        void UpdateCategory(Category category);
        void DeleteCategory(Category category);
        Category GetByCategoryId(int id);
        List<Category> GetAllCategories();
    }
}

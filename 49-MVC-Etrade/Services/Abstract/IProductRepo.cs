using _49_MVC_Etrade.Models.Entities;

namespace _49_MVC_Etrade.Services.Abstract
{
    public interface IProductRepo
    {
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(Product product);
        Product GetByProductId(int id);
        List<Product> GetAllProducts();
    }
}

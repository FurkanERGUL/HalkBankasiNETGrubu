using _49_MVC_Etrade.Contexts;
using _49_MVC_Etrade.Models.Entities;
using _49_MVC_Etrade.Models.Entities.Enums;
using _49_MVC_Etrade.Services.Abstract;

namespace _49_MVC_Etrade.Services.Concrete
{
    public class ProductRepo : IProductRepo
    {
        private readonly AppDbContext _context;

        public ProductRepo(AppDbContext context)
        {
            _context = context;
        }

        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void DeleteProduct(Product product)
        {
            product.Status = Status.Passive;
            product.DeleteDate = DateTime.Now;
            _context.SaveChanges();
        }

        public List<Product> GetAllProducts()
        {
            return _context.Products.ToList();
        }

        public Product GetByProductId(int id)
        {
            return _context.Products.Find(id);
        }

        public void UpdateProduct(Product product)
        {
            product.Status = Status.Modified;
            product.UpdateDate = DateTime.Now;
            _context.Update(product);
            _context.SaveChanges();
        }
    }
}

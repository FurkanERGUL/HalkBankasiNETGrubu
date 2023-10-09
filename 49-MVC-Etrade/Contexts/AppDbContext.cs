using _49_MVC_Etrade.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace _49_MVC_Etrade.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        
    }
}

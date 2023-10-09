using _29_EF_CodeFirstModelDbContextApplication.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_EF_CodeFirstModelDbContextApplication.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDetails> ProductsDetails { get; set; }
        //public DbSet<BaseEntity> BaseEntities { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer("Server=KDK-403-YZ-PC11;Database=RelationDb;Trusted_Connection=True;");
        }

        //Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().
                HasOne(p => p.Category).
                WithMany(p => p.Products).
                HasForeignKey(p => p.CategoryRefID);

            modelBuilder.Entity<Product>().
                HasOne(p => p.ProductDetail).
                WithOne(p => p.Product).
                HasForeignKey<ProductDetails>(p => p.ProductRefID); //Product detail ile başlarsan gerek kalmazdı


            base.OnModelCreating(modelBuilder);
        }
    }
}

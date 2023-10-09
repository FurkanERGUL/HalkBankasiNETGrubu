using _29_EF_CodeFirstModelDbContextApplication.Context;
using _29_EF_CodeFirstModelDbContextApplication.Entities;
using _29_EF_CodeFirstModelDbContextApplication.Service.Concrete;
using System.Diagnostics;

namespace _29_EF_CodeFirstModelDbContextApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CategoryService categoryService = new CategoryService(new AppDbContext());
            ////categoryService.Add(new Category() { CategoryName="Kalem", CategoryStatu = Enums.Status.Active });
            //var category = categoryService.GetByDefaults(c => c.CategoryName == "Kalem");
            //foreach (var item in category)
            //{
            //    Console.WriteLine("Category: "+item.CategoryName+" "+item.CategoryID);
            //}


            //Category category1 = new Category() { CategoryName="Kitap", CategoryStatu=Enums.Status.Active };
            //BaseService<Category> baseService = new BaseService<Category>(new AppDbContext());
            //baseService.Add(category1);

            Product product1 = new Product() { Category= new Category() { CategoryName="Kitap"}, ProductName = "Ruhsuzum ", Price = 10, Stock = 20, Statu=Enums.Status.Active };
            BaseService<Product> baseService1 = new BaseService<Product>(new AppDbContext());
            baseService1.Add(product1);

            

            Console.WriteLine("Başarılı....");
        }
    }
}
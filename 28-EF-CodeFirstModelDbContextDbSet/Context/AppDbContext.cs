using _28_EF_CodeFirstModelDbContextDbSet.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_EF_CodeFirstModelDbContextDbSet.Context
{
    //DbContext: Verilerle nesneler arasında etkileşim kurmatktan sorumlu olan birincil yapıdır.
    //System.Data.Entity.DbContext, DbContext.Api, .NET Framework'ün bir parçası olarak yayınlanmaz.
    //EntityFrameWork.dll
    public class AppDbContext : DbContext
    {


        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }


        //SQL configurasyonlarını yaptığımız yer
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer("Server=KDK-403-YZ-PC11;Database=Book2;Trusted_Connection=True;");
        }

        //Tabloları Fluent api kullanarak bireleştireceğimiz yer.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

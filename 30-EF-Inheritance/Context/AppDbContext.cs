using _30_EF_Inheritance.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_EF_Inheritance.Context
{
    public class AppDbContext : DbContext
    {

        #region TPH
        //Bu yaklaşım tüm kalıtım yapısını temsil etmek için veri tabanında 1 tablo oluşturur.
        public DbSet<BasePerson> People { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }
        //Avantajları
        //Join işlemi gerektirmez. Ancak çok sütun için veritabanı birçok disk belleği işlemi gerçekleştirir.
        //Kullanım ve oluşturma kolaylağı sağlar
        //3rd normal formu ihlal eder
        #endregion

        #region TPT
        //Bu yaklaşım tüm kalıtım yapısını temsil etmek için veri tabanında (n) adet (n-subclass) tablo oluşturacaktır.
        //public DbSet<Employee> Employees { get; set; }
        //public DbSet<Customer> Customers { get; set; }
        
        //Avantajları
        //Normalize tabloları
        //Kolay kolon ekleme
        //Az sayıda null
        #endregion


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=KDK-403-YZ-PC11;Database=InheritanceDb;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

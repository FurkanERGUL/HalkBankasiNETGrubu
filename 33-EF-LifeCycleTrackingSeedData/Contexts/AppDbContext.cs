using _33_EF_LifeCycleTrackingSeedData.Models;
using _33_EF_LifeCycleTrackingSeedData.Models.SeedData;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_EF_LifeCycleTrackingSeedData.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=KDK-403-YZ-PC11;Database=SeedDataDb;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Genellikle veritabanı ilk oluşturulduğunda,
            //ilk verileri bir veritabanına ekleme süreci
            //olarak ifade edilir.


            //I.Yol
            modelBuilder.Entity<Author>()
                .HasData(
                new Author()
                {
                    AuthorId= 1,
                    FirstName="Furkan",
                    LastName="ERGÜL"
                },
                new Author()
                {
                    AuthorId= 2,
                    FirstName="FF",
                    LastName="loser"
                }
                );

            //II.Yol
            modelBuilder.ApplyConfiguration(new SeedBook());

            base.OnModelCreating(modelBuilder);
        }
    }
}

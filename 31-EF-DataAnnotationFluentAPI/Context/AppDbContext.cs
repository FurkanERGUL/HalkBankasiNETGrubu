using _31_EF_DataAnnotationFluentAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_EF_DataAnnotationFluentAPI.Context
{
    public class AppDbContext : DbContext
    {

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=KDK-403-YZ-PC11;Database=Idiot;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Column
            modelBuilder.Entity<Book>().Property(p => p.BookName)
                .HasColumnName("ClmBookName")
                .HasColumnOrder(2)
                .HasColumnType("nvarchar(50)")
                .IsRequired(false);

            //Concuerency check
            modelBuilder.Entity<Author>().Property(a => a.AuthorName).IsConcurrencyToken();

            //Key
            modelBuilder.Entity<Book>().HasKey(b => b.BookId);

            //compositeKey
            //modelBuilder.Entity<Book>().HasKey(o => new { o.BookId, o.Author.AuthorId });

            //Max Length
            modelBuilder.Entity<Book>().Property(b=>b.BookSubject).HasMaxLength(128);

            //Table
            modelBuilder.Entity<Author>().ToTable("TblYazar");

            //Not mapped class
            modelBuilder.Ignore<Deneme>();

            //Not Mapped property
            modelBuilder.Entity<Author>().Ignore(a => a.AuthorAge);

            //Foreign Key
            modelBuilder.Entity<Author>()
                .HasMany(a => a.Books)
                .WithOne(b => b.Author)
                .HasForeignKey(b=>b.AuthorFKId);
        }
    }
}

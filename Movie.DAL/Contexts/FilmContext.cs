using Microsoft.EntityFrameworkCore;
using Movie.DATA.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.DAL.Contexts
{
    public class FilmContext : DbContext
    {
        public DbSet<Actor> Actors { get; set; }
        public DbSet<FilmCategory> FilmCategories { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<FilmDetail> FilmDetails { get; set; }
        public DbSet<FilmActor> FilmActors { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer("Server=KDK-403-YZ-PC11;Database=MovieDB;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

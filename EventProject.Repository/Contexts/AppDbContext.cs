using EventProject.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventProject.Repository.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventDetail> EventDetails { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer("Server=KDK-403-YZ-PC11;Database=EventDb;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>().HasOne(e => e.EventDetail).WithOne(e=>e.Event).HasForeignKey<EventDetail>(e=>e.EventDetailId);

            modelBuilder.Entity<Ticket>().HasKey(e => new { e.EventId, e.CustomerId });
            modelBuilder.Entity<Event>().HasMany(e => e.Tickets).WithOne(e => e.Event).HasForeignKey(e => e.EventId);
            modelBuilder.Entity<Customer>().HasMany(e => e.Tickets).WithOne(e => e.Customers);
            base.OnModelCreating(modelBuilder);
        }
    }
}

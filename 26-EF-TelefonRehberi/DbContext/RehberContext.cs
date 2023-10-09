using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using _26_EF_TelefonRehberi.Models;

namespace _26_EF_TelefonRehberi.DbContext
{
    public partial class RehberContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public RehberContext()
        {
        }

        public RehberContext(DbContextOptions<RehberContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TelefonRehberi> TelefonRehberis { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=KDK-403-YZ-PC11;Database=Rehber;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TelefonRehberi>(entity =>
            {
                entity.HasKey(e => e.KisiId)
                    .HasName("PK__TelefonR__110EDC89B12DE387");

                entity.ToTable("TelefonRehberi");

                entity.Property(e => e.KisiId).HasColumnName("KisiID");

                entity.Property(e => e.KisiAd).HasMaxLength(50);

                entity.Property(e => e.KisiSoyad).HasMaxLength(50);

                entity.Property(e => e.KisiTelefon).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

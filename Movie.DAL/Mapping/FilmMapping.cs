using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Movie.DATA.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.DAL.Mapping
{
    public class FilmMapping : IEntityTypeConfiguration<Film>
    {
        public void Configure(EntityTypeBuilder<Film> builder)
        {
            builder.Property(x=>x.FilmName).IsRequired().HasColumnType("nvarchar(50");
            builder.ToTable("TblFilm");

            builder.HasOne(c => c.FilmCategory)
                   .WithMany(x => x.Films)
                   .HasForeignKey(x => x.CategoryId);
        }
    }
}

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
    public class FilmDetailMapping : IEntityTypeConfiguration<FilmDetail>
    {
        public void Configure(EntityTypeBuilder<FilmDetail> builder)
        {
            builder.HasOne(x=>x.Film).WithOne(x=>x.FilmDetail).HasForeignKey<FilmDetail>(x=>x.FilmId);
        }
    }
}

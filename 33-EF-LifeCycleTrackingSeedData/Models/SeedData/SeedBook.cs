using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_EF_LifeCycleTrackingSeedData.Models.SeedData
{
    internal class SeedBook : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData(
                new Book { BookId=1, Title="İntihar Mektuplarım", AuthorId=1},
                new Book { BookId=2, Title="Kaybolmuş Anahtarlar", AuthorId=2},
                new Book { BookId=3, Title="Şehrin En Güzel Manzarası", AuthorId=2},
                new Book { BookId=4, Title="Delinin Gözyaşları", AuthorId=1},
                new Book { BookId=5, Title="Kargalar", AuthorId=1 }
                );
        }
    }
}

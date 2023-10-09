using BookStore.Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Entities
{
    public class Author : BaseEntity
    {
        public string AuthorName { get; set; }
        public string AuthorSurname { get; set; }
        public DateTime BirthDate { get; set; }

        public List<Book> Books { get; set; }

    }
}

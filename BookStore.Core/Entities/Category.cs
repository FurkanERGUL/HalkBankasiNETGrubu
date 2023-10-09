using BookStore.Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Entities
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }

        //Buraya kitap listesi gelecek
        public List<Book> Books { get; set; }
    }
}

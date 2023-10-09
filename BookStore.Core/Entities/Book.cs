using BookStore.Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Entities
{
    public class Book : BaseEntity
    {
        public string BookName { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public double Discount { get; set; }
        public bool StockControl { get; set; }
        public DateTime BookPublishDate { get; set; }

        //
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public Author Author { get; set; }
        public int AuthorId { get; set; }

    }
}

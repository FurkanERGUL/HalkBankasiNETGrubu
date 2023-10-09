using BookStore.Core.Entities;
using BookStore.Repository.Contexts;
using BookStore.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Repository.Concrete
{
    public class BookRepo : BaseRepo<Book>, IBookRepo
    {
        private readonly AppDbContext _context;
        public BookRepo(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public List<Book> BookFindByName(string bookName)
        {
            var liste = _context.Books
                .Where(x => x.BookName == bookName)
                .OrderBy(x=>x.CreateDate)
                .ToList();
            return liste;
        }
        public List<Book> AllBookByCategory() 
        {
            var liste = _context.Books.OrderBy(x => x.Category.CategoryName).ToList();
            return liste;
        }
        public List<Book> CategoryByBook(string categoryName)
        {
            var liste = _context.Books.Where(x=>x.Category.CategoryName==categoryName).OrderBy(x=>x.BookName).ToList();
            return liste;
        }
        public List<Book> AuthorByBook(string authorName)
        {
            var liste = _context.Books.Where(x => x.Author.AuthorName==authorName).ToList();
            return liste;
        }
        public List<Book> DiscountedBook()
        {
            var liste = _context.Books.Where(x => x.Discount>0).OrderByDescending(x=>x.Discount).ToList();
            return liste;
        }
        public List<Book> EndOfStock()
        {
            var liste = _context.Books.Where(x => x.Stock > 10).ToList();
            return liste;
        }
        public List<Book> LastTenBook() 
        {
            var liste = _context.Books.OrderBy(x => x.CreateDate).ToList();
            return liste;
        }
        public List<Book> OrderByPrice()
        {
            var liste = _context.Books.OrderBy(x => x.Price).ToList();
            return liste;
        }
        public List<Book> OrderByDate()
        {
            var liste = _context.Books.OrderByDescending(x => x.CreateDate).Take(10).ToList();
            return liste;
        }
    }
}

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
    public class CategoryRepo : BaseRepo<Category>, ICategoryRepo
    {
        private readonly AppDbContext _context;
        public CategoryRepo(AppDbContext context) : base(context)
        {
            _context= context;
        }

        public List<Category> CategoryFindByName(string categoryName)
        {
            var liste = _context.Categories.Where(x=>x.CategoryName==categoryName).ToList();
            return liste;
        }
    }
}

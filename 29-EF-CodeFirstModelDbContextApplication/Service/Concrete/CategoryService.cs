using _29_EF_CodeFirstModelDbContextApplication.Context;
using _29_EF_CodeFirstModelDbContextApplication.Entities;
using _29_EF_CodeFirstModelDbContextApplication.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _29_EF_CodeFirstModelDbContextApplication.Service.Concrete
{
    public class CategoryService : ICategory
    {
        private readonly AppDbContext _context;
        public CategoryService(AppDbContext context)
        {
            _context = context;
        }
        public void Add(Category entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(Category entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();   
        }

        public IList<Category> GetByDefaults(Expression<Func<Category, bool>> expression)
        {
            return _context.Categories.Where(expression).ToList();
        }

        public IList<Category> GetCategory()
        {
            return _context.Categories.ToList();
        }

        public bool GetCategoryAny(int id)
        {
            return _context.Categories.Any(c => c.Id == id);
        }

        public Category GetCategoryByID(int id)
        {
            return _context.Categories.Find(id);
        }

        public void Update(Category entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }
    }
}
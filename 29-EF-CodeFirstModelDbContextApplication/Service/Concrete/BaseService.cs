using _29_EF_CodeFirstModelDbContextApplication.Context;
using _29_EF_CodeFirstModelDbContextApplication.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _29_EF_CodeFirstModelDbContextApplication.Service.Concrete
{
    public class BaseService<T> : IBaseService<T> where T : class
    {
        private readonly AppDbContext _context;
        public BaseService(AppDbContext context)
        {
            this._context = context;
        }
        public void Add(T entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public IList<T> GetByDefaults(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression).ToList();
        }

        public IList<T> GetCategory()
        {
            return _context.Set<T>().ToList();
        }

        public bool GetTAny(Expression<Func<T, bool>> expression)
        {
            
            return _context.Set<T>().Any(expression);
        }

        public T GetTByID(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }
    }
}
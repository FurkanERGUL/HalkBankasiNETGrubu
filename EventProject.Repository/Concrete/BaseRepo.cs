using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using EventProject.Repository.Contexts;
using EventProject.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EventProject.Repository.Concrete
{
    public class BaseRepo<T> : IBaseRepo<T> where T : class
    {
        private readonly AppDbContext _context;
        protected DbSet<T> _table;
        
        public BaseRepo(AppDbContext context)
        {
            _context = context;
            _table = context.Set<T>();
        }

        public bool Any(Expression<Func<T, bool>> expression)
        {
            return _table.Any(expression);
        }

        public void Create(T Entity)
        {
            _table.Add(Entity);
            _context.SaveChanges();
        }

        public void Delete(T Entity)
        {
            _context.SaveChanges();
        }

        public T GetDefault(Expression<Func<T, bool>> expression)
        {
            return _table.FirstOrDefault(expression);
        }

        public T GetDefaultById(int id)
        {
            return _table.Find(id);
        }

        public IList<T> GetDefaults(Expression<Func<T, bool>> expression)
        {
            return _table.Where(expression).ToList();
        }

        public void Update(T Entity)
        {
            _context.Entry<T>(Entity).State= EntityState.Modified;
            _context.SaveChanges();
        }
    }
}

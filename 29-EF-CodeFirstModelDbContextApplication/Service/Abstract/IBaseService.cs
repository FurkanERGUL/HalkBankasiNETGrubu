using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _29_EF_CodeFirstModelDbContextApplication.Service.Abstract
{
    public interface IBaseService<T> where T : class
    {
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        IList<T> GetCategory();
        IList<T> GetByDefaults(Expression<Func<T, bool>> expression);
        T GetTByID(int id);
        bool GetTAny(Expression<Func<T, bool>> expression);
    }
}
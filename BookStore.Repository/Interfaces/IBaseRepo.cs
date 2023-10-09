using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Repository.Interfaces
{
    public interface IBaseRepo<T> where T : class
    {
        void Create(T Entity);
        void Update(T Entity);
        void Delete(T Entity);
        bool Any(Expression<Func<T, bool>> expression);
        T GetDefault(Expression<Func<T, bool>> expression);
        T GetDefaultById(int id);
        
        IList<T> GetDefaults(Expression<Func<T, bool>> expression);
    }
}

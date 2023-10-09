using Microsoft.EntityFrameworkCore.Query;
using Movie.DATA.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Movie.DAL.Interfaces
{
    public interface IBaseDal<T> where T : BaseFilm
    {
        void Create(T Entity);
        void Update(T Entity);
        void Delete(T Entity);
        bool Any(Expression<Func<T, bool>> expression);
        T GetDefault(Expression<Func<T, bool>> expression);
        List<T> GetDefaults(Expression<Func<T, bool>> expression);
        List<TResult> GetFilteredList<TResult>(Expression<Func<T, TResult>> select,
            Expression<Func<T, bool>> where, Func<IQueryable<T>,
            IOrderedQueryable<T>> orderby = null,
            Func<IQueryable<T>,
            IIncludableQueryable<T, object>> join = null);
    }
}

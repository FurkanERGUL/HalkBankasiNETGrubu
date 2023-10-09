using Movie.DAL.Interfaces;
using Movie.DATA.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.DAL.Concrete
{
    public class ActorDAL<T> : IBaseDal<T> where T : BaseFilm, IActorDAl
    {
        public bool Any(System.Linq.Expressions.Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void Create(T Entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T Entity)
        {
            throw new NotImplementedException();
        }

        public T GetDefault(System.Linq.Expressions.Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public List<T> GetDefaults(System.Linq.Expressions.Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public List<TResult> GetFilteredList<TResult>(System.Linq.Expressions.Expression<Func<T, TResult>> select, System.Linq.Expressions.Expression<Func<T, bool>> where, Func<IQueryable<T>, IOrderedQueryable<T>> orderby = null, Func<IQueryable<T>, Microsoft.EntityFrameworkCore.Query.IIncludableQueryable<T, object>> join = null)
        {
            throw new NotImplementedException();
        }

        public void Update(T Entity)
        {
            throw new NotImplementedException();
        }
    }
}

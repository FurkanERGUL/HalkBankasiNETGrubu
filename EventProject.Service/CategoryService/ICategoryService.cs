using EventProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EventProject.Service.CategoryService
{
    public interface ICategoryService
    {
        void Create(Category Entity);
        void Update(Category Entity);
        void Delete(Category Entity);
        bool Any(Expression<Func<Category, bool>> expression);
        Category GetDefault(Expression<Func<Category, bool>> expression);
        Category GetDefaultById(int id);
        IList<Category> GetDefaults(Expression<Func<Category, bool>> expression);

        //
        int GetEventCountByCategory(int categoryId);
    }
}

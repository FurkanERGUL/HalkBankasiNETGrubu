using EventProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EventProject.Repository.Interfaces
{
    public interface ICustomerRepo : IBaseRepo<Customer>
    {
        //bool Any(Expression<Func<Category, bool>> expression);
    }
}

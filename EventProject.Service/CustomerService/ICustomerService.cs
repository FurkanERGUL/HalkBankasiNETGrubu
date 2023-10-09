using EventProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EventProject.Service.CustomerService
{
    public interface ICustomerService
    {
        void Create(Customer Entity);
        void Update(Customer Entity);
        void Delete(Customer Entity);
        bool Any(Expression<Func<Customer, bool>> expression);
        Customer GetDefault(Expression<Func<Customer, bool>> expression);
        Customer GetDefaultById(int id);
        IList<Customer> GetDefaults(Expression<Func<Customer, bool>> expression);
    }
}

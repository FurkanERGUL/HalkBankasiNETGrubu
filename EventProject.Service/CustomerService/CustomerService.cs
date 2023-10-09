using EventProject.Core.Entities;
using EventProject.Core.Enums;
using EventProject.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EventProject.Service.CustomerService
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepo _repo;
        public CustomerService(ICustomerRepo repo)
        {
            _repo = repo;
        }

        public bool Any(Expression<Func<Customer, bool>> expression)
        {
            return _repo.Any(expression);
        }

        public void Create(Customer Entity)
        {
            _repo.Create(Entity);
        }

        public void Delete(Customer Entity)
        {
            Entity.DeleteDate= DateTime.Now;
            Entity.Status = Status.Passive;
            _repo.Delete(Entity);
        }

        public Customer GetDefault(Expression<Func<Customer, bool>> expression)
        {
            return _repo.GetDefault(expression);
        }

        public Customer GetDefaultById(int id)
        {
            return _repo.GetDefaultById(id);
        }

        public IList<Customer> GetDefaults(Expression<Func<Customer, bool>> expression)
        {
            return _repo.GetDefaults(expression);
        }

        public void Update(Customer Entity)
        {
            Entity.UpdateDate= DateTime.Now;
            Entity.Status = Status.Modified;
            _repo.Update(Entity);
        }
    }
}

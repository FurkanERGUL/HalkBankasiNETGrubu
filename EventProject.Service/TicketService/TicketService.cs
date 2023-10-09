using EventProject.Core.Entities;
using EventProject.Repository.Concrete;
using EventProject.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EventProject.Service.TicketService
{
    public class TicketService : ITicketService
    {
        private readonly TicketRepo _repo;
        public TicketService(TicketRepo repo)
        {
            _repo = repo;
        }

        public bool Any(Expression<Func<Ticket, bool>> expression)
        {
            return _repo.Any(expression);
        }

        public void Create(Ticket Entity)
        {
            _repo.Create(Entity);
        }

        public void Delete(Ticket Entity)
        {
            _repo.Delete(Entity);
        }

        public List<Customer> GetAttends(int eventId)
        {
            return _repo.GetAttends(eventId);
        }

        public int GetAttendsCount(int eventId)
        {
            return _repo.GetAttendsCount(eventId);
        }

        public int GetCustomerOfEventCount(int customerId)
        {
            return _repo.GetCustomerOfEventCount(customerId);
        }

        public List<Event> GetCustomersOfEvents(int customerId)
        {
            return _repo.GetCustomersOfEvents(customerId);
        }

        public Ticket GetDefault(Expression<Func<Ticket, bool>> expression)
        {
            return _repo.GetDefault(expression);
        }

        public Ticket GetDefaultById(int id)
        {
            return _repo.GetDefaultById(id);
        }

        public IList<Ticket> GetDefaults(Expression<Func<Ticket, bool>> expression)
        {
            return _repo.GetDefaults(expression);
        }

        public void Update(Ticket Entity)
        {
            _repo.Update(Entity);
        }
    }
}

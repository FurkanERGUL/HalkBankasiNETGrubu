using EventProject.Core.Entities;
using EventProject.Repository.Contexts;
using EventProject.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventProject.Repository.Concrete
{
    public class TicketRepo : BaseRepo<Ticket>, ITicketRepo
    {
        private readonly AppDbContext _context;
        public TicketRepo(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public List<Customer> GetAttends(int eventId)
        {
            //Yol-1
            /*return _context.Tickets
                .Where(t => t.EventId == eventId)
                .Select(x => new Customer
                {
                    Id=x.Customers.Id,
                    CustomerName=x.Customers.CustomerName,
                    CustomerAge=x.Customers.CustomerAge,
                    CustomerPhone=x.Customers.CustomerPhone,
                }).ToList();*/

            //Yol-2
            //return _context.Tickets.Where(x => x.EventId==eventId).Join(_context.Customers,
            //    t => t.CustomerId,
            //    c => c.Id,
            //    (t, c) => new Customer
            //    {
            //        Id= c.Id,
            //        CustomerName=c.CustomerName,
            //        CustomerAge=c.CustomerAge,
            //        CustomerPhone = c.CustomerPhone
            //    }
            //    ).ToList();

            //Yol-3
            return _context.Customers
                .Include(x=>x.Tickets)
                .Where(x=>x.Tickets
                .Any(x=>x.EventId
                .Equals(eventId)))
                .ToList();

        }

        public int GetAttendsCount(int eventId)
        {
            return _context.Tickets.Count(t=>t.EventId==eventId);
        }

        public int GetCustomerOfEventCount(int customerId)
        {
            return _context.Tickets.Count(t=>t.CustomerId==customerId);
        }

        public List<Event> GetCustomersOfEvents(int customerId)
        {
            return _context.Tickets
                .Where(x => x.CustomerId == customerId)
                .Join(_context.Events, t => t.EventId, e => e.Id,
                (t, e) => new Event
                {
                    Id = e.Id,
                    EventName = e.EventName,
                    EventAttends = e.EventAttends,
                    EventControlAge = e.EventControlAge,
                    EventDetail = e.EventDetail,
                    EventEndDate = e.EventEndDate,
                    EventLocation = e.EventLocation,
                    EventPrice = e.EventPrice,
                    EventStartDate = e.EventStartDate
                }
                ).ToList();
        }
    }
}

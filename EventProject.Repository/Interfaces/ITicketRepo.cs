using EventProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventProject.Repository.Interfaces
{
    public interface ITicketRepo : IBaseRepo<Ticket>
    {
        int GetAttendsCount(int eventId);
        List<Customer>GetAttends(int eventId);
        int GetCustomerOfEventCount(int customerId);
        List<Event> GetCustomersOfEvents(int customerId);

    }
}

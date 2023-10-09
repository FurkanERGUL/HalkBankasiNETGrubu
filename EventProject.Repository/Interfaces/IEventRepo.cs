using EventProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventProject.Repository.Interfaces
{
    public interface IEventRepo : IBaseRepo<Event>
    {
        IList<Event> GetEventsOrderByPriceASC();
        IList<Event> GetEventsOrderByPriceDESC();
        IList<Event> GetEventsByDate(DateTime startDate, DateTime endDate);
        IList<Event> GetEventsByLocation(string location);
    }
}
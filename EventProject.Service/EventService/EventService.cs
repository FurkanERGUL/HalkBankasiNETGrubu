using EventProject.Core.Entities;
using EventProject.Core.Enums;
using EventProject.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EventProject.Service.EventService
{
    public class EventService : IEventService
    {
        private readonly IEventRepo _repo;
        public EventService(IEventRepo repo)
        {
            _repo = repo;
        }

        public bool Any(Expression<Func<Event, bool>> expression)
        {
            return _repo.Any(expression);
        }

        public void Create(Event Entity)
        {
            _repo.Create(Entity);
        }

        public void Delete(Event Entity)
        {
            Entity.DeleteDate = DateTime.Now;
            Entity.Status = Status.Passive;
            _repo.Delete(Entity);
        }

        public Event GetDefault(Expression<Func<Event, bool>> expression)
        {
            return _repo.GetDefault(expression);
        }

        public Event GetDefaultById(int id)
        {
            return _repo.GetDefaultById(id);
        }

        public IList<Event> GetDefaults(Expression<Func<Event, bool>> expression)
        {
            return _repo.GetDefaults(expression);
        }

        public IList<Event> GetEventsByDate(DateTime startDate, DateTime endDate)
        {
            return _repo.GetEventsByDate(startDate, endDate);
        }

        public IList<Event> GetEventsByLocation(string location)
        {
            return _repo.GetEventsByLocation(location);
        }

        public IList<Event> GetEventsOrderByPriceASC()
        {
            return _repo.GetEventsOrderByPriceASC();
        }

        public IList<Event> GetEventsOrderByPriceDESC()
        {
            return _repo.GetEventsOrderByPriceDESC();
        }

        public void Update(Event Entity)
        {
            Entity.UpdateDate= DateTime.Now;
            Entity.Status = Status.Modified;
            _repo.Update(Entity);
        }
    }
}

using EventProject.Core.Entities;
using EventProject.Repository.Contexts;
using EventProject.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EventProject.Repository.Concrete
{
    public class EventDetailRepo :  IEventDetailRepo
    {
        private readonly AppDbContext context;
        public EventDetailRepo(AppDbContext context) 
        {
            this.context = context;
        }

        public bool Any(Expression<Func<EventDetail, bool>> expression)
        {
            return context.EventDetails.Any(expression);
        }

        public void Create(EventDetail Entity)
        {
            context.EventDetails.Add(Entity);
            context.SaveChanges();
        }

        public void Delete(EventDetail Entity)
        {
            context.EventDetails.Remove(Entity);
            context.SaveChanges();
        }

        public EventDetail GetDefault(Expression<Func<EventDetail, bool>> expression)
        {
            return context.EventDetails.FirstOrDefault(expression);
        }

        public EventDetail GetDefaultById(int id)
        {
            return context.EventDetails.Find(id);
        }

        public IList<EventDetail> GetDefaults(Expression<Func<EventDetail, bool>> expression)
        {
            return context.EventDetails.Where(expression).ToList();
        }

        public void Update(EventDetail Entity)
        {
            context.SaveChanges();
        }
    }
}

using EventProject.Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventProject.Core.Entities
{
    public class Category : BaseEvent
    {
        public string CategoryName { get; set; }
        public virtual IList<Event> Events { get; set; }
    }
}

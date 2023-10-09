using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventProject.Core.Entities
{
    public class Ticket
    {
        
        //public int TicketId { get; set; }
        public int EventId { get; set; }
        public int CustomerId { get; set; }
        public DateTime TicketDate { get; set; }= DateTime.Now;

        public virtual Customer Customers { get; set; }
        public virtual Event Event { get; set; }

    }
}

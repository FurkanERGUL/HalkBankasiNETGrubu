using EventProject.Core.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventProject.Core.Entities
{
    public class Customer : BaseEvent
    {
        public string CustomerName { get; set; }
        public int CustomerAge { get; set; }
        
        [RegularExpression("^(0(\\d{3}) (\\d{3}) (\\d{2}) (\\d{2}))$", ErrorMessage = "Hatalı giriş yaptınız.")]
        public string CustomerPhone { get; set; }

        public virtual IList<Ticket> Tickets { get; set; }

    }
}

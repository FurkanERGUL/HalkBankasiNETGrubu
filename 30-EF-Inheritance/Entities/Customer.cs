using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace _30_EF_Inheritance.Entities
{
    public class Customer : BasePerson
    {
        public DateTime LastPurchaseDate { get; set; }
        public int TotalVisits { get; set; }

    }
}

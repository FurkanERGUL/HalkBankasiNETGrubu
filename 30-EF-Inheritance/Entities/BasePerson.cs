using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_EF_Inheritance.Entities
{
    public abstract class BasePerson
    {
        public int Id { get; set; }
        public string PersonName { get; set; }
        public DateTime BirthDate { get; set; }

    }
}

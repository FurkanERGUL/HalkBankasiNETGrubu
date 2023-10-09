using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_EF_Inheritance.Entities
{
    public class Employee : BasePerson
    {
        public DateTime AdmissonDate { get; set; }
        public string JobDescription { get; set; }

    }
}

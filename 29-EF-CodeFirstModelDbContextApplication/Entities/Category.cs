using _29_EF_CodeFirstModelDbContextApplication.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_EF_CodeFirstModelDbContextApplication.Entities
{
    public class Category : BaseEntity
    {
        //public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        //public Status CategoryStatu { get; set; } = Status.Active;

        public virtual IList<Product> Products { get; set; }
    }
}

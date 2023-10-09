using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_EF_CodeFirstModelDbContextDbSet.Entities
{
    public class Book
    {
        public int BookID { get; set; } //Primary Key
        public string BookTitle { get; set; }

        public string BookSubject { get; set; }
        public int AuthorID { get; set; } //Foreign Key

        public virtual Author Author { get; set; }
    }
}

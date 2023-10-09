using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_EF_DataAnnotationFluentAPI.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public DateTime AuthorBirthDate { get; set; }

        //[NotMapped]
        public int AuthorAge { get; set; }

        public Deneme Deneme { get; set; }

        public List<Book> Books { get; set; }
    }

    //[NotMapped]
    public class Deneme
    {
        public int DenemeId { get; set; }
    }
}

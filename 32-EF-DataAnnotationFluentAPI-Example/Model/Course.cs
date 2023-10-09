using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_EF_DataAnnotationFluentAPI_Example.Model
{
    public class Course : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Student> Students { get; set; }
        public Teacher Teacher { get; set; }
        public int TeacherId { get; set; }

    }
}

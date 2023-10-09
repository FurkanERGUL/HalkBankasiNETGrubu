using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_EF_DataAnnotationFluentAPI_Example.Model
{
    public class Student : BaseEntity
    {
        public string Name { get; set; }
        public List<Course> Courses { get; set; }
    }
}

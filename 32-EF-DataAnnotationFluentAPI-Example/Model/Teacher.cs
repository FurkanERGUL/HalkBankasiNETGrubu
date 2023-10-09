using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_EF_DataAnnotationFluentAPI_Example.Model
{
    public class Teacher : BaseEntity
    {

        public string Name { get; set; }
        
    }
}

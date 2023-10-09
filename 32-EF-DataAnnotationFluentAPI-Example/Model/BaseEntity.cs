using _32_EF_DataAnnotationFluentAPI_Example.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_EF_DataAnnotationFluentAPI_Example.Model
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public DateTime? DeleteTime { get; set; }
        public Statu Statu { get; set; }

    }
}

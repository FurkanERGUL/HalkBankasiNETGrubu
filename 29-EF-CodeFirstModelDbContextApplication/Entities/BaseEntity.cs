using _29_EF_CodeFirstModelDbContextApplication.Enums;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_EF_CodeFirstModelDbContextApplication.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreateTime { get; set; } = DateTime.Now;
        public DateTime? UpdateTime { get; set; }
        public DateTime? DeleteTime { get; set; }
        public Status Statu { get; set; } = Status.Active;
    }
}
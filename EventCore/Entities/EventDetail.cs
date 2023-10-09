using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventProject.Core.Entities
{
    public class EventDetail
    {
        [Key]
        public int EventDetailId { get; set; }

        [RegularExpression("^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{4,6}$", ErrorMessage ="Hatalı giriş yaptınız.")]
        public string EventPhone { get; set; }

        [EmailAddress(ErrorMessage ="Yanlış formatta giriş yaptınız")]
        public string EventMail { get; set; }

        //Ref
        public virtual Event Event { get; set; }
    }
}

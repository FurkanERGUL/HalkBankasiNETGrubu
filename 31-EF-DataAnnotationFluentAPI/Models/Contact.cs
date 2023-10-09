using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_EF_DataAnnotationFluentAPI.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        ////Hiçbir otomatik oluşturma veya değer ataması istemiyoruz.

        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //Kolonu identity yapar
        public string Email { get; set; }
        public string Subject { get; set; }

        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        //Bir kolunun değerlerinin bir hesaplama veya ifade sonucunda otomatik olarak belirler. 
        public DateTime LastAccesed { get; set; }
    }
}

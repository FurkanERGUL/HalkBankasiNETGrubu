using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_EF_DataAnnotationFluentAPI.Models
{
    //Data Annotations, model sınıflarımızın üzerine eklediğimiz niteliklerdir.
    //Bu nitelikler veritabanı tablo ve sütun yapılarını belirlemek, uygulamak
    //ve doğruluk kontrollerini yapmamızı sağlar. 
    //[Table("TblBook")]
    public class Book
    {
        //[Key]
        public int BookId { get; set; }

       // [Required]
       // [MaxLength(50)]
        //[StringLength(50)] Nesne tarafında kontrol gerçekleştirir
        public string BookName { get; set; }

        //[Required(ErrorMessage ="*")]
        //[Column("ClmBookSubject", Order = 2 , TypeName ="nvarchar(50)")]
        public string BookSubject { get; set; }

        //[ForeignKey("Author")]
        public int AuthorFKId { get; set; }

        //[ConcurrencyCheck]
        
        // Eş zamanlı kontrol sağlar aynı anda birden fazla              
        // satışa engel olur. Yani bir kullanıcı bir veriyi okurken başka bir
        // kullanıcı tarafında bu veri değiştirildiyse veya kaydedildiyse, 
        // veriyi kaydetmeye çalışana hata verir.
        //Genellikle eş zamanlı güncelllemelerin kontrolü için kullanılır
        public int BookStock { get; set; }

        public Author Author { get; set; }
    }
}

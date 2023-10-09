using Movie.DATA.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.DATA.Concrete
{
    public class FilmDetail : BaseFilm
    {
        [Column(TypeName = "text")]
        public string FilmDetails { get; set; }
        public int FilmId { get; set; }
        public virtual Film Film { get; set; }
    }
}

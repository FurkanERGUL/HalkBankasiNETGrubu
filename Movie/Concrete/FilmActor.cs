using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.DATA.Concrete
{
    public class FilmActor
    {
        public int ActorID { get; set; }
        public int FilmID { get; set; }
        public int WorkDay { get; set; }


        public virtual Film Film { get; set; }
        public virtual Actor Actor { get; set; }

    }
}

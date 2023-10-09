using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_OOP_AbstractLAB
{
    public abstract class MuzikAleti
    {
        public string Markasi { get; set; }
        public string Aciklamasi { get; set; }

        public abstract string Cal();
    }
}

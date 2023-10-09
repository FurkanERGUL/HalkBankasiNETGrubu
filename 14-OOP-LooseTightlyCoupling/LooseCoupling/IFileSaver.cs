using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_OOP_LooseTightlyCoupling.LooseCoupling
{
    public interface IFileSaver
    {
        public void SaveFile(string filename, string contents);
    }
}

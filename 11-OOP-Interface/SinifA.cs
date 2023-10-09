using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace _11_OOP_Interface
{
    public class SinifA : IBicim
    {
        private int _numaram;
        public int Numaram 
        {
            get { return _numaram; }

            set { _numaram = value; }
        }

        public void InterfaceMetot()
        {
            Console.WriteLine("Numara: {0}", _numaram);
        }
    }
}

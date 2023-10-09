using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_OOP_InterfaceLAB
{
    public interface IFutbolcu
    {
        string AdiSoyadi { get; set; }
        string FormaNo { get; set; }

        byte SutGucu { get; set; }
        byte Refleks { get; set; }
        byte Hiz { get; set; }
        byte Agresiflik { get; set; }

        bool FormdaMi { get; set; }

        void SutCek();
        void PasVer();


    }
}

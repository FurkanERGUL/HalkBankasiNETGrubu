using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_OOP_InterfaceLAB
{
    public class Kaleci : IFutbolcu, IKaleci
    {
        public string AdiSoyadi { get; set; }
        public string FormaNo { get; set; }
        public byte SutGucu { get; set; }
        public byte Refleks { get; set; }
        public byte Hiz { get; set; }
        public byte Agresiflik { get; set; }
        public bool FormdaMi { get; set; }
        public string KurtarmaGucu { get; set; }

        public void PasVer()
        {
            Console.WriteLine("Pas Verildi...");
        }

        public void SutCek()
        {
            Console.WriteLine("Şut Çekild...");
        }

        public void TopKurtar()
        {
            Console.WriteLine("Top Kurtarıldı...");
        }
    }
}

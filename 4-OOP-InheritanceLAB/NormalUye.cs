using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_OOP_InheritanceLAB
{
    public class NormalUye : BaseUye
    {
        //protected int yillikucret;
        public NormalUye()
        {
            Console.WriteLine("NormalUye Parametresiz Alt Yapici");
        }
        public NormalUye(string notlar): base("Fatih", 2021)
        {
            Console.WriteLine("Notlar = {0}",notlar);
        }
        public NormalUye(string notlar, string uyeAdi, int uyeTarihi) : base(uyeAdi, uyeTarihi) 
        {
            Console.WriteLine("NormalUye 4 Parametreli Alt Yapici");
            Console.WriteLine("Notlar = {0}", notlar);
        }

        public void NormalUyeAidatHesapla()
        {
            _yillikUcret = 300 * 12;
        }

    
        public override string ToString()
        {
            return base.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_OOP_InheritanceLAB
{
    public class VIPUye : BaseUye
    {
        public VIPUye(string uyeAdi, int uyelikTarihi) : base (uyeAdi, uyelikTarihi)
        {
            Console.WriteLine("VIP Uye 2 Parametreli Ana Yapıcı");
        }
        public void VIPUyeAidatHesapla()
        {
            _yillikUcret = 500 * 12 + 2000;
        }
    }
}

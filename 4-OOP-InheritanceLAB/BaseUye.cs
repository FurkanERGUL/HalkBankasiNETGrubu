using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_OOP_InheritanceLAB
{
    public class BaseUye
    {
        private string _uyeId = Guid.NewGuid().ToString().Substring(1,4);
        private string _uyeAdi;
        private int _uyelikTarihi;
        protected int _yillikUcret;

        public BaseUye()
        {
            Console.WriteLine("BaseUye Paremtresiz Ana Yapıcı");
        }

        public BaseUye(string uyeAdi, int uyelikTarihi)
        {
            Console.WriteLine("BaseUye Parametreli Ana Yapıcı");
            _uyeAdi = uyeAdi;
            _uyelikTarihi = uyelikTarihi;
        }

        public override string ToString()
        {
            return "\nUye Adi: " + _uyeAdi + "\nUye Id: " + _uyeId + "\nUye Kayit Tarihi: " + _uyelikTarihi + "\nYillik Ucret: " + _yillikUcret;
        }
    }
}

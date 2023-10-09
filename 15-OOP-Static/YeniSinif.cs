using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_OOP_Static
{
    public class YeniSinif
    {
        private string mesaj = "Merhaba Dünya";
        public string Adi { get; set; }
        public void AdiGoster()
        {
            Console.WriteLine("Adınız = {0}, Yaşınız = {1}", Adi, Yas);
        }

        public static string selam = "Günaydın";
        public static int Yas { get; set; } = 20;
        public static void YasGoster()
        {
            Console.WriteLine("Yaşınız = {0}", Yas);
        }
    }
}

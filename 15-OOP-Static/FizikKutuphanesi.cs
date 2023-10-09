using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_OOP_Static
{
    public static class FizikKutuphanesi
    {
       
        public static decimal YerCekimiKuvveti { get { return 9.80665M; } }

        //Const => Sabit değer kendiliğinden static olma özelliğine sahiptir. dolayısıyla static olarak işaretlenemez.
        public const int KaldirmaKuvveti = 12;

        public static readonly int IndirmeKuvveti = 2;

        public static void Kaldir() 
        {
            Console.WriteLine("Kaldırma kuvveti");
        }

        //Static class'larda Constructor olamaz.
        //public FizikKutuphanesi()
        //{

        //}
    }
}

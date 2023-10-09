using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_OOP_Abstract
{
    //Abstract Sınıflar, sadece base class olarak davranmasını ve kendisinden inherit edilbilmesi istediğimiz durumlarda kullanırız.

    //Abstract(Soyut) Sınıflar, bir sınıfı abstract olarak bildirmek için, abstract anahtar sözcüğü class anahtar sözcüğünden önce kullanılır.
    public abstract class YeniAbstractClass
    {
        private string mesaj = "Merhaba Dünya";
        public void MesajYaz()
        {
            Console.WriteLine(mesaj);
        }

        //Abstract Class'ların en büyük özelliği, içerisinde Abstract olan yada olmayan metotlar barındırabilmesidir. Abstract metotlar, kalıtım aldığı class'ta impelement edilerek kullanılacak metotlardır. Yani tanımlandığı yerde herhangi bir kod bloğu barındırmazlar.
        public abstract void MesajYazAbstract();

        //Kurallar
        //1-Abstract metotlar private olmaz.
        //2-Abstract metot sadece Abstract bir class'ın içierinde tanımlanabilir.
        //3-Virtual olarak tanımlanamaz. Abstract class virtual'dır.
        //4-Abstract class Static olarak tanımlanamazlar.
        //5-Abstract metodun gövdesi olmaz.
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_OOP_Class
{
    public class Person
    {
        //Constructor, yapıcı metot. Görevi nesne oluştuğunda anda ilk çalışan metot.
        public Person()
        {
            Console.WriteLine("Instance gerçekleşti...");
        }

        public Person(string personelIsmi)
        {
            this._personelIsmi = personelIsmi;
        }

        //Fields(Alan) - Properties(Özellik) - Method (Metot) - Constructor(Yapıcı Metot)

        //Fields(Alan): Yalnızca sınıfın içerisinde bildirilen değişkendir.
        private string _personelIsmi;
        private const int _saatlikUcret = 350;
        private int _sure;

        //Properties(Özellik)
        public string PersonelIsmi 
        {
            get
            {
                return _personelIsmi.ToUpper();
            }
            set //Değişkene yükleme yaptığımda çalışacak alan.
            { 
                _personelIsmi = value;
            } 
        }

        public int Sure 
        {
            //Encapsulation, datayı kontrollü bir şekilde içeri almak.
            get 
            {
                return _sure;
            }
            set
            {
                if (value > 0)
                {
                    _sure = value;
                }
                else
                {
                    Console.WriteLine("0 ve 0 dan değer girilemez");
                    _sure = 1;
                }
            }
        }

        public string PersonelNo { get; set; }

        public void MesajYaz()
        {
            Console.WriteLine("Maaş Hesaplanıyor...");
        }

        public int MaasHesapla()
        {
            MesajYaz();
            int personelMaas;
            personelMaas = _sure * _saatlikUcret;
            if (_sure>0)
            {
                return personelMaas;
            }
            else
            {
                return 0;
            }
        }

        //Metot Overloading
        public int MaasHesapla(int avans)
        {
            MesajYaz();
            int personelMaas;
            personelMaas = (_sure * _saatlikUcret)+avans;
            if (_sure > 0)
            {
                return personelMaas;
            }
            else
            {
                return 0;
            }
        }
    }
}

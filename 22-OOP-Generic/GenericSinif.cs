using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_OOP_Generic
{
    //Kısıtlamalar
    //1) class anahtar kelimesini constraints (kısıtlama) olarak belirtirsem sadece referans tipli değer atanacağı garanti etmiş olurum.
    //2) struct anahtar kelimesini constraints (kısıtlama) olarak belirtirsem sadece value tipli değer atanacağı garanti etmiş olurum.
    //3) Base class ismini constraints (kısıtlama) olarak belirtirsem sadece base class ve ondan türeyene sub class'ların atanacağını garanti etmiş olurum.
    public class GenericSinif<T> where T : class
    {

        private T _id;

        public T[] _dizi = new T[5];

        public T ID { get; set; }
        public T Name { get; set; }
        public int Age { get; set; }

        public void Deneme<T>(T entity)
        {
            Console.WriteLine("deneme");
        }

        public void VeriEkle(T index, T data)
        { 
            //komutlar...
        }

        public void VeriEkle(string index, T data)
        { 
            //komutlar...
        }

        public T VeriGetir(int index)
        {
            if (index >=0 && index<5)
            {
                return _dizi[index];
            }
            else
            {
                return default(T); //T tipi ne gelirse onun default değerini return etsin demek.
            }
            
        }
    }

    public class GenericOlmayanSinif
    {
        public void EkranaYaz<T>(T veri) where T : struct 
        {
            Console.WriteLine();
        }
    }
}

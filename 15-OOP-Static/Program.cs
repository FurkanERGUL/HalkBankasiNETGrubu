namespace _15_OOP_Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Static Class
            //Eğer nesneye bağımlı işlemler gerçkleştirmiyorsanız. Yani sadece amaç belirli bir duruma hizmet eden birden fazla öğeyi bir araya toplamak ise ilgili sınıfı static olarak işaratleyebilir ve içerisinde tüm öğeleri instance'dan bağımsız olarak kullanabilirsiniz.

            //Static sınıfların içinde yalnizca static öğeler bulunabilir. (Field, Property, Method...)

            //Static sınıflar bir başka sınıftan kalıtım alamazlar. .NET Framework mantığında tüm yapılar System.Object'den kalıtım alırlar. Static sınıfda bu kalıtım işlemine dahildir.

            //Math ve File

            //Static sınıflar ufakta olsa perfomans kaybına neden olur.

            YeniSinif.Yas = 36;
          

            YeniSinif yeniSinif1 = new YeniSinif();
            yeniSinif1.Adi = "Fatih";
            yeniSinif1.AdiGoster();

            YeniSinif.Yas = 26;

            YeniSinif yeniSinif3 = new YeniSinif();
            yeniSinif3.Adi = "Fevzi";
            yeniSinif3.AdiGoster();

            
        }
    }
}
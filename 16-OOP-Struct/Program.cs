namespace _16_OOP_Struct
{
    public struct Kitap
    {
        public string Adi;
        public string Yazar;
        public int SayfaSayisi;
        public string Turu;

        public Kitap(string adi, string yazar, int sayfaSayisi, string turu)
        {
            Adi = adi;
            Yazar = yazar;
            SayfaSayisi = sayfaSayisi;
            Turu = turu;
        }
    }
    internal class Program
    {
        //Struct, farklı veri tiplerinden oluşan karma bir yapıdır. Sınıflara benzer onlar gibi tanımlanır, nesneleri onlar gibi yaratılır. (Fields, Properties, Method, *Constructor içerebilirler.

        //Sınıflar belleğin heap bölgesinde tutulurken Struct ise belleğin stack kısmında tutulurlar. Kısacası Value Type Dır.

        //1) Struct yapılarda New anahtar kelimesi kullanılamaz diye bir kavram yoktur. Kullanım amacı farkı vardır. New anahtar kelimesi nesne oluşturmak amacıyla değil. Struct (Yapı) üyelerinine değerlerine defacult (varsayılan) değer yüklmesi yapılmak için kullanılır.
        //2) Boş Constructor Tanımlanamaz.
        //3) Eğer Constructor Tanımlayacaksak Parametreli olmak zorunda ve metot içerisinde değerler başlangıç değerlerini atamak zorundadır.
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Kitap kitap1;
            kitap1.Adi = "Sultanı Öldürmek";
            kitap1.Yazar = "Ahmet Ümit";
            kitap1.SayfaSayisi = 230;
            kitap1.Turu = "Polisiye";

            Kitap kitap2;
            kitap2.Adi = "Dünyanın Son Günü";
            kitap2.Yazar = "Beyazıt Akman";
            kitap2.SayfaSayisi = 230;
            kitap2.Turu = "Tarih";

            Kitap kitap3 = new Kitap("Mihmindar", "İskender Pala", 150, "Edebiyat");



            Console.WriteLine(kitap1.Adi);

            Kitap kitap5 = new Kitap();
            Console.WriteLine(kitap5.Adi);
            Console.WriteLine(kitap5.SayfaSayisi);
        }
    }
}
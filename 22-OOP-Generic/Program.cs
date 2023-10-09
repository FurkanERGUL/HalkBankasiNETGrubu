namespace _22_OOP_Generic
{
    internal class Program
    {
        //Generic, C# programlama dilinde yeniden kullanılabilir, type-safe (tip güvenli) kodunun oluşturulmasına veya oluşmasına izin veren bir özelliğidir.
        static void Main(string[] args)
        {
            PrintData<string>("Merhaba Dünya");

            PrintData<int>(110);

            PrintData<bool>(true);

            //******************

            GenericSinif<string> ogrenci = new GenericSinif<string>();
            ogrenci.ID = "5";
            ogrenci.Name = "Fatih";
            ogrenci.Age = 30;

            //GenericSinif<int> ogrenci2 = new GenericSinif<int>();
            //ogrenci2.ID = 4;
            //ogrenci2.Name = 21312;
            //ogrenci2.Age = 30;

            AnahtarDegerIkilisi<int, string> anahtarDegerIkilisi = new AnahtarDegerIkilisi<int, string>();
            anahtarDegerIkilisi.Id = 1;
            anahtarDegerIkilisi.Name = "Fatih";
            anahtarDegerIkilisi.BirthDate = new DateOnly(2000, 5, 6);
        }

        public static void PrintData<T>(T data)
        {
            Console.WriteLine("Data: " + data);
        }
    }
}
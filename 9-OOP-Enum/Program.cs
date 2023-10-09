namespace _9_OOP_Enum
{
    enum Mevsim
    { 
        Kıs=1, Ilkbahar=5, Yaz=7, Sonbahar=9
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Mevsim localDegisken = Mevsim.Yaz;

            Console.WriteLine("Seçilen Mevsim: {0}", localDegisken);
            Console.WriteLine("Seçilen Mevsim: {0}", (sbyte)localDegisken);

            //Personel personel = new Personel();
            //personel.Name = "Fatih";
            //personel.Departman = Departmanlar.Yazilim;
        }
    }
}
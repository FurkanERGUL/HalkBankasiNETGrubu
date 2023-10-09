namespace _11_OOP_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SinifB sinifB = new SinifB();
            sinifB.numaralar = 8;
            sinifB.NumarayaEkranaYaz();

            IBicim sinifA = new SinifC();

            sinifA.Numaram = 5;
            sinifA.InterfaceMetot();
        }
    }
}
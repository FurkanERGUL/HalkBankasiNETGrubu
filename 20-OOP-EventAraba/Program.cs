namespace _20_OOP_EventAraba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Araba araba = new Araba() { Model = "TOGG", Hız = 40 };
            //3. Aşama
            araba.HizAsimi += new HizAsimiEventHandler(HizLimiti);

            for (int i = 10; i < 250; i += 10)
            {
                araba.Hız += i;
                Console.WriteLine("Arabanın Şuanki Hızı: " + araba.Hız);
                Thread.Sleep(1000);
            }

        }
        public static void HizLimiti()
        {
            Console.WriteLine("Araç Hız Limitini Aştı...");
        }
    }
}
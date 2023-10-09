namespace _50_ASENKRON_Programlama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task bekletme (Wait, WaitAll, WaitAny)

            /*
             -Wait: İlgili task tamamlanması bitmedenbir sonraki kod satırı çalıştırılmaz.
             -WaitAll: Parametredeki taslardan hepsi tamamlanmadan kod satırı çalıştırılmaz.
             -WaitAny: Parametredeilerden herhangi biri bitmeden sonraki çalışmaz.
             */


            //StartSchool().Wait();

            Task.WaitAll(StartSchool(), TeachClass12()); //İkisi kendi içerisinde asenkron dışarıya senkron
            //TeachClass12();
            TeachClass11();
            Console.WriteLine("************************************************************");
            Task.WaitAny(StartSchool(), TeachClass12()); //Biri çalışırsa sistem asenkron çalışmaya başlar.
            //TeachClass12();
            TeachClass11();
            Console.ReadLine();
            //Async (içerisinde aseknron işlem yapılacak metodu belirtir.), Await(Asenkron olarak işaretlenen methoda asenkron çalışacak komutları temsil eder), Task (asenkron methodu temsil eder)
        }

        public static async Task StartSchool()
        {
            await Task.Delay(8000);
            Console.WriteLine("Okul başladı");
        }

        public static async Task TeachClass12()
        {
            await Task.Delay(3000);
            Console.WriteLine("12. sınıf başladı");
        }
        public static async Task TeachClass11()
        {
            await Task.Delay(2000);
            Console.WriteLine("11. sınıf başladı");
        }

        #region Senkron
        //public static void StartSchool()
        //{
        //    Thread.Sleep(8000);
        //    Console.WriteLine("Okul başladı");
        //}
        //public static void TeachClass12()
        //{
        //    Thread.Sleep(3000);
        //    Console.WriteLine("12. sınıf eğitime başladı");
        //}
        //public static void TeachClass11()
        //{
        //    Thread.Sleep(2000);
        //    Console.WriteLine("11. sınıf eğitime başladı");
        //}
        #endregion

    }
}
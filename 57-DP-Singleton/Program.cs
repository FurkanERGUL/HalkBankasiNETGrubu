namespace _57_DP_Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Herkes kafasına göre oluşturamamalı
            //EagerSingleton eagerSingleton = new EagerSingleton();
            var a = EagerSingleton.GetInstance();
            var b = EagerSingleton.GetInstance();
            if (a==b)
            {
                Console.WriteLine("Neden?");
            }



            SampleSingleton sampleSingleton1 = SampleSingleton.CreateSampleSingleton();
            sampleSingleton1.Data = "FF";


            SampleSingleton sampleSingleton2 = SampleSingleton.CreateSampleSingleton();
            SampleSingleton sampleSingleton3 = SampleSingleton.CreateSampleSingleton();

            Console.WriteLine($"Nesne sample'ı = {sampleSingleton1.Data}");
            Console.WriteLine($"Nesne sample'ı = {sampleSingleton2.Data}");
            Console.WriteLine($"Nesne sample'ı = {sampleSingleton3.Data}");

            if ( sampleSingleton1 == sampleSingleton2 && sampleSingleton1 == sampleSingleton3 && sampleSingleton2 == sampleSingleton3 )
            {
                Console.WriteLine("FF kazandı!");
            }
        }
    }
}
namespace _51_TASK_Kullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TASK asenkron programalmada yapıalcak işleri temsil eder. Bir işin tamamlanıp tamamlanmadığınıyani durum bilgisini bize söyleyebilir. Eğer işlem bir sonuç verirse task bize bu sonucu bildirir.

            //Void=>TASK -----GeryeDegerDonuyorsa=>Task<TResult>

            //Task oluşturmanının 3 yöntemi vardır.
            //1)Task.Factory.StartNew
            //2)Task Instance
            //3)Task.Run Metodu


            #region Task-1
            //Task'laştırma
            //var task = new Task(() => GetRandomNumber());
            //task.Start();
            #endregion

            #region Task-2
            //Task.Run(() => GetRandomNumber());
            #endregion

            #region Task-3
            //Task.Factory.StartNew(() => GetRandomNumber());
            #endregion

            #region Task-4
            //Task<int> task = Task.Run(() => GetRandomNumber());
            //Console.WriteLine("Task sonucu: "+task.Result);
            #endregion



            Console.WriteLine("Program başladı");
            Console.ReadLine();
        }

        static int GetRandomNumber()
        {
            Thread.Sleep(3000);
            var random = (new Random().Next(1,100));
            Console.WriteLine($"Rastgele sayı: {random}");
            return random;
        }
    }
}
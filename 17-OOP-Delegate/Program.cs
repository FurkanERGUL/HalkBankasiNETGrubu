namespace _17_OOP_Delegate
{
    internal class Program
    {
        //Delegate, bir metoda atıfta bulunan nesnedir. Bir başka deyişle metotlara referans oluşturabilen refens tipli değişkendir.

        //Basit bir ifadeyle delegateler belirli parametrelere ve dönüş tipine sahip metotları üzerinde taşıyabilen ve gerektiği anda kullanabilen yapılardır.

        //İpucu: Metotları kapsüllemek (encapsulate) için iyi bir yol sağlar. Genellikle Call-back olarak bilenen metotların ve eventlerin uygulanmasında kullanılır.

        //Syntax:
        //Acces Modifer - delegate - return type - delegate name - parametre list?
        static void Main(string[] args)
        {
            #region SingleCagirma
            //Delegate Kullanimi
            //numDelegate sumDelegate = new numDelegate(Sum);
            //sumDelegate(10, 5);

            //numDelegate subtractDelegate = new numDelegate(Subtract);
            //subtractDelegate(10, 5);
            #endregion

            #region MultiCastingCagirma
            //CalculateDelegate calculateDelegate = new CalculateDelegate(Area);
            //calculateDelegate += Perimeter;

            //calculateDelegate(20, 50);

            //calculateDelegate.Invoke(25, 25);
            #endregion

            #region PredicateDelegateCagirma
            //Predicate<int> predicate = IsTeenger;
            //Console.WriteLine(predicate(23));
            #endregion

            #region FuncDelegateCagirma

            //Func<int, int, int> func = Sum1;
            //int result = func(5, 3);
            //Console.WriteLine("Toplam: " + result);

            #endregion

            #region ActionDelegateCagirma
            Action<string> action = ConsolePrint;
            action("Ders Bitti");
            #endregion
        }

        #region SingleDelegateKullanimi
        //Geriye değer döndürmeyen iki adet parametre bir delegate tanımlıyoruz.
        public delegate void numDelegate (int a, int b);

        public static void Sum(int a, int b) 
        {
            Console.WriteLine("Toplam: {0}", a+b);
        }

        public static void Subtract(int a, int b)
        {
            Console.WriteLine("Fark: {0}", a-b);
        }
        #endregion

        #region MulticastingDelegate
        //Tek bir çağrıda birden fazla metodu işaret etmesine yardımcı olur
        //'+' veya '+=' opertörlerini kullanicam.
        //'-' veya '-=' opertörlerini kullanicam.
        //First in First out (FIFO) İlk giren ilk çıkar.
        public delegate void CalculateDelegate(int width, int height);

        public static void Area(int width, int height)
        {
            Console.WriteLine("Alan {0}", (height*width));
        }

        public static void Perimeter(int width, int height) 
        {
            Console.WriteLine("Çevre {0}", (2*(height+width)));
        }

        #endregion

        #region PredicateDelegate
        //Belirli kiriterler içeren metotlarla çalışır ve verilen kriterlerin karşılanıp karşılanmadığına bakar. (Geriye bool döner.)
        public static bool IsTeenger(int age)
        {
            if (15<age && age<25)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

        #region FuncDelegate
        //Geriye belirli bir değer döndüren delegate türüdür. (16 adeta kadar parametre alabilir ama son parametre geriye dönüş parametresidir.)
        public static int Sum1 (int x, int y) 
        { 
            return x+ y;
        }

        #endregion

        #region ActionDelegate
        //Function delegate ile aynıdır. Geriye değer dönmez Void'dir.
        public static void ConsolePrint(string text)
        {
            Console.WriteLine(text);
        }
        #endregion
    }
}
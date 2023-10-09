using _56_SOLIDPrensipleri._05_DependencyInversion.GoodImplementation;

namespace _56_SOLIDPrensipleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlRepository sqlRepository= new SqlRepository();
            SqlService sqlService = new SqlService(sqlRepository);
        }
    }
}
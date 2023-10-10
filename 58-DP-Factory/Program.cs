namespace _58_DP_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var gamePC = FactoryClass.FactoryMethod(ModelPC.GamerPC, "16", "1TB", "I7");

            var developerPC = FactoryClass.FactoryMethod(ModelPC.DeveloperPC, "8", "1TB", "I5");
            Console.WriteLine("Game pc"+gamePC.ToString());
            Console.WriteLine("Developer pc"+developerPC.ToString());
        }
    }
}
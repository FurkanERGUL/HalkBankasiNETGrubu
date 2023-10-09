using _3_OOP_Inheritance;

internal class Program
{
    private static void Main(string[] args)
    {
        BasePhone basePhone = new BasePhone("AEG","Kablolu Bağlanti");
        Console.WriteLine($"Telefon Markası: {basePhone.Brand} \n Durumu: {basePhone.Call()}" );

        MobilePhone mobilePhone = new MobilePhone(true, false, "Nokia", "3G");
        Console.WriteLine($"Telefon Markası: {mobilePhone.Brand} \n Durumu: {mobilePhone.Call()}");
        Console.WriteLine(mobilePhone.ToString());

        SmartPhone smartPhone = new SmartPhone("Apple", "5G", true, false, true);
        Console.WriteLine($"Telefon Markası: {smartPhone.Brand} \n Durumu: {smartPhone.DoVideoCall()}");

    }
}
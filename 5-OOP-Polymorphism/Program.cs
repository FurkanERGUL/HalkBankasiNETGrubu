using _5_OOP_Polymorphism;

internal class Program
{
    private static void Main(string[] args)
    {
        BasePhone basePhone = new BasePhone();
        basePhone.CallSound();

        Nokia nokia1 = new Nokia() { Brand = "Nokia", Model = "3310", Id = 1, UnitPrice = 15.80m };
        Nokia nokia2 = new Nokia();


        IPhone iphone1 = new IPhone();
        IPhone iphone2 = new IPhone();
        IPhone iphone3 = new IPhone();

        Samsung samsung1 = new Samsung();
        Samsung samsung2 = new Samsung();

        List<BasePhone> phones = new List<BasePhone>() { nokia1, nokia2, iphone1, iphone2, iphone3, samsung1, samsung2 };

        foreach (var phone in phones) 
        {
            phone.CallSound();

            //if (phone.GetType() == typeof(Nokia))
            //{
            //    Nokia nokia = (Nokia)phone;
            //    nokia.CallSound();
            //}
            //else if (phone.GetType() == typeof(IPhone))
            //{
            //    IPhone iphone = (IPhone)phone;
            //    iphone.CallSound();
            //}
            //else if (phone.GetType() == typeof(Samsung))
            //{
            //    Samsung samsung = (Samsung)phone;
            //    samsung.CallSound();
            //}
        }
    }
}
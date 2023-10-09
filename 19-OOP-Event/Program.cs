namespace _19_OOP_Event
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            order.OnCreated += SendEmail.Send; //Subscriber
            order.OnCreated += SendSMS.Send; //Subscriber

            order.Create();

            //Event Handler Çağırma
            OrderEH orderEH = new OrderEH();
            orderEH.OnCreated += SendEmail.Send;
            orderEH.OnCreated += SendSMS.Send;

            orderEH.Create();
        }
    }
}
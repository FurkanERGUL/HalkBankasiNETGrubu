namespace _60_DP_Mediator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IChatMediator mediator = new ChatMediatorImplement();
            User user1 = new UserImplement1(mediator, "FE");
            User user2 = new UserImplement1(mediator, "SA");
            User user3 = new UserImplement1(mediator, "İB");
            User user5 = new UserImplement1(mediator,"FF");

            mediator.AddUser(user5);
            mediator.AddUser(user1);
            mediator.AddUser(user2);
            mediator.AddUser(user3);

            user3.Send("Merhaba C#");
        }
    }
}
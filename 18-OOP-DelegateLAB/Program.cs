namespace _18_OOP_DelegateLAB
{
    internal class Program
    {
        public delegate string Logger(string message);
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        
            string SmsLogger(string message)
            {
                Console.WriteLine("SMS Log: " + message);
                return message;
            }
            string MailLogger(string message) 
            {
                Console.WriteLine("MAIL Log: " + message);
                return message;
            }
            string DBLogger(string message) 
            {
                Console.WriteLine("DB Log: " + message);
                return message;
            }

            Logger logger = new Logger(SmsLogger);
            logger += MailLogger;
            logger += DBLogger;
            logger.Invoke("Hello World");
        }
    }
}
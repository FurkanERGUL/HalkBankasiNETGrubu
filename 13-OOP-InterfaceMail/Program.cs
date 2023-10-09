namespace _13_OOP_InterfaceMail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMailService mailService = new MailToYahoo();

            //Sipariş Alındı
            mailService.From = "info@alkanfatih.com";
            mailService.To = "bilgeadam@bilgeadam.com";
            mailService.Header = "Sipariş Alındı";
            mailService.Body = "Siparişin Bilgileri: 1 Adet IPhone 14 Pro Max";
            mailService.Send();


            //Sipariş Hazırlanıyor
            Console.WriteLine("\n*********************\n");
            mailService.From = "info@alkanfatih.com";
            mailService.To = "bilgeadam@bilgeadam.com";
            mailService.Header = "Sipariş Hazırlanıyor";
            mailService.Body = "Siparişin Bilgileri: 1 Adet IPhone 14 Pro Max";
            mailService.Send();

            //Kargolandı Hazırlanıyor
            Console.WriteLine("\n*********************\n");
            mailService.From = "info@alkanfatih.com";
            mailService.To = "bilgeadam@bilgeadam.com";
            mailService.Header = "Kargolandı";
            mailService.Body = "Kargo bilgisi Aras Kargo: sad7453387";
            mailService.Send();

            //Kargolandı Hazırlanıyor
            Console.WriteLine("\n*********************\n");
            mailService.From = "info@alkanfatih.com";
            mailService.To = "bilgeadam@bilgeadam.com";
            mailService.Header = "Teslim Alında";
            mailService.Body = "Teslim Alan Kişi Komşu Ayşe";
            mailService.Send();
        }
    }
}
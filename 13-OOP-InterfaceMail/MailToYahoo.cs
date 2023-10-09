using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_OOP_InterfaceMail
{
    public class MailToYahoo: IMailService
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Header { get; set; }
        public string Body { get; set; }

        public void Send()
        {
            Console.WriteLine($"Yahoo Üzerinden Mesaj Gönderildi... \nGönderen: {From} \nAlıcı: {To} \nMail Başlığı: {Header} Mail İçerik: {Body} ");
        }
    }
}

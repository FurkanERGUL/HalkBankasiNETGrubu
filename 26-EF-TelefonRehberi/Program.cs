using _26_EF_TelefonRehberi.DbContext;
using _26_EF_TelefonRehberi.Models;

namespace _26_EF_TelefonRehberi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add();
            Select();
            Console.WriteLine("İşlem tamamlandı");

        }
        public static void Add()
        {
            using (RehberContext db = new RehberContext())
            {
                TelefonRehberi rehber1 = new TelefonRehberi();
                rehber1.KisiAd = "Furkan";
                rehber1.KisiSoyad = "ERGÜL";
                rehber1.KisiTelefon = "5355777063";
                db.TelefonRehberis.Add(rehber1);
                //db.Add(rehber1);

                TelefonRehberi rehber2 = new TelefonRehberi();
                rehber2.KisiAd = "Furkan";
                rehber2.KisiSoyad = "ERGÜL";
                rehber2.KisiTelefon = "5355777063";
                db.TelefonRehberis.Add(rehber2);
                //db.Add(rehber2);

                TelefonRehberi rehber3 = new TelefonRehberi();
                rehber3.KisiAd = "Furkan";
                rehber3.KisiSoyad = "ERGÜL";
                rehber3.KisiTelefon = "5355777063";
                //db.TelefonRehberis.Add(rehber3);
                db.Add(rehber3);

                db.SaveChanges();
            }
        }

        public static void Select()
        {
            using (RehberContext db = new RehberContext())
            {
                var rehber = db.TelefonRehberis.ToList();
                foreach (var item in rehber)
                {
                    Console.WriteLine($"Kişi Ad: {item.KisiAd}, Kişi Soyad: {item.KisiSoyad}, Kişi Numara: {item.KisiTelefon}");
                }
            }
        }
    }
}
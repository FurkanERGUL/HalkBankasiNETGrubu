using _33_EF_LifeCycleTrackingSeedData.Contexts;
using _33_EF_LifeCycleTrackingSeedData.Models;
using Microsoft.EntityFrameworkCore;

namespace _33_EF_LifeCycleTrackingSeedData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region AsNoTracking
            //Entity Framework'ün select işlemlerinde döndürdüğü datayı
            //catchleyerek takibe alır bunun sebebi datayı güncelleyip
            //savechange yaptığımızda değişikliklerin kaydedilmesini sağlamaktır
            //AsNoTracking izlemeyi kaldırarak büyük bir performans katkısında bulunur
            using (var context = new AppDbContext())
            {
                //context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

                var authorsNoTrack = context.Authors.AsNoTracking().ToList();
                var author= new Author { FirstName="FF", LastName="Loser" };

                authorsNoTrack.Add(author);


                context.SaveChanges();

                foreach (var item in context.Authors.ToList())
                {
                    Console.WriteLine($"First name: {item.FirstName} -Last Name: {item.LastName}");
                }
            }
            Console.WriteLine("As No Tracking");
            #endregion

            #region LifeCycle
            //EntityLifeCycle bir entity oluşturulduğu anda, eklendiğinde,
            //değiştirilidiğinde, silindiğinde vb. işlemler gerçekleştiğinde
            //entity state dediğimiz yapı da değişir. Bu duruma life cycle denir
            //Entity state ise entity durmunu belirten kavramdır.
            //(eklendi mi?, silindi mi? vb.)

            //System.Data.EntityState'de bulunan bir enum nesnesidir.

            /*
             Added: Entity elendi olarak işaretlenir.
             Deleted: Entity silindi.
             Modified: Değişiklik gerçekleşti.
             Unchanged: Değişiklik olmadı.
             Detached: Entity track edilmedi.
             */

            //EntityState içerik tarafından otomatik olarak belirlenir,
            //ancak geliştirici tarafından manuel olarak da değiştirilebilir.



            using (var context= new AppDbContext())
            {
                //Detached: Henüz context entitysine dahil edilmemiş entity
                //var author1 = new Author() { FirstName = "Peyami", LastName = "Safa" };
                //Console.WriteLine("Yazar durum 1:"+context.Entry(author1).State);

                //context.Entry(author1).State = EntityState.Added;
                //Console.WriteLine("Yazar durum 2:" + context.Entry(author1).State);
                //context.SaveChanges();

                //var aptalPeyami = context.Authors.FirstOrDefault(p=>p.FirstName=="Peyami");
                //Console.WriteLine($"Yazar adı: {aptalPeyami.FirstName} -Soyadı: {aptalPeyami.LastName}");


                //Unchanged:
                //var aptalPeyami = context.Authors.FirstOrDefault(p => p.FirstName == "Peyami");
                //Console.WriteLine($"Yazar adı: {aptalPeyami.FirstName} -Soyadı: {aptalPeyami.LastName}");
                //Console.WriteLine("Yazar durum 3:" + context.Entry(aptalPeyami).State);

                ////Modified:
                //aptalPeyami.FirstName = "aptalpeyami";
                //aptalPeyami.LastName = "cahilsafa";
                //Console.WriteLine($"Yazar adı: {aptalPeyami.FirstName} " +
                //    $"-Soyadı: {aptalPeyami.LastName}");
                //Console.WriteLine("Yazar durum 4:" + context.Entry(aptalPeyami).State);

                ////Deleted:
                //context.Entry(aptalPeyami).State = EntityState.Deleted;
                //Console.WriteLine("Yazar durum 5:" + context.Entry(aptalPeyami).State);
                //context.SaveChanges();

                //var getAuthor2 = context.Authors.ToList();
                //foreach (var item in getAuthor2)
                //{
                //    Console.WriteLine($"Yazar adı: {item.FirstName} " +
                //        $"-Soyadı: {item.LastName}");
                //}

            }
            #endregion


        }
    }
}
using _28_EF_CodeFirstModelDbContextDbSet.Context;
using _28_EF_CodeFirstModelDbContextDbSet.Entities;
using Microsoft.EntityFrameworkCore;

namespace _28_EF_CodeFirstModelDbContextDbSet
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //ADD();
            //READ();
            //UPDATE();
            //REMOVE();
            //READ1();
            //READ2();
            READ3();
        }
        static void ADD()
        {
            /*
            //Author author = new Author() { FirstName = "FF", LastName = "LOST"};
            //using (var context = new AppDbContext())
            //{
            //    context.Authors.Add(author);
            //    context.SaveChanges();
            //}

            //using (var context = new AppDbContext())
            //{
            //    var author = context.Authors.Find(2);

            //    ////I.YOL
            //    Book book1 = new Book()
            //    {
            //        BookTitle = "İntihar Mektuplarım",
            //        BookSubject = "Bir nefret romanı, nefretin en büyüğü kendi ile olan.",
            //        AuthorID = 1
            //    };
            //    ////II.YOL
            //    Book book = new Book()
            //    {
            //        //II.YOL
            //        BookTitle = "Delinin Gözyaşları",
            //        BookSubject = "Kaybolunmuş sokaklarda savrulan gözyaşları.",
            //        Author=author
            //    };
            //    context.Books.Add(book1);
            //    context.SaveChanges();
            //    //context.Books.Add(book);
            //    //context.SaveChanges();
            //}*/
            using (var context = new AppDbContext())
            {
                List<Book> books = new List<Book>() 
                {
                   new Book(){BookTitle="Kahrım ve Ahım", BookSubject="Yok olmuş umutların hikayesi"},
                   new Book(){BookTitle="Kalp Biti", BookSubject="Aşk denen belanın yürekteki izleridir"}
                };
                var authorX = new Author() { FirstName = "FE", LastName = "TIRED", Books = books };
                context.Add(authorX);
                context.SaveChanges();
            }
        }
        static void READ1()
        {
            /*
            //Read entity with Single
            using (var context = new AppDbContext())
            {
                var author1 = context.Authors.Single(author=>author.AuthorID==1);
                Console.WriteLine($"Yazar Adı: {author1.FirstName} - Soyadı: {author1.LastName}");
            }

            //Read with FirstOrDefault
            using (var context = new AppDbContext())
            {
                var author2 = context.Authors.FirstOrDefault(author => author.AuthorID == 1);
                Console.WriteLine($"Yazar Adı: {author2.FirstName} - Soyadı: {author2.LastName}");
            }

            using (var context = new AppDbContext())
            {
                var author3 = context.Authors.Find(1);
                Console.WriteLine($"Yazar Adı: {author3.FirstName} - Soyadı: {author3.LastName}");
            }
            */

            using (var context = new AppDbContext())
            {
                var author4 = context.Authors.ToList();
                foreach (var item in author4)
                {
                    Console.WriteLine($"Yazar Adı: {item.FirstName} - Soyadı: {item.LastName}" +
                        $" Kitapları: {item.Books}");
                }
            }
        }
        static void READ2() 
        {
            using (var context = new AppDbContext())
            {
                //Author author = context.
                List<Author> authorList = context.Authors.ToList();
                List<Book> bookList = context.Books.ToList();

                var KitapYazar = context.Authors.Join(context.Books,
                    a=> a.AuthorID,
                    b=> b.AuthorID,
                    (a,b)=> new
                    {
                        a.FirstName,
                        a.LastName,
                        b.BookTitle
                    }
                    );
                foreach (var item in KitapYazar)
                {
                    Console.WriteLine($"Yazar: {item.FirstName} {item.LastName} ==> {item.BookTitle}");
                }
            }
            
            
        }
        static void READ3() 
        {
            //Eager Loading
            using (var context = new AppDbContext())
            {
                Console.WriteLine("Eager loading");
                var BooksWithAuthor = context.Books.Include(b => b.Author).ToList(); //Eager Loading
                foreach (var item in BooksWithAuthor)
                {
                    Console.WriteLine($"Kitap: {item.BookTitle}=>{item.BookSubject} Yazar: {item.Author.FirstName} {item.Author.LastName}");
                }
            }

            //Lazy Loading
            //İlk yüklemede ana nesne yüklenir ihtiyaç olduğu anda ilişkili neyneyi bulur.
            using (var context = new AppDbContext())
            {
                Console.WriteLine("Lazy Loading");
                var books = context.Books.ToList();
                foreach (var item in books)
                {
                    Console.WriteLine($"Kitap: {item.BookTitle}=>{item.BookSubject} Yazar: {item.Author.FirstName} {item.Author.LastName}");
                }
            }
        }
        static void UPDATE()
        {
            using (var context = new AppDbContext())
            {
                var authorUpdate = context.Authors.Find(2);
                authorUpdate.FirstName = "FF";
                authorUpdate.LastName = "DeathMan";
                //context.Authors.Update(authorUpdate); Bu o kadar da gerekli değil
                context.SaveChanges();
            }
        }
        static void REMOVE()
        {
            using (var context = new AppDbContext())
            {
                context.Authors.Remove(context.Authors.Find(2));
                context.SaveChanges();
            }
        }

    }
}
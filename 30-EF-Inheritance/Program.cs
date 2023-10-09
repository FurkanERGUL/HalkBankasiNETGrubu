using _30_EF_Inheritance.Context;
using _30_EF_Inheritance.Entities;

namespace _30_EF_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                //context.People.Add(new Employee()
                //{ AdmissonDate=DateTime.Now,
                //  BirthDate= new DateTime(1987,03,31),
                //  JobDescription="Engineer",
                //  PersonName="Fatih"
                //});

                //context.People.Add(new Customer()
                //{
                //    BirthDate= new DateTime(1999, 04, 29),
                //    LastPurchaseDate=DateTime.Now,
                //    PersonName="Furkan",
                //    TotalVisits=20

                //});


                //context.People.Add(new Employee()
                //{
                //    AdmissonDate = DateTime.Now,
                //    BirthDate = new DateTime(1997, 03, 21),
                //    JobDescription = "Boss",
                //    PersonName = "Rabia"
                //});

                //context.People.Add(new Customer()
                //{
                //    BirthDate = new DateTime(2009, 05, 08),
                //    LastPurchaseDate = DateTime.Now,
                //    PersonName = "Alperen Oğuz",
                //    TotalVisits = 10

                //});


                //context.SaveChanges();

                var emp = context.Employees.ToList();
                var cus = context.Customers.ToList();
                var people = context.People.ToList();


                people.ForEach(p => 
                {
                    switch (p)
                    {
                        case Employee employee:
                            Console.WriteLine($"İşçi adı {employee.PersonName}");
                            break;
                        case Customer customer:
                            Console.WriteLine($"Müşteri adı {customer.PersonName}");
                            break;
                        default:
                            break;
                    }
                });
                Console.WriteLine("İşlem Başarılı...");
            }
        }
    }
}
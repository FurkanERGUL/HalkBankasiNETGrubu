using EventProject.Core.Entities;
using EventProject.Core.Enums;
using EventProject.Repository.Concrete;
using EventProject.Repository.Contexts;
using EventProject.Repository.Interfaces;
using EventProject.Service.CategoryService;
using EventProject.Service.CustomerService;
using EventProject.Service.EventDetailService;
using EventProject.Service.EventService;
using EventProject.Service.TicketService;

namespace EventProject.ConsoleApp
{
    public class Program
    {
        private static AppDbContext appDbContext;
        
        private static ICategoryRepo categoryRepo;
        private static ICategoryService categoryService;

        private static IEventRepo eventRepo;
        private static IEventService eventService;

        private static IEventDetailRepo eventDetailRepo;
        private static IEventDetailService eventDetailService;

        private static ICustomerRepo customerRepo;
        private static ICustomerService customerService;

        private static ITicketRepo ticketRepo;
        private static ITicketService ticketService;

        public static void Main(string[] args)
        {
            appDbContext= new AppDbContext();

            #region Category İşlemleri
            categoryRepo = new CategoryRepo(appDbContext);
            categoryService = new CategoryService(categoryRepo);

            //CategoryAdd();
            //CategoryList();
            //CategoryUpdate();

            
            #endregion

            #region Evenİşlemleri
            eventRepo = new EventRepo(appDbContext);
            eventService = new EventService(eventRepo);

            //EventAdd();
            //EventList();
            #endregion

            #region EventDetail İşlemleri
            
            eventDetailRepo= new EventDetailRepo(appDbContext);
            eventDetailService= new EventDetailService(eventDetailRepo);

            //EventDetailAdd();

            #endregion

            #region Customer İşlemleri
            customerRepo = new CustomerRepo(appDbContext);
            customerService = new CustomerService(customerRepo);

            //CustomerAdd();
            //CustomerList();
            #endregion

            #region Ticket İşlemleri

            ticketRepo= new TicketRepo(appDbContext);
            ticketService = new TicketService((TicketRepo)ticketRepo);


            #endregion

            TicketAdd();

            Console.WriteLine("İşlemler başarı ile tamamlandı!!");
        }
        public static void CategoryAdd()
        {
            categoryService.Create(new Category { CategoryName = "Tiyatro" });
        }
        public static void CategoryList() 
        {
            var categories = categoryService.GetDefaults(x => x.Status != Status.Passive);
            foreach (var item in categories)
            {
                Console.WriteLine($"Kategori id {item.Id} kategori adı {item.CategoryName}");
            }
        }
        public static void CategoryUpdate() 
        {
            Console.WriteLine("Lütfen güncellemek istediğiniz kategori id'sini giriniz.");
            int catID=Convert.ToInt32(Console.ReadLine());
            var categories=categoryService.GetDefaultById(catID);

            Console.WriteLine("kategori adı"+categories.CategoryName+"Yeni adı giriniz");
            string categoryname=Console.ReadLine();
            categories.CategoryName = categoryname;
            categoryService.Update(categories);
        }
        public static void EventAdd()
        {
            CategoryList();
            Console.WriteLine("Event almak istediğinşiz Id giriniz");
            int catID = Convert.ToInt32(Console.ReadLine());
            var event1 = new Event()
            {
                CategoryId = catID,
                EventName = "Hater",
                EventControlAge = 25,
                EventAttends = 1,
                EventStartDate = DateTime.Now.AddHours(1),
                EventEndDate = DateTime.Now.AddDays(10),
                EventLocation = "myself",
                EventPrice = 1
            };
            eventService.Create(event1);
        }
        public static void EventList()
        {
            var events = eventService.GetDefaults(x => x.Status != Status.Passive);
            foreach (var item in events)
            {
                Console.WriteLine($"\n\nID: {item.Id}, name {item.EventName}, Fiyat {item.EventPrice}, \nbaşlangıç tarihi {item.EventStartDate}, bitiş {item.EventEndDate}, \nkatılım {item.EventAttends}, yaş kontrol {item.EventControlAge}, detaylar {item.EventDetail.EventMail}, {item.EventDetail.EventPhone}");
            }
        }
        public static void EventDetailAdd()
        {
            var eventDetail = new EventDetail { EventDetailId = 4, EventMail = "fu@gmail.com", EventPhone = "frkn" };
            eventDetailService.Create(eventDetail);
        }
        public static void CustomerAdd()
        {
            var customer = new Customer { CustomerName = "Furkan", CustomerAge = 27, CustomerPhone = "888"  };
            customerService.Create(customer);
        }
        public static void CustomerList() 
        {
            var customers = customerService.GetDefaults(x => x.Status != Status.Passive);
            foreach (var item in customers)
            {
                Console.WriteLine($"{item.Id}, {item.CustomerName}, {item.CustomerAge}");
            }
        }
        public static void TicketAdd()
        {
            EventList();
            CustomerList();
            var ticket = new Ticket();
            Console.WriteLine("Lütfen gitmek istediğiniz kişiyi seçin:");
            ticket.CustomerId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Gitmek istenilen etinliği seçiniz:");
            ticket.EventId= Convert.ToInt32(Console.ReadLine());
            ticketService.Create(ticket);
        }
    }
}
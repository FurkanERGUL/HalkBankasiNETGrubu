using _48_MVC_DependencyInjection.Classes;

namespace _48_MVC_DependencyInjection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            //builder.Services.AddTransient 
            //--Her istek(request) için yeni bir nesne örneği oluşturur.
            //--Hafif ve paylaşılabilir olmayan yapılar için daha uygundur.
            //**Her istek için bağımsız bir durum istiyorsak.
            //**Paylaşılması gereken bir durum yoksa

            //builder.Services.AddScoped
            //--Her istek (request) için aynı nesne kullanılır.
            //--İsteğin yaşam döngüsü boyunca aynı nesne üzerinden ilerlemesini sağlar.
            //**HTTP isteği süresince aynı örneği paylaşmasını istiyorsanız
            //**Aynı istek içerisinde birden fazla kez aynı hizmeti kullanmak istiyorsak
            //**Veritabanı gibi ortak kaynakları paylaşmak için uygundur

            //builder.Services.AddSingleton
            //--Uygulama boyunca aynı nesne üzerinden ilerlemeyi sağlar.
            //**Uygulama servisinde yapılandırma ayarları ya da önbellek verileri için kullanılır. 

            builder.Services.AddTransient<IMyService, MyService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
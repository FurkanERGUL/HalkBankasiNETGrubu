namespace _37_MVC_FirstWebPage
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //
            builder.Services.AddControllersWithViews();
            
            //builder.Services.AddMvc();
            //builder.Services.AddMvcCore();

            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("Home/error");
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();

            app.MapControllerRoute(
                name:"default", 
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
using _52_WEB_Identity.Context;
using _52_WEB_Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace _52_WEB_Identity
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            var con = builder.Configuration.GetConnectionString("DefaultConnection")??throw new InvalidOperationException("Connection string bulunamadı");

            builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(con));

            builder.Services.AddIdentity<AppUser, IdentityRole>(options =>
            {
                //PASSWORD AYARLARI
                options.Password.RequireDigit = false; //rakam olmasın dedik
                options.Password.RequireLowercase = false;//küçük harf
                options.Password.RequireUppercase = false;//Büyük harf
                options.Password.RequireNonAlphanumeric = false;//özel karakter
                options.Password.RequiredLength = 3;//en az uzunluk
                ////////////////////////////////////////////////
                

                //User
                options.User.RequireUniqueEmail = true; //özel mail sadece 1 kişide mi olsun
                options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789_";
                //////////////////////////////////////////////////


                //SignIn
                options.SignIn.RequireConfirmedEmail = false; //Eposta onayı olmadan sisteme almaz
                options.SignIn.RequireConfirmedPhoneNumber = false; //Telefon onayı
                options.SignIn.RequireConfirmedAccount = false;
                ////////////////////////////////////////////////////
            
            }).AddEntityFrameworkStores<AppDbContext>();

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

            app.UseAuthentication();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
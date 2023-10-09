using APIProject.Repository.Abstract;
using APIProject.Repository.Concrete;
using APIProject.Repository.Contexts;
using APIProject.Services.Abstract;
using APIProject.Services.Concrete;
using Microsoft.EntityFrameworkCore;

namespace APIProject.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.


            //builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddDbContext<AppDbContext>();

            builder.Services.AddTransient<IEmployeeRepo, EmployeeRepo>();
            builder.Services.AddTransient<IEmployeeService, EmployeeService>();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
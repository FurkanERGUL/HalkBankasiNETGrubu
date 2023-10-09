using _32_EF_DataAnnotationFluentAPI_Example.Context;
using _32_EF_DataAnnotationFluentAPI_Example.Enums;
using _32_EF_DataAnnotationFluentAPI_Example.Model;
using System.Runtime.CompilerServices;

namespace _32_EF_DataAnnotationFluentAPI_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new AppDbContext();
            //context.Courses.Add(
            //    new Course() { Title = "C#", CreateTime = DateTime.Now, UpdateTime = DateTime.Now, DeleteTime = DateTime.Now, Description = "C# anlatımı.", Statu = Statu.active, Teacher = new Teacher() { Name = "Fatih", Statu = Statu.active, CreateTime = DateTime.Now, UpdateTime = DateTime.Now, DeleteTime = DateTime.Now }, 
            //        Students = new List<Student>() 
            //        {new Student()
            //        { 
            //            Name="Furkan", Statu=Statu.active,
            //            CreateTime = DateTime.Now, UpdateTime = DateTime.Now, DeleteTime = DateTime.Now } 
            //        }
            //    }
            //    );

            context.Students.Add(new Student()
            {
                Name = "FF",
                Statu = Statu.active,
                Courses = new List<Course>() { context.Courses.Find(2) }
            });
            context.SaveChanges();
            Console.WriteLine("Başarılı...");
        }
    }
}
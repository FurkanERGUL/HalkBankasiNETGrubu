using _25_EF_DbDirst.DbContext;

namespace _25_EF_DbDirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NorthwindContext db = new NorthwindContext();
            var employees = db.Employees.ToList();
            foreach (var item in employees)
            {
                Console.WriteLine($"ID: {item.EmployeeId}, First Name: {item.FirstName}, Last Name: {item.LastName}");
            }
        }
    }
}
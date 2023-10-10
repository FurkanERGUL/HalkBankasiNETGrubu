namespace _59_DP_Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee= new Employee();
            employee.LoadData();


            //
            Employee employee1= (Employee)employee.Clone();
            employee1.LoadData();
            if (employee1==employee)
            {
                Console.WriteLine("Aynı la bunlar");
            }

            Employee employee2 = (Employee)employee1.Clone();
            List<string> list2 =employee2.GetData();
            list2.Add("Alperen");

            Console.WriteLine("Employee");
            foreach (var item in employee.GetData())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Employee1");
            foreach (var item in employee1.GetData())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Employee2");
            foreach (var item in employee2.GetData())
            {
                Console.WriteLine(item);
            }
        }
    }
}
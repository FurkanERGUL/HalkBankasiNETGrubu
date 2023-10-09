namespace _10_OOP_MaasBordroLAB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maaş Hesaplama Programına Hoş Geldiniz...");

            List<PersonBase> persons = new List<PersonBase>();

            bool status = true;
            while (status)
            {
                Console.Write("Adınız: ");
                string name = Console.ReadLine();

                Console.Write("Doğum Tarihi: " );
                int birthDate = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ünvanı (Mudur|Memur): ");
                string title = Console.ReadLine().ToLower();

                Console.Write("Saatlik Ücret: ");
                double hourlyWage = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Çalışma Saati: ");
                int workingHour = Convert.ToInt32(Console.ReadLine());

                if (title == "memur")
                {
                    persons.Add(new PersonStandard(name,birthDate,hourlyWage,workingHour));
                }
                else 
                {
                    Console.Write("Bonus: ");
                    double bonus = Convert.ToDouble(Console.ReadLine());
                    persons.Add(new PersonAdmin(name, birthDate, hourlyWage, workingHour, bonus));
                }

                Console.WriteLine("\nDevam Mı? (Yes|No): ");
                status = Console.ReadLine().ToLower() == "yes" ? true : false;
                Console.WriteLine(" ");
            }

            Console.WriteLine("*********************");

            foreach (var item in persons)
            {
                item.CalculateWage();
                Console.WriteLine(item.ToString());
            }
        }
    }
}
using _1_OOP_Class;

internal class Program
{
    private static void Main(string[] args)
    {
        Person person = new Person();
        person.PersonelIsmi = "fatih";
        person.PersonelNo = "34";
        person.Sure = 120;
        Console.WriteLine(person.PersonelIsmi + " Maaşı: " + person.MaasHesapla());

        Person person1 = new Person();
        person1.PersonelIsmi = "Mehmet";
        person1.PersonelNo = "35";
        person1.Sure = -20;
        Console.WriteLine(person1.PersonelIsmi + " Maaşı: " + person1.MaasHesapla());

        Person person2 = new Person("Beyazıt");
        Console.WriteLine(person2.PersonelIsmi + " Maaşı: " + person2.MaasHesapla());

        Person person3 = new Person() 
        { 
            PersonelIsmi="Ayşe", 
            PersonelNo="37", 
            Sure=110  
        };

        Console.WriteLine(person3.PersonelIsmi + " Maaşı: " + person3.MaasHesapla());

        Person person4 = new Person("Zeynep") 
        { 
            PersonelNo = "38", 
            Sure = 100 
        };

        Console.WriteLine(person4.PersonelIsmi + " Maaşı: " + person4.MaasHesapla());

        Utu utu1 = new Utu(80) { Fiyat = 650, KazanliMi = false, Marka = "Arçelik", Renk = "Beyaz", Sicaklik = 40 };

    }
}

namespace _8_OOP_AbstractLAB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cello cello = new Cello();
            cello.Markasi = "Cellcon";
            cello.Aciklamasi = "Pahalıdır Entüllektüreldir.";

            Cello cello1 = new Cello();
            cello1.Markasi = "Celllooooo";
            cello.Aciklamasi = "Pahalıdır.";

            Muzisyen cellocu = new Muzisyen();
            cellocu.Adi = "Naime";
            cellocu.Soyadi = "Damataşı";
            cellocu.CaldigiEnstruman = cello;

            Console.WriteLine($"Cello Sanatçısının Adı: {cellocu.Adi} \nSoyadı: {cellocu.Soyadi} \nCello'nun markası: {cellocu.CaldigiEnstruman.Markasi}");
            Console.WriteLine(cellocu.CaldigiEnstruman.Cal());

            Keman keman = new Keman();
            keman.Markasi = "Valencia";
            keman.Aciklamasi = "Ispanyol";

            Muzisyen kemanci = new Muzisyen();
            kemanci.Adi = "Fevzi";
            kemanci.Soyadi = "Hamdemir";
            kemanci.CaldigiEnstruman = keman;

            Console.WriteLine($"Keman Sanatçısının Adı: {kemanci.Adi} \nSoyadi: {kemanci.Soyadi} \nKeman'nın markası: {kemanci.CaldigiEnstruman.Markasi}");

            Gitar gitar = new Gitar();
            gitar.Markasi = "Yamaha";
            gitar.Aciklamasi = "Pahalıdır...";

            Muzisyen gitarist = new Muzisyen();
            gitarist.Adi = "Furkan";
            gitarist.Soyadi = "Ergül";
            gitarist.CaldigiEnstruman = gitar;

            Console.WriteLine($"Gitaristin Adı: {gitarist.Adi} Gitaristin Soyadı: {gitarist.Soyadi} \n Gitar'ının Markası: {gitarist.CaldigiEnstruman.Markasi}");
        }
    }
}
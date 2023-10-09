using _4_OOP_InheritanceLAB;

internal class Program
{
    private static void Main(string[] args)
    {
        NormalUye normal = new NormalUye();

        NormalUye normalUye = new NormalUye("Özel notlar", "Beyazıt", 2022);
        normalUye.NormalUyeAidatHesapla();
        Console.WriteLine(normalUye.ToString());

        VIPUye vIPUye = new VIPUye("Fatih", 2021);
        vIPUye.VIPUyeAidatHesapla();
        Console.WriteLine(vIPUye.ToString());

        string adi = "beyazıt";

        List<string> list = new List<string>();
        list.Add("fatih");
        list.Add(adi);

        Console.WriteLine("********************");

        List<NormalUye> normalUyes = new List<NormalUye>();
        normalUyes.Add(normalUye);
        normalUyes.Add(new NormalUye("Notlar", "Fatih", 2021));

        foreach (var item in normalUyes)
        {
            Console.WriteLine(item.ToString());
        }

        //ChildClass (Alt Sınıfları) BaseClass (Ana Sınıf) üzerinden taşıyabilirim.
        BaseUye[] klubUyeleri = new BaseUye[3] { normalUye, vIPUye, new VIPUye("Şenay",2023) };
        List<BaseUye> baseUyes= new List<BaseUye>() { normalUye, vIPUye, new VIPUye("Şenay", 2023) };

        foreach (var item in baseUyes)
        {
            if (item.GetType() == typeof(VIPUye))
            {
                //Implict Conversion-Explict Conversion
                VIPUye vIPUye1  = (VIPUye)item;
                vIPUye1.VIPUyeAidatHesapla();
            }
            else if(item.GetType() == typeof(NormalUye))
            {
                ((NormalUye)item).NormalUyeAidatHesapla();
            }
        }


    }
}
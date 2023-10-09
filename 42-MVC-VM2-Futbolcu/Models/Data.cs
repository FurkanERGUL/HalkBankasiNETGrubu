namespace _42_MVC_VM2_Futbolcu.Models
{
    public static class Data
    {
        public static List<Futbolcu> Futbolcular = new List<Futbolcu>()
        {
            new Futbolcu
            {
                FutbolcuID= 1,
                FutbolcuAd="Neuer",
                FutbolcuYas=34,
                MevkiID= 1,
                TakimID= 2
            },
            new Futbolcu
            {
                FutbolcuID= 2,
                FutbolcuAd="Cafu",
                FutbolcuYas=52,
                MevkiID= 2,
                TakimID= 1
            },
            new Futbolcu
            {
                FutbolcuID= 3,
                FutbolcuAd="Maldini",
                FutbolcuYas=48,
                MevkiID= 3,
                TakimID= 3
            },
            new Futbolcu
            {
                FutbolcuID= 4,
                FutbolcuAd="Ramos",
                FutbolcuYas=38,
                MevkiID= 3,
                TakimID= 1
            },
        };

        public static List<Takim> Takimlar = new List<Takim>()
        {
            new Takim
            {
                TakimID= 1,
                TakimAd="Real Madrid",
                TeknikDirektor="Carlo Ancelotti"
            },
            new Takim
            {
                TakimID= 2,
                TakimAd="Bayern Münih",
                TeknikDirektor="Jupp Heinnseck"
            },
            new Takim
            {
                TakimID= 3,
                TakimAd="Milan",
                TeknikDirektor ="Stefano Pioli"
            }
        };

        public static List<Mevki> Mevkiler = new List<Mevki>()
        {
            new Mevki
            {
                MevkiID= 1,
                MevkiAd="Kaleci"
            },
            new Mevki
            {
                MevkiID= 2,
                MevkiAd="Bek"
            },
            new Mevki
            {
                MevkiID= 3,
                MevkiAd="Defans"
            }
        };
    }
}

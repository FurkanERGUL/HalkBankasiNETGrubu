using System;
using System.Collections.Generic;

namespace _26_EF_TelefonRehberi.Models
{
    public partial class TelefonRehberi
    {
        public int KisiId { get; set; }
        public string? KisiAd { get; set; }
        public string? KisiSoyad { get; set; }
        public string? KisiTelefon { get; set; }
    }
}

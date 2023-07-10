using System;
using System.Collections.Generic;

#nullable disable

namespace EntityTest.Models
{
    public partial class Telebe
    {
        public Telebe()
        {
            Icazes = new HashSet<Icaze>();
            Qeydiyyats = new HashSet<Qeydiyyat>();
        }

        public int Id { get; set; }
        public string TelebeAd { get; set; }
        public string TelebeSoyad { get; set; }
        public string TelebeAtaAdi { get; set; }
        public string TelebeFin { get; set; }
        public int? TelebeKurs { get; set; }
        public int? IxtisasId { get; set; }
        public string TelebeUnvan { get; set; }
        public string TelebeElaqeNomre { get; set; }
        public string TelebeGmail { get; set; }
        public int? TelebeUniversitetId { get; set; }

        public virtual Ixtisa Ixtisas { get; set; }
        public virtual Universitet TelebeUniversitet { get; set; }
        public virtual ICollection<Icaze> Icazes { get; set; }
        public virtual ICollection<Qeydiyyat> Qeydiyyats { get; set; }
    }
}

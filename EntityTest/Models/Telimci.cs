using System;
using System.Collections.Generic;

#nullable disable

namespace EntityTest.Models
{
    public partial class Telimci
    {
        public Telimci()
        {
            Qeydiyyats = new HashSet<Qeydiyyat>();
            Videos = new HashSet<Video>();
        }

        public int Id { get; set; }
        public string TelimciAd { get; set; }
        public string TelimciSoyad { get; set; }
        public string TelimciAtaAdi { get; set; }
        public string TelimciFin { get; set; }
        public int? IxtisasId { get; set; }
        public int? TelimciStaj { get; set; }

        public virtual Ixtisa Ixtisas { get; set; }
        public virtual ICollection<Qeydiyyat> Qeydiyyats { get; set; }
        public virtual ICollection<Video> Videos { get; set; }
    }
}

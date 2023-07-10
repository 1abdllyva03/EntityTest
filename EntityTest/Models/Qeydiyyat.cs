using System;
using System.Collections.Generic;

#nullable disable

namespace EntityTest.Models
{
    public partial class Qeydiyyat
    {
        public Qeydiyyat()
        {
            Odenis = new HashSet<Odeni>();
        }

        public int Id { get; set; }
        public int? TelebeId { get; set; }
        public int? PaketId { get; set; }
        public DateTime? MuqavileTarix { get; set; }
        public int? Endirim { get; set; }
        public int? TelimciId { get; set; }
        public string Status { get; set; }

        public virtual Paketler Paket { get; set; }
        public virtual Telebe Telebe { get; set; }
        public virtual Telimci Telimci { get; set; }
        public virtual ICollection<Odeni> Odenis { get; set; }
    }
}

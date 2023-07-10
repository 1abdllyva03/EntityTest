using System;
using System.Collections.Generic;

#nullable disable

namespace EntityTest.Models
{
    public partial class Video
    {
        public Video()
        {
            Icazes = new HashSet<Icaze>();
        }

        public int Id { get; set; }
        public int? TelimciId { get; set; }
        public int? PaketId { get; set; }
        public int? BolmeId { get; set; }
        public int? MovzuId { get; set; }
        public string VideoUrl { get; set; }

        public virtual Bolme Bolme { get; set; }
        public virtual Movzu Movzu { get; set; }
        public virtual Paketler Paket { get; set; }
        public virtual Telimci Telimci { get; set; }
        public virtual ICollection<Icaze> Icazes { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace EntityTest.Models
{
    public partial class Ixtisa
    {
        public Ixtisa()
        {
            Telebes = new HashSet<Telebe>();
            Telimcis = new HashSet<Telimci>();
        }

        public int Id { get; set; }
        public string IxtisasAd { get; set; }

        public virtual ICollection<Telebe> Telebes { get; set; }
        public virtual ICollection<Telimci> Telimcis { get; set; }
    }
}

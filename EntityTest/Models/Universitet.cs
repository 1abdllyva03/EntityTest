using System;
using System.Collections.Generic;

#nullable disable

namespace EntityTest.Models
{
    public partial class Universitet
    {
        public Universitet()
        {
            Telebes = new HashSet<Telebe>();
        }

        public int Id { get; set; }
        public string UniAd { get; set; }

        public virtual ICollection<Telebe> Telebes { get; set; }
    }
}

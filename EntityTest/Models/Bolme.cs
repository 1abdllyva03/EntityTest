using System;
using System.Collections.Generic;

#nullable disable

namespace EntityTest.Models
{
    public partial class Bolme
    {
        public Bolme()
        {
            Videos = new HashSet<Video>();
        }

        public int Id { get; set; }
        public string BolmeAd { get; set; }

        public virtual ICollection<Video> Videos { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace EntityTest.Models
{
    public partial class Movzu
    {
        public Movzu()
        {
            Videos = new HashSet<Video>();
        }

        public int Id { get; set; }
        public string MovzuAd { get; set; }

        public virtual ICollection<Video> Videos { get; set; }
    }
}

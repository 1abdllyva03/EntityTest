using System;
using System.Collections.Generic;

#nullable disable

namespace EntityTest.Models
{
    public partial class Icaze
    {
        public int Id { get; set; }
        public bool? IcazeName { get; set; }
        public int? TelebeId { get; set; }
        public int? VideoId { get; set; }

        public virtual Telebe Telebe { get; set; }
        public virtual Video Video { get; set; }
    }
}

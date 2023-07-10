using System;
using System.Collections.Generic;

#nullable disable

namespace EntityTest.Models
{
    public partial class Odeni
    {
        public int Id { get; set; }
        public int? QeydiyyatId { get; set; }
        public DateTime? Tarix { get; set; }
        public decimal? Mebleg { get; set; }

        public virtual Qeydiyyat Qeydiyyat { get; set; }
    }
}

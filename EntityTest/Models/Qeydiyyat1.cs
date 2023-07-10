using System;
using System.Collections.Generic;

#nullable disable

namespace EntityTest.Models
{
    public partial class Qeydiyyat1
    {
        public int Id { get; set; }
        public int? TelimciId { get; set; }
        public int? MentorId { get; set; }
        public int? TelebeId { get; set; }

        public virtual Mentor Mentor { get; set; }
        public virtual Telebe1 Telebe { get; set; }
        public virtual Telimci1 Telimci { get; set; }
    }
}

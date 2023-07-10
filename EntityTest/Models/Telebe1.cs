using System;
using System.Collections.Generic;

#nullable disable

namespace EntityTest.Models
{
    public partial class Telebe1
    {
        public Telebe1()
        {
            Qeydiyyat1s = new HashSet<Qeydiyyat1>();
        }

        public int Id { get; set; }
        public string Ad { get; set; }
        public int? TelebeStatus { get; set; }

        public virtual Status TelebeStatusNavigation { get; set; }
        public virtual ICollection<Qeydiyyat1> Qeydiyyat1s { get; set; }
    }
}

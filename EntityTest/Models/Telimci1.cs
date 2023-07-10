using System;
using System.Collections.Generic;

#nullable disable

namespace EntityTest.Models
{
    public partial class Telimci1
    {
        public Telimci1()
        {
            Qeydiyyat1s = new HashSet<Qeydiyyat1>();
        }

        public int Id { get; set; }
        public string Ad { get; set; }
        public int? TelimciStatus { get; set; }

        public virtual Status TelimciStatusNavigation { get; set; }
        public virtual ICollection<Qeydiyyat1> Qeydiyyat1s { get; set; }
    }
}

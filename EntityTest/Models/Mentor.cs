using System;
using System.Collections.Generic;

#nullable disable

namespace EntityTest.Models
{
    public partial class Mentor
    {
        public Mentor()
        {
            Qeydiyyat1s = new HashSet<Qeydiyyat1>();
        }

        public int Id { get; set; }
        public string Ad { get; set; }
        public int? MentorStatus { get; set; }

        public virtual Status MentorStatusNavigation { get; set; }
        public virtual ICollection<Qeydiyyat1> Qeydiyyat1s { get; set; }
    }
}

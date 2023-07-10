using System;
using System.Collections.Generic;

#nullable disable

namespace EntityTest.Models
{
    public partial class Status
    {
        public Status()
        {
            Mentors = new HashSet<Mentor>();
            Telebe1s = new HashSet<Telebe1>();
            Telimci1s = new HashSet<Telimci1>();
        }

        public int Id { get; set; }
        public string Ad { get; set; }

        public virtual ICollection<Mentor> Mentors { get; set; }
        public virtual ICollection<Telebe1> Telebe1s { get; set; }
        public virtual ICollection<Telimci1> Telimci1s { get; set; }
    }
}

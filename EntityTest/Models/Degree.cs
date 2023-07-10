using System;
using System.Collections.Generic;

#nullable disable

namespace EntityTest.Models
{
    public partial class Degree
    {
        public Degree()
        {
            Students = new HashSet<Student>();
        }

        public int Id { get; set; }
        public byte? Degree1 { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}

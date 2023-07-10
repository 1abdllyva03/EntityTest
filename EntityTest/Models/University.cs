using System;
using System.Collections.Generic;

#nullable disable

namespace EntityTest.Models
{
    public partial class University
    {
        public University()
        {
            Students = new HashSet<Student>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}

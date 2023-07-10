using System;
using System.Collections.Generic;

#nullable disable

namespace EntityTest.Models
{
    public partial class Section
    {
        public Section()
        {
            Tasks = new HashSet<Task>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Task> Tasks { get; set; }
    }
}

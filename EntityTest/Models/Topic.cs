using System;
using System.Collections.Generic;

#nullable disable

namespace EntityTest.Models
{
    public partial class Topic
    {
        public Topic()
        {
            Tasks = new HashSet<Task>();
        }

        public int İd { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Task> Tasks { get; set; }
    }
}

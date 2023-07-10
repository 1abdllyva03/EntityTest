using System;
using System.Collections.Generic;

#nullable disable

namespace EntityTest.Models
{
    public partial class Package
    {
        public Package()
        {
            Registrations = new HashSet<Registration>();
            Tasks = new HashSet<Task>();
        }

        public int Id { get; set; }
        public string PackageName { get; set; }
        public double? Price { get; set; }
        public int? Duration { get; set; }

        public virtual ICollection<Registration> Registrations { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
    }
}

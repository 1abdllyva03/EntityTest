using System;
using System.Collections.Generic;

#nullable disable

namespace EntityTest.Models
{
    public partial class Profession
    {
        public Profession()
        {
            Students = new HashSet<Student>();
            Trainers = new HashSet<Trainer>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Trainer> Trainers { get; set; }
    }
}

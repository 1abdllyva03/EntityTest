using System;
using System.Collections.Generic;

#nullable disable

namespace EntityTest.Models
{
    public partial class Position
    {
        public Position()
        {
            Trainers = new HashSet<Trainer>();
        }

        public int Id { get; set; }
        public string PositionName { get; set; }

        public virtual ICollection<Trainer> Trainers { get; set; }
    }
}

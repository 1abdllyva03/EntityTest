using System;
using System.Collections.Generic;

#nullable disable

namespace EntityTest.Models
{
    public partial class Trainer
    {
        public Trainer()
        {
            Registrations = new HashSet<Registration>();
            Tasks = new HashSet<Task>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FatherName { get; set; }
        public string Pin { get; set; }
        public string Phone { get; set; }
        public DateTime Birth { get; set; }
        public int ProfessionId { get; set; }
        public int Seniority { get; set; }
        public int PositionId { get; set; }

        public virtual Position Position { get; set; }
        public virtual Profession Profession { get; set; }
        public virtual ICollection<Registration> Registrations { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
    }
}

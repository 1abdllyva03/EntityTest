using System;
using System.Collections.Generic;

#nullable disable

namespace EntityTest.Models
{
    public partial class Student
    {
        public Student()
        {
            Registrations = new HashSet<Registration>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FatherName { get; set; }
        public string Pin { get; set; }
        public int? UniversityId { get; set; }
        public int? ProfessionId { get; set; }
        public int? DegreeId { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }

        public virtual Degree Degree { get; set; }
        public virtual Profession Profession { get; set; }
        public virtual University University { get; set; }
        public virtual ICollection<Registration> Registrations { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace EntityTest.Models
{
    public partial class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? PackageId { get; set; }
        public int? SectionId { get; set; }
        public int? TopicsId { get; set; }
        public int? TrainerId { get; set; }

        public virtual Package Package { get; set; }
        public virtual Section Section { get; set; }
        public virtual Topic Topics { get; set; }
        public virtual Trainer Trainer { get; set; }
    }
}

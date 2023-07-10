using System;
using System.Collections.Generic;

#nullable disable

namespace EntityTest.Models
{
    public partial class Registration
    {
        public int İd { get; set; }
        public int StudentId { get; set; }
        public int PackageId { get; set; }
        public DateTime ContractTime { get; set; }
        public double DiscountAzn { get; set; }
        public bool Status { get; set; }
        public int TrainerId { get; set; }

        public virtual Package Package { get; set; }
        public virtual Student Student { get; set; }
        public virtual Trainer Trainer { get; set; }
    }
}

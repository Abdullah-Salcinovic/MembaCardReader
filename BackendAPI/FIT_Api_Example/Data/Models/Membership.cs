using System;
using System.Collections.Generic;

namespace Backend.Data.Models
{
    public partial class Membership
    {
        public int Id { get; set; }
        public string? CustomerId { get; set; }
        public string? Subscription { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public bool? CrealityPrinters { get; set; }
        public bool? Raise3D { get; set; }
        public bool? Lcdprinters { get; set; }
        public bool? Tools { get; set; }
        public bool? Computers { get; set; }
        public bool? Electronics { get; set; }

        public virtual Customer? Customer { get; set; }
    }
}

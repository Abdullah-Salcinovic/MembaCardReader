using System;
using System.Collections.Generic;

namespace Backend.Data.Models
{
    public partial class Membership
    {
        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public string? Subscription { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public virtual Customer? Customer { get; set; }
    }
}

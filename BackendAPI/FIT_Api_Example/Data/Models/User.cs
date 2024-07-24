using System;
using System.Collections.Generic;

namespace Backend.Data.Models
{
    public partial class User
    {
        public User()
        {
            Resources = new HashSet<Resource>();
            Rfidscans = new HashSet<Rfidscan>();
        }

        public string UserId { get; set; }
        public string Name { get; set; } = null!;
        public string Sex { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? SubscriptionType { get; set; }
        public DateTime? ValidUntil { get; set; }

        public virtual ICollection<Resource> Resources { get; set; }
        public virtual ICollection<Rfidscan> Rfidscans { get; set; }
    }
}

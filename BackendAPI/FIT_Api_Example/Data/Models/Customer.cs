using System;
using System.Collections.Generic;

namespace Backend.Data.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Memberships = new HashSet<Membership>();
            Materials = new HashSet<Material>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Sex { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }

        public virtual ICollection<Membership> Memberships { get; set; }

        public virtual ICollection<Material> Materials { get; set; }
    }
}

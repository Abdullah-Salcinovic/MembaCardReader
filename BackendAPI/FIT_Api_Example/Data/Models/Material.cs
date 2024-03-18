using System;
using System.Collections.Generic;

namespace Backend.Data.Models
{
    public partial class Material
    {
        public Material()
        {
            Customers = new HashSet<Customer>();
        }

        public int MaterialId { get; set; }
        public string? Filament { get; set; }
        public string? Resin { get; set; }
        public string? Cncmill { get; set; }
        public string? LaserCutter { get; set; }
        public string? PremiumFilament { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}

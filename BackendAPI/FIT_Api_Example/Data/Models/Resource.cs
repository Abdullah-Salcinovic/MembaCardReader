using System;
using System.Collections.Generic;

namespace Backend.Data.Models
{
    public partial class Resource
    {
        public int ResourceId { get; set; }
        public string? UserId { get; set; }
        public int? StandardFilament { get; set; } = 0;
        public int? Resin { get; set; } = 0;
        public decimal? Cncmill { get; set; } = 0.0m;
        public decimal? LaserCutter { get; set; } = 0.0m;
        public int? PremiumFilament { get; set; } = 0;
        public bool? QualifiedForCrealityPrinters { get; set; } = false;
        public bool? QualifiedForRaise3D { get; set; } = false;
        public bool? QualifiedForLcdprinters { get; set; } = false;
        public bool? QualifiedForTools { get; set; } = false;
        public bool? QualifiedForComputers { get; set; } = false;
        public bool? QualifiedForElectronics { get; set; } = false;

        public virtual User? User { get; set; }
    }
}

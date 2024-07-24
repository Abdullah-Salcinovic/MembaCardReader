using System;
using System.Collections.Generic;

namespace Backend.Data.Models
{
    public partial class Rfidscan
    {
        public int ScanId { get; set; }
        public string? UserId { get; set; }
        public string Rfidcode { get; set; } = null!;

        public virtual User? User { get; set; }
    }
}

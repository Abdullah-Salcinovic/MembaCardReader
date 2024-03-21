using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frontend.Models
{
    public class CustomerGetAll
    {
        public string? Id { get; set; }
        public string? Name { get; set; }

        public bool CrealityPrinters { get; set; }
        public bool Raise3D { get; set; }
        public bool  Lcdprinters { get; set; }
        public bool Tools { get; set; }
        public bool Computers { get; set; }
        public bool Electronics { get; set; }

        public string? Filament { get; set; }
        public string? Resin { get; set; }
        public string? Cncmill { get; set; }
        public string? LaserCutter { get; set; }
        public string? PremiumFilament { get; set; }

        public override string ToString()
        {
            return $"{Id}, {Name}, {CrealityPrinters}, {Raise3D}, {Lcdprinters}, {Tools}, {Computers}, {Electronics}, {Filament}, {Resin}, {Cncmill}, {LaserCutter}, {PremiumFilament}";
        }
    }

    class CustomerGetAllResponse
    {
        public List<CustomerGetAll>? Customers { get; set; }
    }
}

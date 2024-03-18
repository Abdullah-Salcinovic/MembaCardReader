using Backend.Data.Models;
using System.Text.Json.Serialization;

namespace Backend.Endpoints.Customer.GetDataByIdOrName
{
    public class CustomerGetByIdOrNameRes
    {
        public string Id { get; set; }
        public string? Name { get; set; }


        [JsonIgnore]
        public virtual ICollection<Membership> Memberships { get; set; }
        public bool? CrealityPrinters => Memberships.Last().CrealityPrinters;
        public bool? Raise3D => Memberships.Last().Raise3D;
        public bool? Lcdprinters => Memberships.Last().Lcdprinters;
        public bool? Tools => Memberships.Last().Tools;
        public bool? Computers => Memberships.Last().Computers;
        public bool? Electronics => Memberships.Last().Electronics;

        [JsonIgnore]
        public virtual ICollection<Material> Materials { get; set; }
        public string? Filament => Materials.Last().Filament;
        public string? Resin => Materials.Last().Resin;
        public string? Cncmill => Materials.Last().Cncmill;
        public string? LaserCutter => Materials.Last().LaserCutter;
        public string? PremiumFilament => Materials.Last().PremiumFilament;
    }
}

using Backend.Data.Models;
using System.Text.Json.Serialization;

namespace Backend.Endpoints.Customer.GetDataById
{
    /*
        -ID [customer]
        -Name [customer]
        -Sex [customer]
        -Date of birth [customer]
        -Phone [customer]
        -E-mail [customer]
    <----------------------------------->
        -Subscription [membership]
        -Expiration Date [membership]
    <----------------------------------->
        -Filament [material]
        -Resin [material]
    */
    public class CustomerGetDataByIdRes
    {
        public string Id { get; set; }
        public string? Name { get; set; }
        public string? Sex { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }

        [JsonIgnore]
        public virtual ICollection<Membership> Memberships { get; set; }
        public string? Subscription => Memberships.Last().Subscription;
        public DateTime? ExpirationDate => Memberships.Last().ExpirationDate;

        [JsonIgnore]
        public virtual ICollection<Material> Materials { get; set; }
        public string? Filament => Materials.Last().Filament;
        public string? Resin => Materials.Last().Resin;
    }
}

using Frontend.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frontend.Models
{
    public class CustomerGetRes
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Subscription { get; set; }
        public DateTime ExpirationDate { get; set; }
    }

    public class CustomerGetAllResponse
    {
        public List<CustomerGetAll> Customers { get; set; }
    }

    public class CustomerGetAll
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Filament { get; set; }
        public string Resin { get; set; }
        public string Cncmill { get; set; }
        public string LaserCutter { get; set; }
        public string PremiumFilament { get; set; }
        public bool CrealityPrinters { get; set; }
        public bool Raise3D { get; set; }
        public bool Lcdprinters { get; set; }
        public bool Tools { get; set; }
        public bool Computers { get; set; }
        public bool Electronics { get; set; }

    }

    public class CustomerPutRes
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Sex { get; set; }
        public string Subscription { get; set; }
        public DateTime ExpirationDate { get; set; }
    }

    public class User
    {
        public string UserId { get; set; }
        public string Name { get; set; } = null!;
        public string Sex { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? SubscriptionType { get; set; }
        public DateTime ValidUntil { get; set; }
        public List<Resource> res { get; set; } = new List<Resource>();
    }

    public class Resource
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
    }

    public class UserResponse
    {
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string SubscriptionType { get; set; }
        public DateTime? ValidUntil { get; set; }
        public List<ResourceResponse> Resources { get; set; }
    }

    public class ResourceResponse
    {
        public int ResourceId { get; set; }
        public int StandardFilament { get; set; }
        public int Resin { get; set; }
        public decimal Cncmill { get; set; }
        public decimal LaserCutter { get; set; }
        public int PremiumFilament { get; set; }
        public bool QualifiedForCrealityPrinters { get; set; }
        public bool QualifiedForRaise3D { get; set; }
        public bool QualifiedForLcdprinters { get; set; }
        public bool QualifiedForTools { get; set; }
        public bool QualifiedForComputers { get; set; }
        public bool QualifiedForElectronics { get; set; }
    }

    public class UpdateUserRequest
    {
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string SubscriptionType { get; set; }
        public DateTime? ValidUntil { get; set; }
        public List<UpdateResourceRequest> Resources { get; set; }
    }

    public class UpdateResourceRequest
    {
        public int ResourceId { get; set; }
        public int StandardFilament { get; set; }
        public int Resin { get; set; }
        public decimal Cncmill { get; set; }
        public decimal LaserCutter { get; set; }
        public int PremiumFilament { get; set; }
        public bool QualifiedForCrealityPrinters { get; set; }
        public bool QualifiedForRaise3D { get; set; }
        public bool QualifiedForLcdprinters { get; set; }
        public bool QualifiedForTools { get; set; }
        public bool QualifiedForComputers { get; set; }
        public bool QualifiedForElectronics { get; set; }
    }

    public class CreateUserRequest
    {
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<CreateResourceRequest> Resources { get; set; }
    }

    public class CreateResourceRequest
    {
        public int StandardFilament { get; set; } = 0;
        public int Resin { get; set; } = 0;
        public decimal Cncmill { get; set; } = 0.0m;
        public decimal LaserCutter { get; set; } = 0.0m;
        public int PremiumFilament { get; set; } = 0;
        public bool QualifiedForCrealityPrinters { get; set; } = false;
        public bool QualifiedForRaise3D { get; set; } = false;
        public bool QualifiedForLcdprinters { get; set; } = false;
        public bool QualifiedForTools { get; set; } = false;
        public bool QualifiedForComputers { get; set; } = false;
        public bool QualifiedForElectronics { get; set; } = false;
    }

}
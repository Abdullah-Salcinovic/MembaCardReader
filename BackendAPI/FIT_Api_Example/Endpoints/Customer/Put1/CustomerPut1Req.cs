using Backend.Data.Models;
using System.Text.Json.Serialization;

namespace Backend.Endpoints.Customer.Put1
{
    public class CustomerPut1Req
    {
        public string Id { get; set; }
        public string? Name { get; set; }
        public string? Sex { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }

        public string? Subscription { get; set; }
        public DateTime? ExpirationDate { get; set; }
    }
}

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
        public string? Name { get; set; }
        public string? Sex { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }

        public string? Subscription {  get; set; }
        public DateTime ExpirationDate { get; set; }

        public string? Filament { get; set; }
        public string? Resin { get; set; }
    }
}

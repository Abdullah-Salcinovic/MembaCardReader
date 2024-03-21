using Azure.Core;
using Backend.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Backend.Endpoints.Customer.Put
{
    [Route("api/customer")]
    [ApiController]
    public class CustomerPutEndpoint : ControllerBase
    {
        private readonly MembershipcardContext _context;

        public CustomerPutEndpoint(MembershipcardContext context)
        {
            _context = context;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCustomer(string id, [FromBody] CustomerPutReq request)
        {
            if (id != request.Id)
            {
                return BadRequest("The ID in the URL does not match the ID in the request body.");
            }

            var customer = await _context.Customers
                .Include(c => c.Memberships)
                .Include(c => c.Materials)
                .FirstOrDefaultAsync(c => c.Id == id);

            if (customer == null)
            {
                return NotFound("Customer not found.");
            }

            // Update customer properties
            customer.Name = request.Name;

            // Update related entities (Membership, Material) if needed
            // For brevity, assuming only updating the last item in collections.
            if (customer.Memberships.Any())
            {
                var lastMembership = customer.Memberships.Last();
                lastMembership.CrealityPrinters = request.CrealityPrinters;
                lastMembership.Raise3D = request.Raise3D;
                lastMembership.Lcdprinters = request.Lcdprinters;
                lastMembership.Tools = request.Tools;
                lastMembership.Computers = request.Computers;
                lastMembership.Electronics = request.Electronics;
            }

            if (customer.Materials.Any())
            {
                var lastMaterial = customer.Materials.Last();
                lastMaterial.Filament = request.Filament;
                lastMaterial.Resin = request.Resin;
                lastMaterial.Cncmill = request.Cncmill;
                lastMaterial.LaserCutter = request.LaserCutter;
                lastMaterial.PremiumFilament = request.PremiumFilament;
            }

            try
            {
                await _context.SaveChangesAsync();
                return Ok("Customer updated successfully.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error updating customer: {ex.Message}");
            }
        }
    }
}

using Backend.Data.Models;
using Backend.Endpoints.Customer.Put;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Backend.Endpoints.Customer.Put1
{
    [Route("api/customera")]
    [ApiController]
    public class CustomerPut1Endpoint : ControllerBase
    {
        private readonly MembershipcardContext _context;

        public CustomerPut1Endpoint(MembershipcardContext context)
        {
            _context = context;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCustomer(string id, [FromBody] CustomerPut1Req request)
        {
            if (id != request.Id)
            {
                return BadRequest("The ID in the URL does not match the ID in the request body.");
            }

            var customer = await _context.Customers
                .Include(c => c.Memberships)
                .FirstOrDefaultAsync(c => c.Id == id);

            if (customer == null)
            {
                return NotFound("Customer not found.");
            }

            // Update customer properties
            customer.Name = request.Name;
            customer.Sex = request.Sex;
            customer.DateOfBirth = request.DateOfBirth;
            customer.Email = request.Email;
            customer.Phone = request.Phone;

            // Update related entities (Membership, Material) if needed
            // For brevity, assuming only updating the last item in collections.
            if (customer.Memberships.Any())
            {
                var lastMembership = customer.Memberships.Last();
                lastMembership.Subscription = request.Subscription;
                lastMembership.ExpirationDate = request.ExpirationDate;
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

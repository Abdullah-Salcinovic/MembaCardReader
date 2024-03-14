using Backend.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Endpoints.Customer.Delete
{
    [Route("api/customer")]
    [ApiController]
    public class CustomerDeleteEndpoint : ControllerBase
    {
        private readonly MembershipcardContext _context;

        public CustomerDeleteEndpoint(MembershipcardContext context)
        {
            _context = context;
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCustomer(int id)
        {
            var customer = _context.Customers.Find(id);
            if (customer == null)
            {
                return NotFound();
            }

            _context.Customers.Remove(customer);
            _context.SaveChanges();

            return NoContent();
        }
    }
}

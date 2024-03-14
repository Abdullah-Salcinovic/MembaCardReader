using Backend.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult UpdateCustomer(int id, [FromBody] CustomerPutReq customerReq)
        {
            var customer = _context.Customers.Find(id);
            if (customer == null)
            {
                return NotFound();
            }

            customer.Name = customerReq.Name;
            customer.Email = customerReq.Email;
            customer.Phone = customerReq.Phone;
            customer.DateOfBirth = customerReq.DateOfBirth;
            customer.Sex = customerReq.Sex;

            _context.SaveChanges();

            return NoContent();
        }
    }
}

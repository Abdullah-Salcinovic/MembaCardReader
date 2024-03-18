using Backend.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;

namespace Backend.Endpoints.Customer.GetDataByIdOrName
{
    [Route("api/customera")]
    [ApiController]
    public class CustomerGetByIdOrName : ControllerBase
    {
        private readonly MembershipcardContext _context;

        public CustomerGetByIdOrName(MembershipcardContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<CustomerGetByIdOrNameRes> GetCustomers([FromQuery] string? id, string? name)
        {
            var customer = _context.Customers.OrderByDescending(x => x.Id)
                .Where(x => x.Id == id).Where(x => x.Name == name )
                .Select(x => new CustomerGetByIdOrNameRes()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Materials = x.Materials,
                    Memberships = x.Memberships
                }).Single();

            if (customer == null)
            {
                return NotFound();
            }

            return customer;
        }
    }
}

using Backend.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Endpoints.Customer.GetDataById
{
    [Route("api/customer")]
    [ApiController]
    public class CustomerGetDataByIdEndpoint : ControllerBase
    {
        private readonly MembershipcardContext _context;

        public CustomerGetDataByIdEndpoint(MembershipcardContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<CustomerGetDataByIdRes> GetCustomers([FromQuery] int id)
        {
            var customer = _context.Customers.OrderByDescending(x => x.Id)
                .Where(x => x.Id == id)
                .Select(x => new CustomerGetDataByIdRes()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Sex = x.Sex,
                    DateOfBirth = x.DateOfBirth,
                    Email = x.Email,
                    Phone = x.Phone,
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

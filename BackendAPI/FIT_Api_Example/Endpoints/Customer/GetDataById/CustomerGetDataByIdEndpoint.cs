using Backend.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Endpoints.Customer.GetDataById
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerGetDataByIdEndpoint : ControllerBase
    {
        private readonly MembershipcardContext _context;

        public CustomerGetDataByIdEndpoint(MembershipcardContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<CustomerGetDataByIdRes> GetUstanovaZdravstva([FromQuery] int id)
        {
            var ustanovaZdravstva = _context.Customers.OrderByDescending(x => x.Id)
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

            if (ustanovaZdravstva == null)
            {
                return NotFound();
            }

            return ustanovaZdravstva;
        }
    }
}

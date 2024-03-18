using Backend.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Endpoints.Customer.Register
{
    [Route("api/register")]
    [ApiController]
    public class CustomerRegisterEndpoint : ControllerBase
    {
        private readonly MembershipcardContext _context;

        public CustomerRegisterEndpoint(MembershipcardContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult UpdateCustomer(CustomerRegisterReq model)
        {
            // Create a new customer
            var newCustomer = new Data.Models.Customer
            {
                Name = model.Name,
                Sex = model.Sex,
                DateOfBirth = model.DateOfBirth,
                Phone = model.Phone,
                Email = model.Email
            };


            if(model.Id == string.Empty)
            {
                string maxID = _context.Customers.Any() ? _context.Customers.Max(x => x.Id) + 1 : "1";
                newCustomer.Id = maxID;
            }
            else
            {
                newCustomer.Id = model.Id;
            }

            // Create a new membership
            var newMembership = new Membership
            {
                Subscription = model.Subscription,
                ExpirationDate = model.ExpirationDate
            };

            newMembership.Id = _context.Memberships.Max(x => x.Id) + 1;

            // Add the membership to the customer
            newCustomer.Memberships = new List<Membership> { newMembership };

            // Add the new entities to the context and save changes
            _context.Customers.Add(newCustomer);
            _context.SaveChanges();

            return Ok(); // Or return appropriate success response
        }
    }
}

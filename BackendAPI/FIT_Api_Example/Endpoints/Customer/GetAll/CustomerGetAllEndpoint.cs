﻿using Backend.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Endpoints.Customer.GetAll
{
    [Route("api/customers")]
    [ApiController]
    public class CustomerGetAllEndpoint : ControllerBase
    {
        private readonly MembershipcardContext _context;
        public CustomerGetAllEndpoint(MembershipcardContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<CustomerGetAllList> Get()
        {
            var customer = _context.Customers.OrderByDescending(x => x.Id)
                .Select(x => new CustomerGetAllRes()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Sex = x.Sex,
                    DateOfBirth = x.DateOfBirth,
                    Email = x.Email,
                    Phone = x.Phone
    }).ToList();

            return new CustomerGetAllList
            {
                Customers = customer
            };
        }
    }
}

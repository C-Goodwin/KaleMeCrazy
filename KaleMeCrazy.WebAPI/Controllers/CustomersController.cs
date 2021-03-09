using KaleMeCrazy.Data;
using KaleMeCrazy.Models;
using KaleMeCrazy.Services;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KaleMeCrazy.WebAPI.Controllers // Controllers are where methods are placed.
{
    [Authorize]
    public class CustomerController : ApiController
    {
        private CustomerService CreateCustomerService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var customerService = new CustomerService(userId);
            return customerService;
        }

        [HttpGet]
        public IHttpActionResult GetAllCustomers()
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateCustomerService();
            Shop shop = new Shop();
            var customer = service.GetCustomers();
            return Ok(customer);
        }

        [HttpGet]
        public IHttpActionResult GetCustomer(int id)
        {
            if (id<1)
            {
                return BadRequest();
            }

            var service = CreateCustomerService();

            var customer = service.GetCustomerById(id);
            if (customer ==null)
            {
                return InternalServerError();
            }

            return Ok(customer);
        }
        [HttpPost]
        public IHttpActionResult CreateCustomer([FromBody] CustomerCreate customer)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateCustomerService();

            if (!service.CreateCustomer(customer))
                return InternalServerError();

            return Ok();
        }
        [HttpPut]
        public IHttpActionResult EditCustomer(CustomerEdit customer)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateCustomerService();

            if (!service.UpdateCustomer(customer))
                return InternalServerError();

            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult DeleteCustomer(int CustomerId)
        {
            var service = CreateCustomerService();

            if (!service.DeleteCustomer(CustomerId))
                return InternalServerError();

            return Ok();

        }
    }
}
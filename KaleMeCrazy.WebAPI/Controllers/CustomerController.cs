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
        [HttpGet]
        public IHttpActionResult GetAllCustomers()
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            CustomerService service = new CustomerService();
            Shop shop = new Shop();
            var customer = service.GetCustomer(shop.ShopId);
            return Ok(customer);
        }

        //There was a change

        [HttpPost]
        public IHttpActionResult CreateCustomer([FromBody] CustomerCreate customer)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = new CustomerService();

            if (!service.CreateCustomer(customer))
                return InternalServerError();

            return Ok();
        }

        //private CustomerService CreateCustomerService()
        // {
        //     var userId = Guid.Parse(User.Identity.GetUserId());
        //     var customerService = new CustomerService(userId);
        //     return customerService;
        // }
    }
}

using KaleMeCrazy.Data;
using KaleMeCrazy.Models;
using KaleMeCrazy.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KaleMeCrazy.WebAPI.Controllers
{
    public class OrderController : ApiController
    {
        // POST
        [HttpPost]
        public IHttpActionResult CreateOrder(OrderCreate order)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            OrderService service = new OrderService();

            service.CreateOrder(order);

            return Ok();
        }

        // Get (all for all shops)
        [HttpGet]
        public IHttpActionResult GetAllOrders()
        {
            OrderService service = new OrderService();
            var orders = service.GetAllOrders();
            return Ok(orders);
        }

        // GET (all for one shop)
        [HttpGet]
        public IHttpActionResult GetAllOrdersByShopId(int shopId)
        {
            OrderService service = new OrderService();
            var orders = service.GetAllOrdersByShopId(shopId);
            return Ok(orders);
        }

        // GET (by id)
        [HttpGet]
        public IHttpActionResult GetOrderById(int id)
        {
            OrderService service = new OrderService();
            var order = service.GetOrderById(id);
            return Ok(order);
        }

        // PUT
        [HttpPut]
        public IHttpActionResult UpdateOrder(OrderEdit order)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            OrderService service = new OrderService();

            if (!service.UpdateOrder(order))
                return InternalServerError();

            return Ok();
        }

        // DELETE
        [HttpDelete]
        public IHttpActionResult DeleteOrder(int id)
        {
            OrderService service = new OrderService();

            if (!service.DeleteOrder(id))
                return InternalServerError();

            return Ok();
        }
    }
}

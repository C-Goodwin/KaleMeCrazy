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
    public class OrderItemController : ApiController
    {
        // POST
        [HttpPost]
        public IHttpActionResult CreateOrderItem(OrderItemCreate orderItem)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            OrderItemService service = new OrderItemService();

            service.CreateOrderItem(orderItem);

            return Ok();
        }

        
        // GET (by id)
        [HttpGet]
        public IHttpActionResult GetOrderItemsByOrderId(int id)
        {
            OrderItemService service = new OrderItemService();
            var orderItems = service.GetOrderItemsByOrderId(id);
            return Ok(orderItems);
        }

        // PUT
        [HttpPut]
        public IHttpActionResult UpdateOrderItem(OrderItemEdit orderItem)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            OrderItemService service = new OrderItemService();

            if (!service.UpdateOrderItem(orderItem))
                return InternalServerError();

            return Ok();
        }

        // DELETE
        [HttpDelete]
        public IHttpActionResult DeleteOrderItem(int orderId, int itemId)
        {
            OrderItemService service = new OrderItemService();

            if (!service.DeleteOrderItem(orderId, itemId))
                return InternalServerError();

            return Ok();
        }
    }
}

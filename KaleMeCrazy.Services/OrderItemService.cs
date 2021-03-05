using KaleMeCrazy.Data;
using KaleMeCrazy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaleMeCrazy.Services
{
    public class OrderItemService
    {
        // POST
        public bool CreateOrderItem(OrderItemCreate model)
        {
            var entity =
                new OrderItem()
                {
                    ItemId = model.ItemId,
                    OrderId = model.OrderId
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.OrderItems.Add(entity);
                return ctx.SaveChanges() == 1;
            }

        }

        // GET (get orderitem by orderid)
        public IEnumerable<OrderItemListItem> GetOrderItemsByOrderId(int orderId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .OrderItems
                        .Where(e => e.OrderId == orderId)
                        .Select(
                            e =>
                                new OrderItemListItem
                                {
                                    OrderId = e.OrderId,
                                    ItemId = e.ItemId,
                                    Quantity = e.Quantity,
                                }
                        );

                return query.ToArray();
            }
        }

        // PUT
        public bool UpdateOrderItem(OrderItemEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .OrderItems
                        .Single(e => e.ItemId == model.ItemId && e.OrderId == model.OrderId);

                entity.ItemId = model.ItemId;
                entity.Id = model.Id;
                entity.Quantity = model.Quantity;
                entity.OrderId = model.OrderId;

                return ctx.SaveChanges() == 1;
            }
        }

        // DELETE
        public bool DeleteOrderItem(int orderId, int itemId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .OrderItems
                        .Single(e => e.ItemId == itemId && e.OrderId == orderId);

                ctx.OrderItems.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}

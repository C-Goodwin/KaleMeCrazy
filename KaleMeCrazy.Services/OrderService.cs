using KaleMeCrazy.Data;
using KaleMeCrazy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaleMeCrazy.Services
{
    public class OrderService
    {
        // POST
        public bool CreateOrder(OrderCreate model)
        {
            var entity =
                new Order()
                {
                    ShopId =  model.ShopId,
                    CustomerId = model.CustomerId,
                    TotalPrice = model.TotalPrice,
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Orders.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }


        // GET (all orders for all shops)
        public IEnumerable<OrderListItem> GetAllOrders()
        {
            using (var ctx = new ApplicationDbContext())
            {

                var query =
                    ctx
                        .Orders
                        .Select(
                            e =>
                                new OrderListItem
                                {
                                   OrderId = e.OrderId,
                                   ShopId = e.ShopId,
                                   CustomerId = e.CustomerId,
                                   TotalPrice = e.TotalPrice,

                                }
                        );

                return query.ToArray();
            }
        }

        // GET (all orders for one shop)
        public IEnumerable<OrderListItem> GetAllOrdersByShopId(int shopId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Orders
                        .Where(e => e.ShopId == shopId)

                        .Select(
                            e =>
                            new OrderListItem
                            {
                                OrderId = e.OrderId,
                                ShopId = e.ShopId,
                                CustomerId = e.CustomerId,
                                TotalPrice = e.TotalPrice,
                            }
                        );

                return query.ToArray();
            }
        }

        // Get (by id)
        public OrderDetail GetOrderById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Orders
                        .Single(e => e.OrderId == id );
                return
                    new OrderDetail
                    {
                        OrderId = entity.OrderId,
                        ShopId = entity.ShopId,
                        CustomerId = entity.CustomerId,
                        OrderItems = entity.OrderItems,
                        TotalPrice = entity.TotalPrice,
                    };
            }
        }

        // PUT
        public bool UpdateOrder(OrderEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Orders
                        .Single(e => e.OrderId == model.OrderId);
                entity.CustomerId = model.CustomerId;
                entity.ShopId = model.ShopId;
                entity.TotalPrice = model.TotalPrice;
       

                return ctx.SaveChanges() == 1;
            }
        }

        // DELETE
        public bool DeleteOrder(int orderId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Orders
                        .Single(e => e.OrderId == orderId);

                ctx.Orders.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}

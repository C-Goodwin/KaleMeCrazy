using KaleMeCrazy.Data;
using KaleMeCrazy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaleMeCrazy.Services // This layer is how application interacts with database (Pushes and Pulls Customers).
{
    public class CustomerService
    {
        // THIS IS A TEST ...
        private readonly Guid _userid; // this is a constuctor.

        public CustomerService(Guid userid)
        {
            _userid = userid;
        }

        public bool CreateCustomer(CustomerCreate model) // Model comes from <form></form>, or is created in Postman for testing.
        {
            var entity =
                new Customer()
                {
                    CustomerId=model.CustomerId,
                    ShopId = model.ShopId,
                    Email = model.Email,
                    PhoneNumber = model.PhoneNumber,
                    Address = model.Address,
                    FullName = model.Name,
                    OrderId=model.OrderId
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Customers.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<CustomerListItem> GetCustomer(int shopId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Customers
                        .Where(e => e.ShopId == shopId && e.OwnerId == _userid) // Changed from CustomerId to shopId
                        .Select(
                            e =>
                                new CustomerListItem
                                {
                                    CustomerId = e.CustomerId,
                                    FullName = e.FullName,
                                }
                       );
                 return query.ToArray();
                   
            }
        }
        public CustomerDetail GetCustomerById(int id, Shop shop)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Customers
                        .Single(e => e.CustomerId == id && e.ShopId == shop.ShopId && e.OwnerId ==_userid); // * //
                return
                    new CustomerDetail
                    {
                        CustomerId = entity.CustomerId,
                        FullName = entity.FullName,
                        OrderId = entity.OrderId,
                        Address = entity.Address,
                        PhoneNumber = entity.PhoneNumber,
                        Email = entity.Email,
                        ShopId = entity.ShopId,
                    };
            }
        }
        public bool DeleteCustomer (int CustomerId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = 
                    ctx
                        .Customers
                        .Single(e => e.CustomerId == CustomerId && e.OwnerId == _userid);

                ctx.Customers.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
        public bool UpdateCustomer(CustomerEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Customers
                        .Single(e => e.CustomerId == model.CustomerId && e.OwnerId == _userid);

                entity.FullName = model.FullName;
                entity.Address = model.Address;
                entity.Email = model.Email;

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
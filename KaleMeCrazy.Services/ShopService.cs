using KaleMeCrazy.Data;
using KaleMeCrazy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaleMeCrazy.Services
{
    public class ShopService
    {
        private readonly Guid _userId;

        public ShopService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateShop(ShopCreate model)
        {
            var entity =
                new Shop()
                {
                    OwnerId = _userId,
                    // MenuItemId=model.MenuItemId, // This is causing this endpoint not to work in Postman
                    Name = model.Name,
                    Location = model.Location,
                    Menu = model.Menu
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Shops.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<ShopListItem> GetShops() // Use to see notes by specific user
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Shops
                        .Where(e => e.OwnerId == _userId)
                        .Select(
                            e =>
                                new ShopListItem
                                {
                                    ShopId = e.ShopId,
                                    Name = e.Name,

                                }
                        );

                return query.ToArray();
            }
        }

        public ShopDetail GetById(int id)
        {
            // Throw new NotImplementedException();
            using (var ctx = new ApplicationDbContext())
            {
                // Need to look up ElevenNote
                var entity =
                    ctx
                    .Shops
                    .Single(e => e.ShopId == id && e.OwnerId == _userId);
                return
                new ShopDetail
                {
                    ShopId = entity.ShopId,
                    Name = entity.Name,
                    Location = entity.Location,
                    Menu = entity.Menu,

                };
            }
        }

        public bool UpdateShop(ShopEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Shops
                        .Single(e => e.ShopId == model.ShopId && e.OwnerId == _userId);

                entity.Name = model.Name;
                entity.Location = model.Location;
                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteShop(int noteId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Shops
                        .Single(e => e.ShopId == noteId && e.OwnerId == _userId);

                ctx.Shops.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
using KaleMeCrazy.Data;
using KaleMeCrazy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaleMeCrazy.Services
{
    class OrderItemService
    {
        // POST
        public bool CreateMenuItem(OrderItemCreate model)
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

        // GET (all menu items for all menus for all shops)
        public IEnumerable<MenuItemListItem> GetAllMenuItems()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .MenuItems
                        .Select(
                        e =>
                            new MenuItemListItem
                            {
                                MenuId = e.MenuId,
                                ItemId = e.ItemId,
                                ItemName = e.ItemName
                            }
                        );

                return query.ToArray();
            }
        }

        // GET (get menuitem by menuid)
        public IEnumerable<MenuItemListItem> GetMenuItemsByMenuId(int menuId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .MenuItems
                        .Where(e => e.MenuId == menuId)
                        .Select(
                            e =>
                                new MenuItemListItem
                                {
                                    MenuId = e.MenuId,
                                    ItemId = e.ItemId,
                                    ItemName = e.ItemName
                                }
                        );

                return query.ToArray();
            }
        }

        // GET (get menuitem by item Id)
        public IEnumerable<MenuItemListItem> GetMenuItemByItemId(int itemId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .MenuItems
                        .Where(e => e.ItemId == itemId)
                        .Select(
                            e =>
                                new MenuItemListItem
                                {
                                    MenuId = e.MenuId,
                                    ItemId = e.ItemId,
                                    ItemName = e.ItemName
                                }
                            );

                return query.ToArray();
            }
        }


        // PUT
        public bool UpdateMenuItem(MenuItemEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .MenuItems
                        .Single(e => e.ItemId == model.ItemId && e.OwnerId == _userId);

                entity.ItemId = model.ItemId;
                entity.ItemName = model.ItemName;
                entity.Description = model.Description;
                entity.Price = model.Price;

                return ctx.SaveChanges() == 1;
            }
        }

        // DELETE
        public bool DeleteMenuItem(int itemId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .MenuItems
                        .Single(e => e.ItemId == itemId && e.OwnerId == _userId);

                ctx.MenuItems.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
}

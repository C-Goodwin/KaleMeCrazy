using KaleMeCrazy.Data;
using KaleMeCrazy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaleMeCrazy.Services
{
    public class MenuService
    {
        // POST
        public bool CreateMenu(MenuCreate model)
        {
            var entity =
                new Menu()
                {
                    ShopId = model.ShopId
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Menus.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        // GET (all menus for all shops)
        public IEnumerable<MenuListItem> GetAllMenus()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Menus
                        .Select(
                            e =>
                                new MenuListItem
                                {
                                    MenuId = e.MenuId,
                                    Name = e.Name
                                }
                        );

                return query.ToArray();
            }
        }

        // GET (all menus for one shop)
        public IEnumerable<MenuListItem> GetAllMenusByShopId(int shopId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Menus
                        .Where(e => e.ShopId == shopId)
                        .Select(
                            e =>
                            new MenuListItem
                            {
                                MenuId = e.MenuId,
                                Name = e.Name
                            }
                        );

                return query.ToArray();
            }
        }

        // Get (by id)
        public MenuDetail GetMenuById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Menus
                        .Single(e => e.MenuId == id /* Do I need e.ShopId == shopId here?*/);
                return
                    new MenuDetail
                    {
                        MenuId = entity.MenuId,
                        ShopId = entity.ShopId,
                        Name = entity.Name,
                        MenuItemList = entity.MenuItemList
                    };
            }
        }

        // PUT
        public bool UpdateMenu(MenuEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Menus
                        .Single(e => e.MenuId == model.MenuId  /* Do I need e.ShopId == shopId here?*/);

                entity.Name = model.Name;

                return ctx.SaveChanges() == 1;
            }
        }

        // DELETE
        public bool DeleteMenu(int menuId)
        {
            using(var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Menus
                        .Single(e => e.MenuId == menuId   /* Do I need e.ShopId == shopId here?*/);

                ctx.Menus.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}

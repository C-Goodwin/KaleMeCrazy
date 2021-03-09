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

namespace KaleMeCrazy.WebAPI.Controllers
{
    public class MenuItemController : ApiController
    {
        // POST
        [HttpPost]
        public IHttpActionResult CreateMenuItem(MenuItemCreate menuItem)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            MenuItemService service = CreatedMenuItemService();

            service.CreateMenuItem(menuItem);

            return Ok();
        }

        // GET (all menu items for all menus for all shops)
        [HttpGet]
        public IHttpActionResult GetAllMenuItems()
        {
            MenuItemService menuItemService = CreatedMenuItemService();
            var menuItems = menuItemService.GetAllMenuItems();
            return Ok(menuItems);
        }

        // GET (get list of menu items by menu id)
        [HttpGet]
        public IHttpActionResult GetMenuItemsByMenuId(int menuId)
        {
            MenuItemService menuItemService = CreatedMenuItemService();
            var menuItems = menuItemService.GetMenuItemsByMenuId(menuId);
            return Ok(menuItems);
        }

        // GET (one menu item by item id)
        [HttpGet]
        public IHttpActionResult GetMenuItemById(int itemId)
        {
            MenuItemService menuItemService = CreatedMenuItemService();
            var menuItem = menuItemService.GetMenuItemByItemId(itemId);
            return Ok(menuItem);
        }

        // PUT
        [HttpPut]
        public IHttpActionResult EditMenuItem(MenuItemEdit menuItem)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreatedMenuItemService();

            if (!service.UpdateMenuItem(menuItem))
                return InternalServerError();

            return Ok();
        }

        // DELETE
        [HttpDelete]
        public IHttpActionResult DeleteMenuItem(int id)
        {
            var service = CreatedMenuItemService();

            if (!service.DeleteMenuItem(id))
                return InternalServerError();

            return Ok();
        }

        // HELPER METHOD
        public MenuItemService CreatedMenuItemService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var menuItemService = new MenuItemService(userId);
            return menuItemService;
        }
    }

}

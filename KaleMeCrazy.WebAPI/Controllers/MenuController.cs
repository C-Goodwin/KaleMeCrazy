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
    public class MenuController : ApiController
    {
        // DONE
        // POST
        [HttpPost]
        public IHttpActionResult CreateMenu(MenuCreate menu)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            MenuService service = CreatedMenuService();

            service.CreateMenu(menu);

            return Ok();
        }

        // DONE
        // Get (all for all shops)
        [HttpGet]
        public IHttpActionResult GetAllMenus()
        {
            MenuService service = CreatedMenuService();
            var menus = service.GetAllMenus();
            return Ok(menus);
        }

        // DONE
        // GET (all for one shop)
        [HttpGet]
        public IHttpActionResult GetAllMenusByShopId(int shopId)
        {
            MenuService service = CreatedMenuService();
            Shop shop = new Shop();
            var menus = service.GetAllMenusByShopId(shopId);
            return Ok(menus);
        }

        // DONE
        // GET (by id)
        [HttpGet]
        public IHttpActionResult GetMenuById(int id)
        {
            MenuService service = CreatedMenuService();
            var menu = service.GetMenuById(id);
            return Ok(menu);
        }

        // DONE
        // PUT
        [HttpPut]
        public IHttpActionResult UpdateMenu(MenuEdit menu)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreatedMenuService();

            if (!service.UpdateMenu(menu))
                return InternalServerError();

            return Ok();
        }

        // DONE
        // DELETE
        [HttpDelete]
        public IHttpActionResult DeleteMenu(int id)
        {
            var service = CreatedMenuService();

            if (!service.DeleteMenu(id))
                return InternalServerError();

            return Ok();
        }

        // HELPER METHOD
        private MenuService CreatedMenuService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var menuService = new MenuService(userId);
            return menuService;
        }
    }
}

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
    public class MenuController : ApiController
    {
        // POST
        [HttpPost]
        public IHttpActionResult CreateMenu(MenuCreate menu)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            MenuService service = new MenuService();

            service.CreateMenu(menu);

            return Ok();
        }

        // Get (all for all shops)
        [HttpGet]
        public IHttpActionResult GetAllMenus()
        {
            MenuService service = new MenuService();
            var menus = service.GetAllMenus();
            return Ok(menus);
        }

        // GET (all for one shop)
        [HttpGet]
        public IHttpActionResult GetAllMenusByShopId(int shopId)
        {
            MenuService service = new MenuService();
            Shop shop = new Shop();
            var menus = service.GetAllMenusByShopId(shopId);
            return Ok(menus);
        }

        // GET (by id)
        [HttpGet]
        public IHttpActionResult GetMenuById(int id)
        {
            MenuService service = new MenuService();
            var menu = service.GetMenuById(id);
            return Ok(menu);
        }

        // PUT
        [HttpPut]
        public IHttpActionResult UpdateMenu(MenuEdit menu)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = new MenuService();

            if (!service.UpdateMenu(menu))
                return InternalServerError();

            return Ok();
        }

        // DELETE
        [HttpDelete]
        public IHttpActionResult DeleteMenu(int id)
        {
            var service = new MenuService();

            if (!service.DeleteMenu(id))
                return InternalServerError();

            return Ok();
        }
    }
}

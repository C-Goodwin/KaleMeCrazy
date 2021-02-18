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
    public class MenuItemController : ApiController
    {
        // POST
        [HttpPost]
        public IHttpActionResult CreateMenuItem(MenuItemCreate menuItem)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            MenuItemService service = new MenuItemService();

            service.CreateMenuItem(menuItem);

            return Ok();
        }

        // GET

        // PUT

        // DELETE
    }

}

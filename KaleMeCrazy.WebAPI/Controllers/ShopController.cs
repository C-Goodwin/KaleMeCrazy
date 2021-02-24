using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KaleMeCrazy.WebAPI.Controllers
{
    public class ShopController : ApiController
    {

        private ShopService CreateNoteService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var shopService = new shopService(userId);
            return shopService;
        }

    }

}

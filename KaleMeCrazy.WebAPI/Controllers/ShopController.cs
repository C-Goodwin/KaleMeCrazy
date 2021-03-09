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
    public class ShopController : ApiController
    {
        private ShopService CreateShopService()
        {
            var shopId = Guid.Parse(User.Identity.GetUserId());
            var shopService = new ShopService(shopId);
            return shopService;
        }


        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            ShopService shopservice = CreateShopService();

            var shop = shopservice.GetShops();
            return Ok(shop);
        }

        [HttpPost]
        public IHttpActionResult Post([FromBody] ShopCreate shop
            )
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateShopService();

            if (!service.CreateShop(shop))
                return InternalServerError();

            return Ok();
        }

        [HttpGet]
        //need to get all of the shops
        public IHttpActionResult Get()
        {
            var service = CreateShopService();
            var shops = service.GetShops();
            return Ok(shops);
        }

        [HttpPut]
        public IHttpActionResult Put(ShopEdit Shop)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateShopService();

            if (!service.UpdateShop(Shop))
                return InternalServerError();

            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var service = CreateShopService();
            if (!service.DeleteShop(id))
            {
                return InternalServerError();
            }

            return Ok();
        }
    }
}



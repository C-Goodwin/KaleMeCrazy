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
        private readonly Guid _userId;

        private ShopService CreateShopService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new ShopService(userId);
            return service;
        }


        public IHttpActionResult Post(ShopCreate shopCreate)
        {
            if (shopCreate == null)
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var service = CreateShopService();

            if (!service.CreateShop(shopCreate))
            {
                return InternalServerError();
            }

            return Ok();
        }

        [HttpGet]
        public IHttpActionResult Get() 
        {
            var service = CreateShopService();
            var shops = service.GetShops();
            if (shops==null)
            {
                return InternalServerError();
            }
            return Ok(shops);
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var service = CreateShopService();

            if (id<1)
            {
                return BadRequest();
            }

            var shop = service.GetById(id);

            if (shop == null)
            {
                return InternalServerError();
            }

            return Ok(shop);

            
        }

        [HttpPut]
        public IHttpActionResult Put (ShopEdit shop)
        {
            if (shop==null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var service = CreateShopService();

            var isSuccessful = service.UpdateShop(shop);
            if (!isSuccessful)
            {
                return InternalServerError();
            }

            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult DeleteStore(int id) 
        {
            if (id<1)
            {
                return BadRequest(); 
            }

            var service = CreateShopService();

            var isSuccesfsful = service.DeleteShop(id);

            if (!isSuccesfsful)
            {
                return InternalServerError();
            }

            return Ok();
        }
    }
}

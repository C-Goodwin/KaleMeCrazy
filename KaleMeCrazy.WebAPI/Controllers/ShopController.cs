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
        private readonly Guid _userId; // Do I need this Guid?

        private ShopService CreateShopService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId()); // This is important
            var service = new ShopService(userId);
            return service;
        }

        [HttpPost]
        public IHttpActionResult PostShop(ShopCreate shopCreate)
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
        public IHttpActionResult GetShop() 
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
        public IHttpActionResult GetShopById(int id)
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
        public IHttpActionResult PutShop (ShopEdit shop)
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
        public IHttpActionResult DeleteShop(int id) 
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
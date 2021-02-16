using KaleMeCrazy.Data;
using KaleMeCrazy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaleMeCrazy.Services
{
    public class ShopService
    {



        private readonly Guid _userId;

        public ShopService(Guid userId)
        {
            _userId = userId;
        }



        public bool CreateNote(ShopCreate model)
        {
            var entity =
                new Shop()
                {
                    OwnerId=_userId,
                    Name = model.Name,
                    Menu = model.Menu,
                    Location = model.Location,
                    CreatedUtc = DateTimeOffset.Now
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Shops.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

    }
}

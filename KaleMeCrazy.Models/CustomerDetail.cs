using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KaleMeCrazy.Data;

namespace KaleMeCrazy.Models
{
    public class CustomerDetail // (GET by ID))
    {
        public int CustomerId { get; set; } // TSQL identity property. Once customer is created, will auto-create and increment other newly created customer ids by 1.

        // public Guid UserId { get; set; } // Allows us to get info about customer via their 32bit hex code.
        public string FullName { get; set; }
        public int OrderId { get; set; }

        public virtual Order Order { get; set; } // Navigation property, OrderId looks to this to get information about an EXISTING order
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public int ShopId { get; set; }
    }
}
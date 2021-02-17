using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaleMeCrazy.Data // *UserID in ElevenNote is ShopID in this project* *ShopId is Parent Id*
{
    public class Customer // Only what defines customer object should be here.
    {
        [Key]
        public int CustomerId { get; set; } // TSQL identity property. Once customer is created, will auto-create and increment other newly created customer ids by 1.

        // public Guid UserId { get; set; } // Allows us to get info about customer via their 32bit hex code.

        [Required]
        public string FullName { get; set; }
        public int OrderId { get; set; }
        public virtual Order Order { get; set; } // Navigation property, OrderId looks to this to get information about an EXISTING order
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        
        [ForeignKey(nameof(Shop))]
        public int ShopId { get; set; }
        public virtual Shop Shop { get; set; }
    }
}
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


        [Required]
        public string FullName { get; set; }
        public Guid OwnerId { get; set; } // * //

      
        public virtual List<Order> Orders { get; set; }
       
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        
        [ForeignKey(nameof(Shop))]
        public int ShopId { get; set; }
        public virtual Shop Shop { get; set; }
    }
}
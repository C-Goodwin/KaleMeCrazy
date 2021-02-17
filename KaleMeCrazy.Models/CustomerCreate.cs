using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaleMeCrazy.Models
{
    public class CustomerCreate
    {

        // *SETUP* properties you want user input for to create the object. This is the info needed from the User/Customer (POST)
        // Key is not required on models layer (is required in data layer)
        [Required]
        public int CustomerId { get; set; } // Database will create this CustomerID 
        
        [Required]
        public string Name { get; set; }

        public string Email { get; set; }
        
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public int ShopId { get; set; }

        //[Required]
        // public bool IsMember { get; set; } // Could be a Members Class

        // [Required]
        // public int OrderId { get; set; }
    }
}

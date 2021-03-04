using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaleMeCrazy.Models
{
    public class OrderCreate
    {
      
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public double TotalPrice { get; set; }
        
        public int ShopId { get; set; }
     
    }
}

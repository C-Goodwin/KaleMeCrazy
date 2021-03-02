using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaleMeCrazy.Models
{
    class OrderCreate
    {
      
        [Required]
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        [Required]
        public List<OrderItem> OrderItems { get; set; }
        [Required]
        public double TotalPrice { get; set; }
        [ForeignKey(nameof(Shop))]
        public int ShopId { get; set; }
        public virtual Shop Shop { get; set; }
    }
}

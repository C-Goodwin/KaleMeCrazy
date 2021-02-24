using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaleMeCrazy.Data
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

       // [ForeignKey (nameof(Customer))]
        public int CustomerId { get; set; }
        //public virtual Customer Customer { get; set; }

        [Required]
        public List<OrderItem> OrderItems { get; set; }

        [Required]
        public double TotalPrice { get; set; }

        [ForeignKey(nameof(Shop))]
        public int ShopId { get; set; }
        public virtual Shop Shop { get; set; }
        
    }
}

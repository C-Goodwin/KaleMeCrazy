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
        [ForeignKey ("Customer")]
        public int CustomerId { get; set; }
        [Required]
        public List<OrderItem> OrderItems { get; set; }
        [Required]
        public double TotalPrice { get; set; }
        [ForeignKey("Shop")]
        public int ShopId { get; set; }
        
    }
}

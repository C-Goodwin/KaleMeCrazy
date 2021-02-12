using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaleMeCrazy.Data
{
    public class OrderItem
    {
        [ForeignKey("MenuItem")]
        public int ItemId { get; set; }
        [ForeignKey ("Order")]
        public int OrderId { get; set; }
        public int Quantity { get; set; }
    }
}

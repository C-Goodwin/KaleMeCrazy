using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaleMeCrazy.Models
{
    public class OrderItemDetail
    {
        public int ItemId { get; set; }
        public int OrderId { get; set; }
        public int Quantity { get; set; }
    }
}

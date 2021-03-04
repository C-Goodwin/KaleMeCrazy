using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaleMeCrazy.Models
{
    public class OrderListItem
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public double TotalPrice { get; set; }
        public int ShopId { get; set; }
    }
}

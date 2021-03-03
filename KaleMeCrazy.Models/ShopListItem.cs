using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaleMeCrazy.Models
{
    public class ShopListItem
    {

        public int ShopId { get; set; }
        public string Location { get; set; }
        public string Menu { get; set; }  // Needs to be menu class
        public string Name { get; set; }
    }
}

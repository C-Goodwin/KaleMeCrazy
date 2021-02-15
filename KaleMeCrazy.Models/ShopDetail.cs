using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaleMeCrazy.Models
{
    class ShopDetail
    {
        public int ShopId { get; set; }
        public string Location { get; set; }
        public string Menu { get; set; }
        public string Name { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}

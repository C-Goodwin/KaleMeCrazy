using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaleMeCrazy.Data
{
    public class OrderItem
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("MenuItem")]
        public int ItemId { get; set; }
        public virtual MenuItem MenuItem{ get; set; }

        [ForeignKey (nameof(Order))]
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }

        public int Quantity { get; set; }
    }
}

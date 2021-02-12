using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaleMeCrazy.Data
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        public string FullName { get; set; }
        public int OrderId { get; set; }
        public bool IsMember { get; set; }
    }
}

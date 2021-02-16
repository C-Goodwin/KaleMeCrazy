using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaleMeCrazy.Models
{
    public class ShopCreate
    {
        [Required]
        [MinLength(2, ErrorMessage = "The store name must be at least 2 Characters.")]
        [MaxLength(50, ErrorMessage = "There are too many characters in thes field")]
        public string Name { get; set; }

        [MaxLength(10000)]
        public string Menu { get; set; }

        public string Location { get; set; }

        public DateTime CreatedUtc { get; set; }
    }
}

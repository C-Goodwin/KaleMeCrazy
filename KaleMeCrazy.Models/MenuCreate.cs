using KaleMeCrazy.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaleMeCrazy.Models
{
    public class MenuCreate
    {
        [Required]
        public int ShopId { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Please enter at least two characters.")]
        [MaxLength(25, ErrorMessage = "There are too many characters in this field.")]
        public string Name { get; set; }

        public Guid OwnerId { get; set; }
    }
}

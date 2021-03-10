using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaleMeCrazy.Models
{
    public class MenuItemCreate
    {
        public int MenuId { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "There are not enough characters in this field.")]
        [MaxLength(25, ErrorMessage = "There are too many characters in this field.")]
        public string ItemName { get; set; }

        [Required]
        [MinLength(10, ErrorMessage = "There must be at least ten characters.")]
        [MaxLength(100, ErrorMessage = "There can only be a max of 100 characters.")]
        public string Description { get; set; }

        [Required]
        public double Price { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaleMeCrazy.Data
{
    public class MenuItem
    {
        [Key]
        public int ItemId { get; set; }
        [ForeignKey ("Menu")]
        public int MenuId { get; set; }
        public virtual Menu Menu { get; set; }
        [Required]
        public string ItemName { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public double Price { get; set; }
    }
}

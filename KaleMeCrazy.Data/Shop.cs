using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaleMeCrazy.Data
{ 
    public class Shop //this is the child 
    {
        [Key]
        public int ShopId { get; set; }
        public Guid OwnerId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Location { get; set; }

       [ForeignKey(nameof(MenuItem))]
        public int MenuItemId { get; set; }

        public virtual MenuItem MenuItem{ get; set; }
    }
}

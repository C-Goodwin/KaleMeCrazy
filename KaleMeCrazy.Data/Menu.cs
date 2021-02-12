using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaleMeCrazy.Data
{
    public class Menu
    {
        [Key]
        public int MenuId { get; set; }
        [ForeignKey ("Shop")]
        public int ShopId { get; set; }
        public List<MenuItem> MyProperty { get; set; }
    }
}

using KaleMeCrazy.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaleMeCrazy.Models
{
    public class MenuDetail
    {
        public int MenuId { get; set; }

        public int ShopId { get; set; }

        public string Name { get; set; }

        public virtual List<MenuItemListItem> MenuItemList { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaleMeCrazy.Models
{
    public class MenuItemCreate
    {
        public int MenuId { get; set; }

        public string ItemName { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }
    }
}

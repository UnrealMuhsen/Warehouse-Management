﻿using System;

namespace InventorySystem.Data
{
    public class Item
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

        public ICollection<ItemUnit> Units { get; set; }
    }
}

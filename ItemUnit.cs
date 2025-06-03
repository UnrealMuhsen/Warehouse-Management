using System;

namespace InventorySystem.Data
{
    public class ItemUnit
    {
        public int Id { get; set; }
        public string UnitName { get; set; }

        public int ItemId { get; set; }
        public Item Item { get; set; }
    }
}
using System;

namespace InventorySystem.Data
{
    public class ProductItemUnit
    {
        public int Id { get; set; }
        public string UnitName { get; set; }

        public int ItemId { get; set; }
        public Productitem Item { get; set; }
    }
}
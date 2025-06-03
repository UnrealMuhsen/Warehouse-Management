using System;

namespace InventorySystem.Data
{
    public class Productitem
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

        public ICollection<ProductItemUnit> Units { get; set; }
    }
}

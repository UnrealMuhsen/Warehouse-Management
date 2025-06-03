using System;

namespace InventorySystem.Data
{
    public class SupplyPermissionItem
    {
        public int Id { get; set; }

        public int ItemId { get; set; }
        public Item Item { get; set; }

        public int Quantity { get; set; }
        public DateTime ProductionDate { get; set; }
        public int ExpiryMonths { get; set; }

        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }

        public int SupplyPermissionId { get; set; }
        public SupplyPermission SupplyPermission { get; set; }
    }
}
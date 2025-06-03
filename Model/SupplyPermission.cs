using System;

namespace InventorySystem.Data
{
    public class SupplyPermission
    {
        public int Id { get; set; }
        public string PermissionNumber { get; set; }
        public DateTime PermissionDate { get; set; }
        public int StoreId { get; set; }
        public Warehouse Store { get; set; }

        public ICollection<SupplyPermissionItem> Items { get; set; }
    }
}
using System;

namespace InventorySystem.Data
{
    public class ReleasePermissionItem
    {
        public int Id { get; set; }

        public int ItemId { get; set; }
        public Productitem Item { get; set; }

        public int Quantity { get; set; }

        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }

        public int ReleasePermissionId { get; set; }
        public ReleasePermission ReleasePermission { get; set; }
    }
}

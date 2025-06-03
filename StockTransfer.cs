using System;

namespace InventorySystem.Data
{
    public class StockTransfer
    {
        public int Id { get; set; }
        public DateTime TransferDate { get; set; }

        public int FromStoreId { get; set; }
        public Store FromStore { get; set; }

        public int ToStoreId { get; set; }
        public Store ToStore { get; set; }

        public ICollection<StockTransferItem> Items { get; set; }
    }
}

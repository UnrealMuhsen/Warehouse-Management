using System;

namespace InventorySystem.Data
{
    public class StockTransferItem
    {
        public int Id { get; set; }

        public int ItemId { get; set; }
        public Productitem Item { get; set; }

        public int Quantity { get; set; }
        public DateTime ProductionDate { get; set; }
        public int ExpiryMonths { get; set; }


        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }

        public int StockTransferId { get; set; }
        public StockTransfer StockTransfer { get; set; }
    }
}

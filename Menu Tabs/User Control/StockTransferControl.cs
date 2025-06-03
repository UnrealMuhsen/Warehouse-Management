using System;
using System.Linq;
using System.Windows.Forms;
using InventorySystem.Data;
using Microsoft.EntityFrameworkCore;


namespace InventorySystem.Tabs.User_Control
{
    public partial class StockTransferControl : UserControl
    {
        private readonly CompanyContext _context;
        private int? editingTransferId = null;
        private int? editingTransferItemId = null;

        public StockTransferControl()
        {
            InitializeComponent();
            _context = new CompanyContext();
            LoadDropdowns();
            LoadTransfers();
            this.dgvTransfers.CellClick += new DataGridViewCellEventHandler(this.dgvTransfers_CellClick);

        }

        private void LoadDropdowns()
        {
            var stores = _context.Warehouses.ToList();
            cmbFromStore.DataSource = stores.ToList();
            cmbFromStore.DisplayMember = "Name";
            cmbFromStore.ValueMember = "Id";

            cmbToStore.DataSource = stores.ToList();
            cmbToStore.DisplayMember = "Name";
            cmbToStore.ValueMember = "Id";

            cmbItem.DataSource = _context.Productitems.ToList();
            cmbItem.DisplayMember = "Name";
            cmbItem.ValueMember = "Id";

            cmbSupplier.DataSource = _context.Suppliers.ToList();
            cmbSupplier.DisplayMember = "Name";
            cmbSupplier.ValueMember = "Id";
        }

        private void LoadTransfers()
        {
            dgvTransfers.DataSource = _context.StockTransferItems
                .Select(t => new
                {
                    رقم_الصنف = t.Id,
                    رقم_التحويل = t.StockTransferId,
                    من_المخزن = t.StockTransfer.FromStore.Name,
                    إلى_المخزن = t.StockTransfer.ToStore.Name,
                    الصنف = t.Item.Name,
                    الكمية = t.Quantity,
                    المورد = t.Supplier.Name,
                    تاريخ_الإنتاج = t.ProductionDate,
                    الصلاحية_بالأشهر = t.ExpiryMonths
                })
                .ToList();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0 ||
                !int.TryParse(txtExpiryMonths.Text, out int expiry) || expiry <= 0)
            {
                MessageBox.Show("يرجى إدخال كمية وصلاحية صحيحة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int fromStoreId = (int)cmbFromStore.SelectedValue;
            int toStoreId = (int)cmbToStore.SelectedValue;

            if (fromStoreId == toStoreId)
            {
                MessageBox.Show("المخزن المرسل والمستقبل لا يمكن أن يكونا نفس المخزن", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (editingTransferItemId.HasValue)
            {
          
                var transferItem = _context.StockTransferItems.FirstOrDefault(x => x.Id == editingTransferItemId.Value);
                if (transferItem != null)
                {
                    transferItem.ItemId = (int)cmbItem.SelectedValue;
                    transferItem.Quantity = quantity;
                    transferItem.SupplierId = (int)cmbSupplier.SelectedValue;
                    transferItem.ProductionDate = dtpProductionDate.Value;
                    transferItem.ExpiryMonths = expiry;

                    transferItem.StockTransfer.FromStoreId = fromStoreId;
                    transferItem.StockTransfer.ToStoreId = toStoreId;

                    _context.SaveChanges();

                    MessageBox.Show("تم تعديل التحويل بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
           
                var transfer = new StockTransfer
                {
                    FromStoreId = fromStoreId,
                    ToStoreId = toStoreId,
                    TransferDate = DateTime.Now
                };

                _context.StockTransfers.Add(transfer);
                _context.SaveChanges();

                var transferItem = new StockTransferItem
                {
                    StockTransferId = transfer.Id,
                    ItemId = (int)cmbItem.SelectedValue,
                    Quantity = quantity,
                    SupplierId = (int)cmbSupplier.SelectedValue,
                    ProductionDate = dtpProductionDate.Value,
                    ExpiryMonths = expiry
                };

                _context.StockTransferItems.Add(transferItem);
                _context.SaveChanges();

                MessageBox.Show("تم التحويل بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            ClearForm();
            LoadTransfers();
        }

        private void dgvTransfers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int transferItemId = Convert.ToInt32(dgvTransfers.Rows[e.RowIndex].Cells["رقم_الصنف"].Value);
                var item = _context.StockTransferItems.Include(x => x.StockTransfer).FirstOrDefault(x => x.Id == transferItemId);

                if (item != null)
                {
                    cmbFromStore.SelectedValue = item.StockTransfer.FromStoreId;
                    cmbToStore.SelectedValue = item.StockTransfer.ToStoreId;
                    cmbItem.SelectedValue = item.ItemId;
                    cmbSupplier.SelectedValue = item.SupplierId;
                    txtQuantity.Text = item.Quantity.ToString();
                    txtExpiryMonths.Text = item.ExpiryMonths.ToString();
                    dtpProductionDate.Value = item.ProductionDate;

                    editingTransferId = item.StockTransferId;
                    editingTransferItemId = item.Id;
                }
            }
        }

        private void btnEditTransfer_Click(object sender, EventArgs e)
        {
            if (editingTransferItemId.HasValue)
            {
                btnTransfer_Click(sender, e);
            }
            else
            {
                MessageBox.Show("يرجى اختيار صف للتعديل", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteTransfer_Click(object sender, EventArgs e)
        {
            if (editingTransferItemId.HasValue)
            {
                var item = _context.StockTransferItems.FirstOrDefault(x => x.Id == editingTransferItemId.Value);
                if (item != null)
                {
                    _context.StockTransferItems.Remove(item);

                  
                    var otherItems = _context.StockTransferItems
                        .Where(x => x.StockTransferId == item.StockTransferId && x.Id != item.Id)
                        .ToList();

                    if (!otherItems.Any())
                    {
                        var transfer = _context.StockTransfers.FirstOrDefault(t => t.Id == item.StockTransferId);
                        if (transfer != null)
                        {
                            _context.StockTransfers.Remove(transfer);
                        }
                    }

                    _context.SaveChanges();
                    MessageBox.Show("تم الحذف بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadTransfers();
                }
            }
            else
            {
                MessageBox.Show("يرجى اختيار صف للحذف", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClearForm()
        {
            editingTransferId = null;
            editingTransferItemId = null;
            txtQuantity.Clear();
            txtExpiryMonths.Clear();
            cmbFromStore.SelectedIndex = 0;
            cmbToStore.SelectedIndex = 0;
            cmbItem.SelectedIndex = 0;
            cmbSupplier.SelectedIndex = 0;
            dtpProductionDate.Value = DateTime.Today;
        }
    }
}

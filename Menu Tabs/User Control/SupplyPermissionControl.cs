using System;
using System.Linq;
using System.Windows.Forms;
using InventorySystem.Data;
using Microsoft.EntityFrameworkCore;

namespace InventorySystem.Tabs.User_Control
{
    public partial class SupplyPermissionControl : UserControl
    {
        private readonly CompanyContext _context;
        private int? editingItemId = null;

        public SupplyPermissionControl()
        {
            InitializeComponent();
            _context = new CompanyContext();
            LoadDropdowns();
            LoadSupplyItems();

            dgvSupplyItems.CellClick += dgvSupplyItems_CellClick;
        }

        private void LoadDropdowns()
        {
            cmbStore.DataSource = _context.Warehouses.ToList();
            cmbStore.DisplayMember = "Name";
            cmbStore.ValueMember = "Id";

            cmbItem.DataSource = _context.Productitems.ToList();
            cmbItem.DisplayMember = "Name";
            cmbItem.ValueMember = "Id";

            cmbSupplier.DataSource = _context.Suppliers.ToList();
            cmbSupplier.DisplayMember = "Name";
            cmbSupplier.ValueMember = "Id";
        }

        private void LoadSupplyItems()
        {
            dgvSupplyItems.Columns.Clear();

            dgvSupplyItems.DataSource = _context.SupplyPermissionItems
                .Include(i => i.SupplyPermission).ThenInclude(p => p.Store)
                .Include(i => i.Item)
                .Include(i => i.Supplier)
                .Select(i => new
                {
                    i.Id,
                    رقم_الإذن = i.SupplyPermission.PermissionNumber,
                    التاريخ = i.SupplyPermission.PermissionDate,
                    المخزن = i.SupplyPermission.Store.Name,
                    الصنف = i.Item.Name,
                    الكود = i.Item.Code,
                    الكمية = i.Quantity,
                    المورد = i.Supplier.Name,
                    تاريخ_الإنتاج = i.ProductionDate,
                    الصلاحية_بالأشهر = i.ExpiryMonths
                })
                .ToList();

            dgvSupplyItems.Columns["Id"].Visible = false;
        }

        private void dgvSupplyItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                editingItemId = Convert.ToInt32(dgvSupplyItems.Rows[e.RowIndex].Cells["Id"].Value);
                LoadSupplyItemToForm(editingItemId.Value);
            }
        }

        private void LoadSupplyItemToForm(int id)
        {
            var item = _context.SupplyPermissionItems
                .Include(i => i.SupplyPermission)
                .FirstOrDefault(i => i.Id == id);

            if (item == null) return;

            txtPermissionNumber.Text = item.SupplyPermission.PermissionNumber;
            dtpPermissionDate.Value = item.SupplyPermission.PermissionDate;

            cmbStore.SelectedValue = item.SupplyPermission.StoreId;
            cmbItem.SelectedValue = item.ItemId;
            cmbSupplier.SelectedValue = item.SupplierId;

            txtQuantity.Text = item.Quantity.ToString();
            dtpProductionDate.Value = item.ProductionDate;
            txtExpiryMonths.Text = item.ExpiryMonths.ToString();
        }

        private void ClearForm()
        {
            txtPermissionNumber.Clear();
            txtItemCode.Clear();
            txtQuantity.Clear();
            txtExpiryMonths.Clear();
            editingItemId = null;
        }

        private void btnAddSupply_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbStore.SelectedItem == null || cmbItem.SelectedItem == null || cmbSupplier.SelectedItem == null)
                {
                    MessageBox.Show("الرجاء اختيار المخزن والصنف والمورد", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var storeId = (int)cmbStore.SelectedValue;
                var itemId = (int)cmbItem.SelectedValue;
                var supplierId = (int)cmbSupplier.SelectedValue;

                var permissionNumber = txtPermissionNumber.Text.Trim();
                var permissionDate = dtpPermissionDate.Value;
                var quantity = int.TryParse(txtQuantity.Text, out int qtyVal) ? qtyVal : 0;
                var productionDate = dtpProductionDate.Value;
                var expiryMonths = int.TryParse(txtExpiryMonths.Text, out int expVal) ? expVal : 0;

                if (quantity <= 0 || expiryMonths <= 0)
                {
                    MessageBox.Show("يرجى إدخال كمية وصلاحية صحيحة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var permission = new SupplyPermission
                {
                    StoreId = storeId,
                    PermissionNumber = permissionNumber,
                    PermissionDate = permissionDate
                };

                _context.SupplyPermissions.Add(permission);
                _context.SaveChanges();

                var item = new SupplyPermissionItem
                {
                    SupplyPermissionId = permission.Id,
                    ItemId = itemId,
                    Quantity = quantity,
                    SupplierId = supplierId,
                    ProductionDate = productionDate,
                    ExpiryMonths = expiryMonths
                };

                _context.SupplyPermissionItems.Add(item);
                _context.SaveChanges();

                MessageBox.Show("تمت إضافة إذن التوريد بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearForm();
                LoadSupplyItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditSupply_Click(object sender, EventArgs e)
        {
            if (!editingItemId.HasValue)
            {
                MessageBox.Show("يرجى تحديد صف من الجدول لتعديله");
                return;
            }

            var item = _context.SupplyPermissionItems
                .Include(i => i.SupplyPermission)
                .FirstOrDefault(i => i.Id == editingItemId.Value);

            if (item == null) return;

            item.SupplyPermission.StoreId = (int)cmbStore.SelectedValue;
            item.SupplyPermission.PermissionNumber = txtPermissionNumber.Text.Trim();
            item.SupplyPermission.PermissionDate = dtpPermissionDate.Value;

            item.ItemId = (int)cmbItem.SelectedValue;
            item.SupplierId = (int)cmbSupplier.SelectedValue;
            item.ProductionDate = dtpProductionDate.Value;

            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0 ||
                !int.TryParse(txtExpiryMonths.Text, out int expiryMonths) || expiryMonths <= 0)
            {
                MessageBox.Show("يرجى إدخال بيانات صحيحة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            item.Quantity = quantity;
            item.ExpiryMonths = expiryMonths;

            _context.SaveChanges();

            MessageBox.Show("تم تعديل إذن التوريد بنجاح");
            ClearForm();
            LoadSupplyItems();
        }

        private void btnDeleteSupply_Click(object sender, EventArgs e)
        {
            if (!editingItemId.HasValue)
            {
                MessageBox.Show("يرجى اختيار صف من الجدول لحذفه");
                return;
            }

            var confirm = MessageBox.Show("هل أنت متأكد من حذف هذا الإذن؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                var item = _context.SupplyPermissionItems
                    .Include(i => i.SupplyPermission)
                    .FirstOrDefault(i => i.Id == editingItemId.Value);

                if (item == null) return;

                _context.SupplyPermissionItems.Remove(item);
                _context.SupplyPermissions.Remove(item.SupplyPermission);
                _context.SaveChanges();

                MessageBox.Show("تم حذف إذن التوريد بنجاح");

                ClearForm();
                LoadSupplyItems();
            }
        }

        private void txtExpiryMonths_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

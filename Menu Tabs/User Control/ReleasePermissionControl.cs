using System;
using System.Linq;
using System.Windows.Forms;
using InventorySystem.Data;
using Microsoft.EntityFrameworkCore;

namespace InventorySystem.Tabs.User_Control
{
    public partial class ReleasePermissionControl : UserControl
    {
        private readonly CompanyContext _context;
        private int? editingItemId = null;

        public ReleasePermissionControl()
        {
            InitializeComponent();
            _context = new CompanyContext();
            LoadDropdowns();
            LoadReleaseItems();

            dgvReleaseItems.CellClick += dgvReleaseItems_CellClick;
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

        private void LoadReleaseItems()
        {
            dgvReleaseItems.Columns.Clear();

            dgvReleaseItems.DataSource = _context.ReleasePermissionItems
                .Include(r => r.ReleasePermission)
                .Include(r => r.Item)
                .Include(r => r.Supplier)
                .Select(i => new
                {
                    i.Id,
                    رقم_الإذن = i.ReleasePermission.PermissionNumber,
                    التاريخ = i.ReleasePermission.PermissionDate,
                    المخزن = i.ReleasePermission.Store.Name,
                    الصنف = i.Item.Name,
                    الكمية = i.Quantity,
                    المورد = i.Supplier.Name
                })
                .ToList();

            dgvReleaseItems.Columns["Id"].Visible = false;
        }

        private void dgvReleaseItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                editingItemId = Convert.ToInt32(dgvReleaseItems.Rows[e.RowIndex].Cells["Id"].Value);
                LoadReleaseItemToForm(editingItemId.Value);
            }
        }

        private void LoadReleaseItemToForm(int id)
        {
            var item = _context.ReleasePermissionItems
                .Include(r => r.ReleasePermission)
                .FirstOrDefault(i => i.Id == id);

            if (item == null) return;

            txtPermissionNumber.Text = item.ReleasePermission.PermissionNumber;
            dtpPermissionDate.Value = item.ReleasePermission.PermissionDate;

            cmbStore.SelectedValue = item.ReleasePermission.StoreId;
            cmbItem.SelectedValue = item.ItemId;
            cmbSupplier.SelectedValue = item.SupplierId;
            txtQuantity.Text = item.Quantity.ToString();
        }

        private void ClearForm()
        {
            txtPermissionNumber.Clear();
            txtQuantity.Clear();
            editingItemId = null;
        }

        private void btnAddRelease_Click(object sender, EventArgs e)
        {
            if (cmbStore.SelectedItem == null || cmbItem.SelectedItem == null || cmbSupplier.SelectedItem == null)
            {
                MessageBox.Show("يرجى اختيار المخزن، الصنف، والمورد", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int storeId = (int)cmbStore.SelectedValue;
            int itemId = (int)cmbItem.SelectedValue;
            int supplierId = (int)cmbSupplier.SelectedValue;
            string permissionNumber = txtPermissionNumber.Text.Trim();
            DateTime permissionDate = dtpPermissionDate.Value;

            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("يرجى إدخال كمية صحيحة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var permission = new ReleasePermission
            {
                StoreId = storeId,
                PermissionNumber = permissionNumber,
                PermissionDate = permissionDate
            };

            _context.ReleasePermissions.Add(permission);
            _context.SaveChanges();

            var item = new ReleasePermissionItem
            {
                ReleasePermissionId = permission.Id,
                ItemId = itemId,
                Quantity = quantity,
                SupplierId = supplierId
            };

            _context.ReleasePermissionItems.Add(item);
            _context.SaveChanges();

            MessageBox.Show("تمت إضافة إذن الصرف بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearForm();
            LoadReleaseItems();
        }

        private void btnEditRelease_Click(object sender, EventArgs e)
        {
            if (!editingItemId.HasValue)
            {
                MessageBox.Show("يرجى تحديد صف من الجدول لتعديله");
                return;
            }

            var item = _context.ReleasePermissionItems
                .Include(r => r.ReleasePermission)
                .FirstOrDefault(i => i.Id == editingItemId.Value);

            if (item == null) return;

            item.ReleasePermission.StoreId = (int)cmbStore.SelectedValue;
            item.ReleasePermission.PermissionNumber = txtPermissionNumber.Text.Trim();
            item.ReleasePermission.PermissionDate = dtpPermissionDate.Value;

            item.ItemId = (int)cmbItem.SelectedValue;
            item.SupplierId = (int)cmbSupplier.SelectedValue;

            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("يرجى إدخال كمية صحيحة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            item.Quantity = quantity;

            _context.SaveChanges();
            MessageBox.Show("تم التعديل بنجاح");

            ClearForm();
            LoadReleaseItems();
        }

        private void btnDeleteRelease_Click(object sender, EventArgs e)
        {
            if (!editingItemId.HasValue)
            {
                MessageBox.Show("يرجى تحديد صف من الجدول لحذفه");
                return;
            }

            var confirm = MessageBox.Show("هل أنت متأكد من حذف هذا الإذن؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                var item = _context.ReleasePermissionItems
                    .Include(r => r.ReleasePermission)
                    .FirstOrDefault(i => i.Id == editingItemId.Value);

                if (item == null) return;

                _context.ReleasePermissionItems.Remove(item);
                _context.ReleasePermissions.Remove(item.ReleasePermission);
                _context.SaveChanges();

                MessageBox.Show("تم الحذف بنجاح");

                ClearForm();
                LoadReleaseItems();
            }
        }

        private void cmbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            //put the items from table productitems into the cmbItem dropdown
            if (!editingItemId.HasValue) {
                cmbItem.DataSource = _context.Productitems.ToList();
                cmbItem.DisplayMember = "Name";
                cmbItem.ValueMember = "Id";
            }
            // If no item is selected, return early
            if (cmbItem.SelectedIndex < 0) return;
            // If the selected item is null, return early
            // If the selected item is not null, you can access its properties

          
            
        }
    }
}

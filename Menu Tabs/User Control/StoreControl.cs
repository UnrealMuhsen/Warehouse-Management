using System;
using System.Linq;
using System.Windows.Forms;
using InventorySystem.Data;

namespace InventorySystem.Tabs.User_Control
{
    public partial class StoreControl : UserControl
    {
        private readonly CompanyContext _context;
        private int? editingStoreId = null;

        public StoreControl()
        {
            InitializeComponent();
            _context = new CompanyContext();
            LoadStores();

            dgvStores.CellClick += dgvStores_CellClick;
        }

        private void LoadStores()
        {
            dgvStores.Columns.Clear();

            dgvStores.DataSource = _context.Warehouses
                .Select(s => new
                {
                    Id = s.Id,
                    الاسم = s.Name,
                    العنوان = s.Address,
                    المسؤول = s.Manager
                })
                .ToList();

            dgvStores.Columns["Id"].Visible = false;
        }

        private void dgvStores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                editingStoreId = Convert.ToInt32(dgvStores.Rows[e.RowIndex].Cells["Id"].Value);
                LoadStoreToForm(editingStoreId.Value);
            }
        }

        private void LoadStoreToForm(int id)
        {
            var store = _context.Warehouses.Find(id);
            if (store == null) return;

            txtStoreName.Text = store.Name;
            txtStoreAddress.Text = store.Address;
            txtStoreManager.Text = store.Manager;
        }

        private void ClearForm()
        {
            txtStoreName.Clear();
            txtStoreAddress.Clear();
            txtStoreManager.Clear();
            editingStoreId = null;
        }

        private void btnAddStore_Click(object sender, EventArgs e)
        {
            string name = txtStoreName.Text.Trim();
            string address = txtStoreAddress.Text.Trim();
            string manager = txtStoreManager.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(manager))
            {
                MessageBox.Show("من فضلك أدخل جميع البيانات", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newStore = new Warehouse
            {
                Name = name,
                Address = address,
                Manager = manager
            };

            _context.Warehouses.Add(newStore);
            _context.SaveChanges();

            MessageBox.Show("تمت إضافة المخزن بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearForm();
            LoadStores();
        }

        private void btnEditStore_Click(object sender, EventArgs e)
        {
            if (!editingStoreId.HasValue)
            {
                MessageBox.Show("يرجى اختيار مخزن من الجدول لتعديله");
                return;
            }

            var store = _context.Warehouses.Find(editingStoreId.Value);
            if (store == null) return;

            store.Name = txtStoreName.Text.Trim();
            store.Address = txtStoreAddress.Text.Trim();
            store.Manager = txtStoreManager.Text.Trim();

            _context.SaveChanges();

            MessageBox.Show("تم تعديل بيانات المخزن بنجاح");
            ClearForm();
            LoadStores();
        }

        private void btnDeleteStore_Click(object sender, EventArgs e)
        {
            if (!editingStoreId.HasValue)
            {
                MessageBox.Show("يرجى اختيار مخزن من الجدول لحذفه");
                return;
            }

            var confirm = MessageBox.Show("هل أنت متأكد من حذف هذا المخزن؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                var store = _context.Warehouses.Find(editingStoreId.Value);
                if (store == null) return;

                _context.Warehouses.Remove(store);
                _context.SaveChanges();

                MessageBox.Show("تم حذف المخزن بنجاح");
                ClearForm();
                LoadStores();
            }
        }
    }
}

using System;
using System.Linq;
using System.Windows.Forms;
using InventorySystem.Data;

namespace InventorySystem.Tabs.User_Control
{
    public partial class SupplierControl : UserControl
    {
        private readonly CompanyContext _context;
        private int? editingSupplierId = null;

        public SupplierControl()
        {
            InitializeComponent();
            _context = new CompanyContext();
            LoadSuppliers();

            dgvSuppliers.CellClick += dgvSuppliers_CellClick;
        }

        private void LoadSuppliers()
        {
            dgvSuppliers.Columns.Clear();

            var suppliers = _context.Suppliers
                .Select(s => new
                {
                    Id = s.Id,
                    s.Name,
                    s.Phone,
                    s.Mobile,
                    s.Email,
                    s.Fax,
                    s.Website
                })
                .ToList();

            dgvSuppliers.DataSource = suppliers;
            dgvSuppliers.Columns["Id"].Visible = false;
        }

        private void dgvSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                editingSupplierId = Convert.ToInt32(dgvSuppliers.Rows[e.RowIndex].Cells["Id"].Value);
                LoadSupplierToForm(editingSupplierId.Value);
            }
        }

        private void LoadSupplierToForm(int id)
        {
            var supplier = _context.Suppliers.Find(id);
            if (supplier == null) return;

            txtSupName.Text = supplier.Name;
            txtSupPhone.Text = supplier.Phone;
            txtSupMobile.Text = supplier.Mobile;
            txtSupEmail.Text = supplier.Email;
            txtSupFax.Text = supplier.Fax;
            txtSupWebsite.Text = supplier.Website;
        }

        private void ClearForm()
        {
            txtSupName.Clear();
            txtSupPhone.Clear();
            txtSupMobile.Clear();
            txtSupEmail.Clear();
            txtSupFax.Clear();
            txtSupWebsite.Clear();
            editingSupplierId = null;
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            string name = txtSupName.Text.Trim();
            string phone = txtSupPhone.Text.Trim();
            string mobile = txtSupMobile.Text.Trim();
            string email = txtSupEmail.Text.Trim();
            string fax = txtSupFax.Text.Trim();
            string website = txtSupWebsite.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("الرجاء إدخال اسم المورد", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var supplier = new Supplier
            {
                Name = name,
                Phone = phone,
                Mobile = mobile,
                Email = email,
                Fax = fax,
                Website = website
            };

            _context.Suppliers.Add(supplier);
            _context.SaveChanges();
            LoadSuppliers();
            ClearForm();

            MessageBox.Show("تمت إضافة المورد بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEditSupplier_Click(object sender, EventArgs e)
        {
            if (!editingSupplierId.HasValue)
            {
                MessageBox.Show("يرجى اختيار مورد أولاً من الجدول");
                return;
            }

            var supplier = _context.Suppliers.Find(editingSupplierId.Value);
            if (supplier == null) return;

            supplier.Name = txtSupName.Text.Trim();
            supplier.Phone = txtSupPhone.Text.Trim();
            supplier.Mobile = txtSupMobile.Text.Trim();
            supplier.Email = txtSupEmail.Text.Trim();
            supplier.Fax = txtSupFax.Text.Trim();
            supplier.Website = txtSupWebsite.Text.Trim();

            _context.SaveChanges();
            LoadSuppliers();
            ClearForm();

            MessageBox.Show("تم تعديل بيانات المورد بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDeleteSupplier_Click(object sender, EventArgs e)
        {
            if (!editingSupplierId.HasValue)
            {
                MessageBox.Show("يرجى اختيار مورد من الجدول لحذفه");
                return;
            }

            var confirm = MessageBox.Show("هل أنت متأكد من حذف هذا المورد؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                var supplier = _context.Suppliers.Find(editingSupplierId.Value);
                if (supplier == null) return;

                _context.Suppliers.Remove(supplier);
                _context.SaveChanges();

                MessageBox.Show("تم حذف المورد بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSuppliers();
                ClearForm();
            }
        }
    }
}

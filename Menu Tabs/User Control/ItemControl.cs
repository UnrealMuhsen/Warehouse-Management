using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using InventorySystem.Data;
using Microsoft.EntityFrameworkCore;


namespace InventorySystem.Tabs.User_Control
{
    public partial class ItemControl : UserControl
    {
        private readonly CompanyContext _context = new CompanyContext();
        private int? editingItemId = null;

        public ItemControl()
        {
            InitializeComponent();
            LoadItems();

            dgvItems.CellClick += dgvItems_CellClick;
        }

        private void LoadItems()
        {
            dgvItems.Columns.Clear();

            dgvItems.DataSource = _context.Productitems
                .Select(i => new
                {
                    i.Id,
                    i.Code,
                    i.Name,
                    Units = string.Join(", ", i.Units.Select(u => u.UnitName))
                })
                .ToList();

            dgvItems.Columns["Id"].Visible = false;
        }

        private void dgvItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                editingItemId = Convert.ToInt32(dgvItems.Rows[e.RowIndex].Cells["Id"].Value);
                LoadItemToForm(editingItemId.Value);
            }
        }

        private void LoadItemToForm(int id)
        {
            var item = _context.Productitems.Include(i => i.Units).FirstOrDefault(i => i.Id == id);
            if (item == null) return;

            txtCode.Text = item.Code;
            txtName.Text = item.Name;

            var unit = item.Units.FirstOrDefault();
            txtUnit.Text = unit?.UnitName ?? "";
        }

        private void ClearForm()
        {
            txtCode.Clear();
            txtName.Clear();
            txtUnit.Clear();
            editingItemId = null;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCode.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtUnit.Text))
            {
                MessageBox.Show("يرجى ملء جميع الحقول");
                return;
            }

            var item = new Productitem
            {
                Code = txtCode.Text,
                Name = txtName.Text,
                Units = new List<ProductItemUnit> { new ProductItemUnit { UnitName = txtUnit.Text } }
            };

            _context.Productitems.Add(item);
            _context.SaveChanges();

            MessageBox.Show("تمت إضافة الصنف بنجاح");
            LoadItems();
            ClearForm();
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            if (!editingItemId.HasValue)
            {
                MessageBox.Show("يرجى تحديد صنف أولاً");
                return;
            }

            var item = _context.Productitems.Find(editingItemId.Value);
            if (item == null) return;

            item.Code = txtCode.Text;
            item.Name = txtName.Text;

            var unit = _context.ProductItemUnits.FirstOrDefault(u => u.ItemId == item.Id);
            if (unit != null)
            {
                unit.UnitName = txtUnit.Text;
            }
            else
            {
                _context.ProductItemUnits.Add(new ProductItemUnit { ItemId = item.Id, UnitName = txtUnit.Text });
            }

            _context.SaveChanges();

            MessageBox.Show("تم تعديل الصنف بنجاح");
            LoadItems();
            ClearForm();
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (!editingItemId.HasValue)
            {
                MessageBox.Show("يرجى تحديد صنف أولاً");
                return;
            }

            var confirm = MessageBox.Show("هل أنت متأكد من حذف هذا الصنف؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                var item = _context.Productitems.Find(editingItemId.Value);
                if (item == null) return;

                _context.Productitems.Remove(item);
                _context.SaveChanges();

                MessageBox.Show("تم حذف الصنف بنجاح");
                LoadItems();
                ClearForm();
            }
        }
    }
}

using InventorySystem.Data;
using System;
using System.Linq;
using System.Windows.Forms;

namespace InventorySystem.Tabs.User_Control
{
    public partial class CustomerControl : UserControl
    {
        private readonly CompanyContext _context = new CompanyContext();
        private int? editingCustomerId = null;

        public CustomerControl()
        {
            InitializeComponent();
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            dgvCustomers.Columns.Clear();

            dgvCustomers.DataSource = _context.Agents
                .Select(c => new
                {
                    c.Id,
                    c.Name,
                    c.Phone,
                    c.Mobile,
                    c.Email,
                    c.Fax,
                    c.Website
                })
                .ToList();

            dgvCustomers.Columns["Id"].Visible = false;

            dgvCustomers.CellClick -= dgvCustomers_CellClick; 
            dgvCustomers.CellClick += dgvCustomers_CellClick;
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                editingCustomerId = Convert.ToInt32(dgvCustomers.Rows[e.RowIndex].Cells["Id"].Value);
                LoadCustomerToForm(editingCustomerId.Value);
            }
        }

        private void LoadCustomerToForm(int id)
        {
            var customer = _context.Agents.Find(id);
            if (customer == null) return;

            txtCustName.Text = customer.Name;
            txtCustPhone.Text = customer.Phone;
            txtCustMobile.Text = customer.Mobile;
            txtCustEmail.Text = customer.Email;
            txtCustFax.Text = customer.Fax;
            txtCustWebsite.Text = customer.Website;
        }

        private void ClearCustomerForm()
        {
            txtCustName.Clear();
            txtCustPhone.Clear();
            txtCustMobile.Clear();
            txtCustEmail.Clear();
            txtCustFax.Clear();
            txtCustWebsite.Clear();
            editingCustomerId = null;
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustName.Text))
            {
                MessageBox.Show("يرجى إدخال اسم العميل");
                return;
            }

            var customer = new Agent
            {
                Name = txtCustName.Text.Trim(),
                Phone = txtCustPhone.Text.Trim(),
                Mobile = txtCustMobile.Text.Trim(),
                Email = txtCustEmail.Text.Trim(),
                Fax = txtCustFax.Text.Trim(),
                Website = txtCustWebsite.Text.Trim()
            };

            _context.Agents.Add(customer);
            _context.SaveChanges();

            MessageBox.Show("تمت إضافة العميل بنجاح");
            ClearCustomerForm();
            LoadCustomers();
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (!editingCustomerId.HasValue)
            {
                MessageBox.Show("يرجى تحديد العميل أولاً من الجدول");
                return;
            }

            var customer = _context.Agents.Find(editingCustomerId.Value);
            if (customer == null) return;

            customer.Name = txtCustName.Text.Trim();
            customer.Phone = txtCustPhone.Text.Trim();
            customer.Mobile = txtCustMobile.Text.Trim();
            customer.Email = txtCustEmail.Text.Trim();
            customer.Fax = txtCustFax.Text.Trim();
            customer.Website = txtCustWebsite.Text.Trim();

            _context.SaveChanges();
            MessageBox.Show("تم تعديل بيانات العميل بنجاح");

            ClearCustomerForm();
            LoadCustomers();
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (!editingCustomerId.HasValue)
            {
                MessageBox.Show("يرجى تحديد العميل أولاً من الجدول");
                return;
            }

            var result = MessageBox.Show("هل أنت متأكد من حذف العميل؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                var customer = _context.Agents.Find(editingCustomerId.Value);
                if (customer == null) return;

                _context.Agents.Remove(customer);
                _context.SaveChanges();

                MessageBox.Show("تم حذف العميل بنجاح");

                ClearCustomerForm();
                LoadCustomers();
            }
        }
    }
}

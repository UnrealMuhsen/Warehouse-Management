using InventorySystem.Data;
using System;
using System.Linq;
using System.Windows.Forms;

namespace InventorySystem.Tabs.User_Control
{
    public partial class WarehouseReports : UserControl
    {
        private readonly CompanyContext _context = new CompanyContext();
        private bool _isLoaded = false;
        public WarehouseReports()
        {
            InitializeComponent();
            LoadWarehouses();
        }

        private void LoadWarehouses()
        {
            var warehouses = _context.Warehouses.ToList();
            comboBox1.DataSource = warehouses;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue is int selectedWarehouseId)
            {
                var supplyItems = _context.SupplyPermissionItems
                    .Where(i => i.SupplyPermission.StoreId == selectedWarehouseId)
                    .Select(i => new
                    {
                        نوع = "توريد",
                        الصنف = i.Item.Name,
                        الكمية = i.Quantity,
                        التاريخ = i.SupplyPermission.PermissionDate
                    });

                var releaseItems = _context.ReleasePermissionItems
                    .Where(i => i.ReleasePermission.StoreId == selectedWarehouseId)
                    .Select(i => new
                    {
                        نوع = "صرف",
                        الصنف = i.Item.Name,
                        الكمية = i.Quantity,
                        التاريخ = i.ReleasePermission.PermissionDate
                    });

                var allItems = supplyItems.Concat(releaseItems)
                    .OrderBy(i => i.التاريخ)
                    .ToList();

                dataGridView1.DataSource = allItems;
            }
        }


   


    }
}

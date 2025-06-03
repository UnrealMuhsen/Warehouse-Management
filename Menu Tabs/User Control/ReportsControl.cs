using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using InventorySystem.Data;

namespace InventorySystem.Tabs.User_Control
{
    public partial class ReportsControl : UserControl
    {
        private readonly CompanyContext _context;

        public ReportsControl()
        {
            InitializeComponent();
            _context = new CompanyContext();
        }

        private void btnStoreReport_Click(object sender, EventArgs e)
        {
            var report = new StringBuilder();
            report.AppendLine("تقرير المخازن:\n");

            foreach (var store in _context.Warehouses.ToList())
            {
                report.AppendLine($"اسم المخزن: {store.Name}");
                report.AppendLine($"العنوان: {store.Address}");
                report.AppendLine($"المسؤول: {store.Manager}");
                report.AppendLine("-------------------------------");
            }

            txtReportOutput.Text = report.ToString();
        }

        private void btnItemReport_Click(object sender, EventArgs e)
        {
            var report = new StringBuilder();
            report.AppendLine("تقرير الأصناف:\n");

            foreach (var item in _context.Productitems.ToList())
            {
                report.AppendLine($"كود الصنف: {item.Code}");
                report.AppendLine($"الاسم: {item.Name}");
                report.AppendLine("-------------------------------");
            }

            txtReportOutput.Text = report.ToString();
        }

        private void btnMovementReport_Click(object sender, EventArgs e)
        {
            var report = new StringBuilder();
            report.AppendLine("تقرير حركة الأصناف:\n");

          
            var supply = _context.SupplyPermissionItems
                .Select(i => new
                {
                    Type = "توريد",
                    Store = i.SupplyPermission.Store.Name,
                    Item = i.Item.Name,
                    Quantity = i.Quantity,
                    Date = i.SupplyPermission.PermissionDate
                });

        
            var release = _context.ReleasePermissionItems
                .Select(i => new
                {
                    Type = "صرف",
                    Store = i.ReleasePermission.Store.Name,
                    Item = i.Item.Name,
                    Quantity = i.Quantity,
                    Date = i.ReleasePermission.PermissionDate
                });

           
            var movements = supply.Concat(release).OrderBy(m => m.Date).ToList();

            foreach (var m in movements)
            {
                report.AppendLine($"[{m.Type}] المخزن: {m.Store}, الصنف: {m.Item}, الكمية: {m.Quantity}, التاريخ: {m.Date:yyyy-MM-dd}");
            }

            txtReportOutput.Text = report.ToString();
        }

        private void btnAgedItemsReport_Click(object sender, EventArgs e)
        {
            var threshold = DateTime.Now.AddMonths(-6);
            var report = new StringBuilder();
            report.AppendLine("الأصناف المخزنة لأكثر من 6 أشهر:\n");

            var items = _context.SupplyPermissionItems
                .Where(i => i.ProductionDate < threshold)
                .ToList();

            foreach (var i in items)
            {
                report.AppendLine($"الصنف: {i.Item?.Name}, التاريخ: {i.ProductionDate:d}");
            }

            txtReportOutput.Text = report.ToString();
        }

        private void btnExpiryReport_Click(object sender, EventArgs e)
        {
            var report = new StringBuilder();
            report.AppendLine("الأصناف القريبة من انتهاء الصلاحية:\n");

            var items = _context.SupplyPermissionItems
                .ToList()
                .Where(i => i.ProductionDate.AddMonths(i.ExpiryMonths) <= DateTime.Now.AddMonths(1))
                .ToList();

            foreach (var i in items)
            {
                var expiry = i.ProductionDate.AddMonths(i.ExpiryMonths);
                report.AppendLine($"الصنف: {i.Item?.Name}, ينتهي في: {expiry:d}");
            }

            txtReportOutput.Text = report.ToString();
        }
    }
}

 using InventorySystem.Tabs.User_Control;
using System.Windows.Forms;

namespace InventorySystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

           
            var itemsPage = new TabPage("إدارة الأصناف");
            var itemsControl = new ItemControl();
            itemsControl.Dock = DockStyle.Fill;
            itemsPage.Controls.Add(itemsControl);
            mainTabControl.TabPages.Add(itemsPage);

         
            var storesPage = new TabPage("إدارة المخازن");
            var storesControl = new StoreControl();
            storesControl.Dock = DockStyle.Fill;
            storesPage.Controls.Add(storesControl);
            mainTabControl.TabPages.Add(storesPage);

        
            var suppliersPage = new TabPage("الموردين");
            var suppliersControl = new SupplierControl();
            suppliersControl.Dock = DockStyle.Fill;
            suppliersPage.Controls.Add(suppliersControl);
            mainTabControl.TabPages.Add(suppliersPage);

            var customerTab = new TabPage("العملاء");
            var customerControl = new CustomerControl();
            customerControl.Dock = DockStyle.Fill;
            customerTab.Controls.Add(customerControl);
            mainTabControl.TabPages.Add(customerTab);

          

            var supplyTab = new TabPage("إذن التوريد");
            var supplyControl = new SupplyPermissionControl();
            supplyControl.Dock = DockStyle.Fill;
            supplyTab.Controls.Add(supplyControl);
            mainTabControl.TabPages.Add(supplyTab);

      
            var releaseTab = new TabPage("إذن الصرف");
            var releaseControl = new ReleasePermissionControl();
            releaseControl.Dock = DockStyle.Fill;
            releaseTab.Controls.Add(releaseControl);
            mainTabControl.TabPages.Add(releaseTab);
        

            var transferTab = new TabPage("تحويل الأصناف");
            var transferControl = new StockTransferControl();
            transferControl.Dock = DockStyle.Fill;
            transferTab.Controls.Add(transferControl);
            mainTabControl.TabPages.Add(transferTab);

        
            var reportsTab = new TabPage("التقارير");
            var reportsControl = new ReportsControl();
            reportsControl.Dock = DockStyle.Fill;
            reportsTab.Controls.Add(reportsControl);
            mainTabControl.TabPages.Add(reportsTab);

            TabPage warehouseTab = new TabPage(" تقرير خاص بالمخازن");
            WarehouseReports warehouseControl = new WarehouseReports();
            warehouseControl.Dock = DockStyle.Fill;
            warehouseTab.Controls.Add(warehouseControl);
            mainTabControl.TabPages.Add(warehouseTab);





        }
    }
}

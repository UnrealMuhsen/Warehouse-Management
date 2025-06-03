using InventorySystem.Data;

namespace InventorySystem
{
    internal static class Program
    {
    
        [STAThread]
        static void Main()
        {
      
       
            using (var context = new CompanyContext())
            {
                context.Database.EnsureCreated();
            }
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
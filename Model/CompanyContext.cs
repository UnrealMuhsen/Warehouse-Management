using Microsoft.EntityFrameworkCore;

namespace InventorySystem.Data
{
    public class CompanyContext : DbContext
    {
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Productitem> Productitems { get; set; }
        public DbSet<ProductItemUnit> ProductItemUnits { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Agent> Agents { get; set; }
        public DbSet<SupplyPermission> SupplyPermissions { get; set; }
        public DbSet<SupplyPermissionItem> SupplyPermissionItems { get; set; }
        public DbSet<ReleasePermission> ReleasePermissions { get; set; }
        public DbSet<ReleasePermissionItem> ReleasePermissionItems { get; set; }
        public DbSet<StockTransfer> StockTransfers { get; set; }
        public DbSet<StockTransferItem> StockTransferItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Data Source=.;Initial Catalog=InventoryDatabase;Integrated Security=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<Productitem>()
                .HasMany(i => i.Units)
                .WithOne(u => u.Item)
                .HasForeignKey(u => u.ItemId);

           
            modelBuilder.Entity<SupplyPermissionItem>()
                .HasOne(s => s.Item)
                .WithMany()
                .HasForeignKey(s => s.ItemId);

            modelBuilder.Entity<SupplyPermissionItem>()
                .HasOne(s => s.Supplier)
                .WithMany()
                .HasForeignKey(s => s.SupplierId);

         
            modelBuilder.Entity<ReleasePermissionItem>()
                .HasOne(r => r.Item)
                .WithMany()
                .HasForeignKey(r => r.ItemId);

            modelBuilder.Entity<ReleasePermissionItem>()
                .HasOne(r => r.Supplier)
                .WithMany()
                .HasForeignKey(r => r.SupplierId);

       
            modelBuilder.Entity<StockTransferItem>()
                .HasOne(t => t.Item)
                .WithMany()
                .HasForeignKey(t => t.ItemId);

            modelBuilder.Entity<StockTransferItem>()
                .HasOne(t => t.Supplier)
                .WithMany()
                .HasForeignKey(t => t.SupplierId);

           
            modelBuilder.Entity<StockTransfer>()
                .HasOne(t => t.FromStore)
                .WithMany()
                .HasForeignKey(t => t.FromStoreId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<StockTransfer>()
                .HasOne(t => t.ToStore)
                .WithMany()
                .HasForeignKey(t => t.ToStoreId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

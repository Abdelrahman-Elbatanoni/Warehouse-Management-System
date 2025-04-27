using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    public class CompanyContext :DbContext
    {
        public DbSet<WareHouse> Warehouses { get; set; }
        public DbSet<Secretary> Secretaries { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<WarehouseItem> WarehouseItems { get; set; }

        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<SupplyVoucher> SupplyVouchers { get; set; }
        public DbSet<SupplyVoucherItem> SupplyVoucherItems { get; set; }
        public DbSet<SupplyVoucherItemWarehouse> SupplyVoucherItemWarehouses { get; set; }

        public DbSet<StockReleaseVoucher> StockReleaseVouchers { get; set; }
        public DbSet<StockReleaseVoucherItem> StockReleaseVoucherItems { get; set; }
        public DbSet<StockReleaseVoucherItemWarehouse> StockReleaseVoucherItemWarehouses { get; set; }

        public DbSet<TransferVoucher> TransferVouchers { get; set; }
        public DbSet<TransferVoucherItem> TransferVoucherItems { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer($"Server=LAPTOP-UU51GHLA\\SQLEXPRESS;Database=Commercial_Company; Integrated Security=True; TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Secretary>()
            .HasOne(s => s.WareHouse)
            .WithOne(w => w.Secretary)
            .HasForeignKey<WareHouse>(w => w.SecretaryId)
            .OnDelete(DeleteBehavior.Restrict); // Prevent warehouse deletion


            modelBuilder.Entity<WarehouseItem>()
            .HasKey(wi => new { wi.ItemId, wi.WarehouseId,wi.SupplyVoucherId }); // Composite Key

            modelBuilder.Entity<WarehouseItem>()
                .HasOne(wi => wi.Warehouse)
                .WithMany(w => w.WarehouseItems)
                .HasForeignKey(wi => wi.WarehouseId);

            modelBuilder.Entity<WarehouseItem>()
                .HasOne(wi => wi.Item)
                .WithMany(i => i.WarehouseItems)
                .HasForeignKey(wi => wi.ItemId);

            modelBuilder.Entity<WarehouseItem>()
                .HasOne(wi => wi.SupplyVoucher)
                .WithMany(s => s.WarehouseItems)
                .HasForeignKey(wi => wi.SupplyVoucherId);

        }
    }
}

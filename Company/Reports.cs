using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Company
{
    public partial class Reports : Form
    {
        private CompanyContext comp;
        public Reports(CompanyContext c)
        {
            InitializeComponent();
            comp = c;
        }

        private void load_SupplyVouchers()
        {
            SupplyVocherBox.Items.Clear();
            foreach (var SV in comp.SupplyVouchers)
            {
                SupplyVocherBox.Items.Add(SV.Id);
            }
        }
        private void load_StockReleaseVouchers()
        {
            StockReleaseVoucherBox.Items.Clear();
            foreach (var SRV in comp.StockReleaseVouchers)
            {
                StockReleaseVoucherBox.Items.Add(SRV.Id);
            }
        }
        private void load_Warehouses()
        {
            WarehouseBox.Items.Clear();
            itmStoringPeriod_WarehouseBox.Items.Clear();
            itmsToExpire_WarehouseBox.Items.Clear();
            foreach (var w in comp.Warehouses)
            {
                WarehouseBox.Items.Add(w.Id);
                itmStoringPeriod_WarehouseBox.Items.Add(w.Id);
                itmsToExpire_WarehouseBox.Items.Add(w.Id);
            }
        }
        private void load_items()
        {
            ItemBox.Items.Clear();
            foreach (var i in comp.Items)
            {
                ItemBox.Items.Add(i.ID);
            }
        }
        private void Reports_Load(object sender, EventArgs e)
        {
            load_SupplyVouchers();
            load_StockReleaseVouchers();
            load_Warehouses();
            load_items();
        }

        private void SupplyVocherBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SuppVoucherID = int.Parse(SupplyVocherBox.SelectedItem.ToString());

            SupplyVoucher SV = comp.SupplyVouchers.Find(SuppVoucherID);
            if (SV != null)
            {
                var VoucherDetails = comp.SupplyVoucherItemWarehouses
                                    .Where(soiw => soiw.SupplyVoucherItem.SupplyVoucherId == SuppVoucherID)
                                    .Select(soiw => new
                                    {
                                        soiw.SupplyVoucherItem.ItemId,
                                        soiw.SupplyVoucherItem.Item.Name,
                                        soiw.WarehouseId,
                                        WarehouseName = soiw.Warehouse.Name,
                                        soiw.Quantity,
                                        soiw.SupplyVoucherItem.SupplyVoucher.VoucherDate,
                                        soiw.SupplyVoucherItem.ProductionDate,
                                        soiw.SupplyVoucherItem.ExpiryDate,
                                        soiw.SupplyVoucherItem.SupplyVoucher.SupplierId,
                                        SupplierName = soiw.SupplyVoucherItem.SupplyVoucher.Supplier.Name
                                    })
                                    .ToList();

                dataGridView1.DataSource = VoucherDetails;
            }
        }
        private void StockReleaseVoucherBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SRVoucherID = int.Parse(StockReleaseVoucherBox.SelectedItem.ToString());

            StockReleaseVoucher SRV = comp.StockReleaseVouchers.Find(SRVoucherID);
            if (SRV != null)
            {
                var VoucherDetails = comp.StockReleaseVoucherItems
                                     .Where(doi => doi.StockReleaseVoucherId == SRVoucherID)
                                     .Select(doi => new
                                     {
                                         doi.ItemId,
                                         ItemName = doi.Item.Name,
                                         doi.Quantity,
                                         doi.StockReleaseVoucher.VoucherDate,

                                         // Retrieve warehouse details
                                         WarehouseId = comp.StockReleaseVoucherItemWarehouses
                                             .Where(srvw => srvw.StockReleaseVoucherItemId == doi.Id)
                                             .Select(srvw => srvw.WarehouseId)
                                             .FirstOrDefault(),

                                         WarehouseName = comp.StockReleaseVoucherItemWarehouses
                                             .Where(srvw => srvw.StockReleaseVoucherItemId == doi.Id)
                                             .Select(srvw => srvw.Warehouse.Name)
                                             .FirstOrDefault()
                                     })
                                     .ToList();
                dataGridView2.DataSource = VoucherDetails;
            }
        }

        private void WarehouseBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int warehouseId = int.Parse(WarehouseBox.SelectedItem.ToString());

            WareHouse wh = comp.Warehouses.Find(warehouseId);
            if (wh != null)
            {
                WarehouseNameLabel.Text = wh.Name;
                WarehouseAddressLabel.Text = wh.Address;
                SecNameLabel.Text = wh.Secretary.Name;
                SecAddressLabel.Text = wh.Secretary.Address;

                var warehouseItems = comp.WarehouseItems
                                    .Where(wi => wi.WarehouseId == warehouseId)
                                    .Select(wi => new
                                    {
                                        wi.ItemId,
                                        ItemName = wi.Item.Name,
                                        wi.Quantity,

                                        ProductionDate = comp.SupplyVoucherItems
                                                        .Where(soi => soi.ItemId == wi.ItemId)
                                                        .OrderByDescending(soi => soi.ProductionDate)
                                                        .Select(soi => soi.ProductionDate)
                                                        .FirstOrDefault(),

                                        ExpiryDate = comp.SupplyVoucherItems
                                                        .Where(soi => soi.ItemId == wi.ItemId)
                                                        .OrderByDescending(soi => soi.ExpiryDate)
                                                        .Select(soi => soi.ExpiryDate)
                                                        .FirstOrDefault(),

                                        SupplierId = comp.SupplyVoucherItems
                                                        .Where(soi => soi.ItemId == wi.ItemId)
                                                        .Select(soi => soi.SupplyVoucher.SupplierId)
                                                        .FirstOrDefault(),

                                        SupplierName = comp.SupplyVoucherItems
                                                        .Where(soi => soi.ItemId == wi.ItemId)
                                                        .Select(soi => soi.SupplyVoucher.Supplier.Name)
                                                        .FirstOrDefault()
                                    })
                                    .ToList();

                dataGridView3.DataSource = warehouseItems;
            }
        }

        private void ItemBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int itemId = int.Parse(ItemBox.SelectedItem.ToString());

            Item itm = comp.Items.Find(itemId);
            if (itm != null)
            {
                var itemDetails = comp.WarehouseItems
                                .Where(wi => wi.ItemId == itemId)
                                .Select(wi => new
                                {
                                    ItemName = wi.Item.Name,
                                    WarehouseId = wi.Warehouse.Id,
                                    WarehouseName = wi.Warehouse.Name,
                                    wi.Quantity,

                                    ProductionDate = comp.SupplyVoucherItems
                                                    .Where(soi => soi.ItemId == itemId)
                                                    .OrderByDescending(soi => soi.ProductionDate)
                                                    .Select(soi => soi.ProductionDate)
                                                    .FirstOrDefault(),

                                    ExpiryDate = comp.SupplyVoucherItems
                                                    .Where(soi => soi.ItemId == itemId)
                                                    .OrderByDescending(soi => soi.ExpiryDate)
                                                    .Select(soi => soi.ExpiryDate)
                                                    .FirstOrDefault(),

                                    SupplierId = comp.SupplyVoucherItems
                                                    .Where(soi => soi.ItemId == itemId)
                                                    .Select(soi => soi.SupplyVoucher.SupplierId)
                                                    .FirstOrDefault(),

                                    SupplierName = comp.SupplyVoucherItems
                                                    .Where(soi => soi.ItemId == itemId)
                                                    .Select(soi => soi.SupplyVoucher.Supplier.Name)
                                                    .FirstOrDefault()
                                })
                                .ToList();

                dataGridView4.DataSource = itemDetails;
            }
        }

        private void TransferHistory_Btn_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePicker1.Value.Date; // Get start date
            DateTime endDate = dateTimePicker2.Value.Date;   // Get end date

            if (startDate >= endDate)
            {
                MessageBox.Show("Invalid Date Input.\nStart Date should be before End Date");
            }
            else
            {
                var transferOrders = comp.TransferVouchers
                                    .Where(to => to.VoucherDate >= startDate && to.VoucherDate <= endDate)
                                    .SelectMany(to => to.TransferVoucherItems.Select(toi => new
                                    {
                                        TransferOrderId = to.Id,
                                        to.VoucherDate,
                                        SourceWarehouse = to.SourceWarehouse.Name,
                                        TargetWarehouse = to.TargetWarehouse.Name,

                                        toi.ItemId,
                                        ItemName = toi.Item.Name,
                                        TransferredQuantity = toi.Quantity,
                                    }))
                                    .ToList();

                dataGridView5.DataSource = transferOrders;
            }
        }

        private void ShowItemsBtn_Click(object sender, EventArgs e)
        {
            if (itmStoringPeriod_WarehouseBox.SelectedItem == null)
            {
                MessageBox.Show("Please Select a Warehouse.", "Error");
            }
            else
            {
                int warehouseId = int.Parse(itmStoringPeriod_WarehouseBox.SelectedItem.ToString());
                int days = Convert.ToInt32(NumofDays.Value);

                DateTime thresholdDate = DateTime.Now.AddDays(-days);

                var oldItems = comp.WarehouseItems
                    .Where(wi => wi.WarehouseId == warehouseId)
                    .Where(wi => comp.SupplyVoucherItems
                        .Where(soi => soi.ItemId == wi.ItemId)
                        .All(soi => soi.SupplyVoucher.VoucherDate <= thresholdDate))
                    .Select(wi => new
                    {
                        wi.ItemId,
                        ItemName = wi.Item.Name,
                        AvailableQuantity = wi.Quantity,

                        SuppliedDate = comp.SupplyVoucherItems
                            .Where(soi => soi.ItemId == wi.ItemId)
                            .OrderBy(soi => soi.SupplyVoucher.VoucherDate)
                            .Select(soi => soi.SupplyVoucher.VoucherDate)
                            .FirstOrDefault()
                    })
                    .ToList();

                ItmsStatus.Text = $"Items That Have been in the Warehouse for {days} days or more:";
                dataGridView6.DataSource = oldItems;
            }
        }

        private void itmsToExpire_ShowBtn_Click(object sender, EventArgs e)
        {
            if(itmsToExpire_WarehouseBox.SelectedItem==null)
            {
                MessageBox.Show("Please Select a Warehouse", "ERROR");
            }
            else
            {
                int warehouseId = int.Parse(itmsToExpire_WarehouseBox.SelectedItem.ToString());

                var itemsOrderedByExpiry = comp.WarehouseItems
                    .Where(wi => wi.WarehouseId == warehouseId) 
                    .Select(wi => new
                    {
                        wi.ItemId,
                        ItemName = wi.Item.Name,
                        WarehouseName = wi.Warehouse.Name,
                        wi.Quantity, 

                        NearestExpiryDate = comp.SupplyVoucherItems
                            .Where(soi => soi.ItemId == wi.ItemId)
                            .OrderBy(soi => soi.ExpiryDate)
                            .Select(soi => soi.ExpiryDate)
                            .FirstOrDefault()
                    })
                    .OrderBy(i => i.NearestExpiryDate)
                    .ToList();

                dataGridView7.DataSource = itemsOrderedByExpiry;

            }
        }
    }
}

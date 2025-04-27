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
    public partial class TransferVoucher_Form : Form
    {
        private CompanyContext Comp;
        private TransferVoucher TrVoucher;
        public TransferVoucher_Form(CompanyContext c, TransferVoucher TRV)
        {
            InitializeComponent();
            Comp = c;
            TrVoucher = TRV;

        }
        private void Load_Items()
        {
            sourceWarehouse_Items_ListBox.Items.Clear();
            var SourceWarehouseItems = Comp.WarehouseItems.Where(wi => wi.Warehouse == TrVoucher.SourceWarehouse).Select(i => i.Item).ToList();
            foreach (var i in SourceWarehouseItems)
            {
                sourceWarehouse_Items_ListBox.Items.Add($"- Id: {i.ID} | Code: {i.Code} | Name: {i.Name} | Measurment_Unit: {i.MeasurementUnit}");
            }
        }

        private void TransferVoucher_Form_Load(object sender, EventArgs e)
        {
            sourceWarehouseId.Text = TrVoucher.SourceWarehouse.Id.ToString();
            SourceWarehouseName.Text = TrVoucher.SourceWarehouse.Name;
            sourceWarehouseAddress.Text = TrVoucher.SourceWarehouse.Address;
            destWarehouseId.Text = TrVoucher.TargetWarehouse.Id.ToString();
            destWarehouseName.Text = TrVoucher.TargetWarehouse.Name;
            destWarehouseAddress.Text = TrVoucher.TargetWarehouse.Address;
            Load_Items();
        }

        private void Update_Quantity(Item itm)
        {               
            int AvailableQuantity = Comp.WarehouseItems
                                    .Where(wi => wi.ItemId == itm.ID && wi.WarehouseId == TrVoucher.SourceWarehouse.Id)
                                    .Select(wi => wi.Quantity).FirstOrDefault();

            itemAvailableQuantity.Text = AvailableQuantity.ToString();
        }

        private void sourceWarehouse_Items_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int itemId = int.Parse(sourceWarehouse_Items_ListBox.SelectedItem.ToString()[6].ToString());
            Item itm = Comp.Items.Find(itemId);
            if (itm != null)
            {
                Update_Quantity(itm);
                
                ItemProdDate.Text = Comp.SupplyVoucherItems
                                    .Where(soi => soi.ItemId == itemId)
                                    .OrderByDescending(soi => soi.ProductionDate)
                                    .Select(soi => soi.ProductionDate)
                                    .FirstOrDefault().ToString();
                itemExpiryDate.Text = Comp.SupplyVoucherItems
                                   .Where(soi => soi.ItemId == itemId)
                                   .OrderByDescending(soi => soi.ExpiryDate)
                                   .Select(soi => soi.ExpiryDate)
                                   .FirstOrDefault().ToString();
                var supp = Comp.SupplyVoucherItems
                                    .Where(soi => soi.ItemId == itemId)
                                    .Select(soi => soi.SupplyVoucher.Supplier)
                                    .FirstOrDefault();
                ItemSupplierId.Text = supp.Id.ToString();
                itemSuppName.Text = supp.Name;

            }

        }

        public void ProcessTransferVoucherItem(TransferVoucherItem transferVoucherItem)
        {

            if (transferVoucherItem == null)
                throw new Exception("Transfer Order not found!");
       
            // Reduce stock in source warehouse
            var sourceStock = Comp.WarehouseItems
                .FirstOrDefault(wi => wi.WarehouseId == this.TrVoucher.SourceWarehouseId && wi.ItemId == transferVoucherItem.ItemId);

            sourceStock.Quantity -= transferVoucherItem.Quantity;

            // Increase stock in destination warehouse
            var destinationStock = Comp.WarehouseItems
                .FirstOrDefault(wi => wi.WarehouseId == this.TrVoucher.TargetWarehouseId && wi.ItemId == transferVoucherItem.ItemId);

            if (destinationStock == null)
            {
                destinationStock = new WarehouseItem
                {
                    WarehouseId = (int)this.TrVoucher.TargetWarehouseId,
                    ItemId = transferVoucherItem.ItemId,
                    Quantity = 0
                };
            Comp.WarehouseItems.Add(destinationStock);
            }

            destinationStock.Quantity += transferVoucherItem.Quantity; 

            Comp.SaveChanges();
        }


        private void TransferItems_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(quantityToTransfer.Text) && sourceWarehouse_Items_ListBox.SelectedItem == null)
                MessageBox.Show("Please Fill the messing data", "ERROR");
            else if (sourceWarehouse_Items_ListBox.SelectedItem == null)
                MessageBox.Show("Please select an Item to transfer", "ERROR");
            else if (string.IsNullOrEmpty(quantityToTransfer.Text))
                MessageBox.Show("Please enter Quantity of the item", "ERROR");
            else
            {
                if (int.Parse(quantityToTransfer.Text) > int.Parse(itemAvailableQuantity.Text))
                    MessageBox.Show("No Enough Stock", "ERROR");
                else
                {
                    int Item_Id = int.Parse(sourceWarehouse_Items_ListBox.SelectedItem.ToString()[6].ToString());
                    Item itm = Comp.Items.Find(Item_Id);
                    if (itm != null)
                    {
                        int Item_TransQuantity = int.Parse(quantityToTransfer.Text);
                        TransferVoucherItem transferVoucherItem = new TransferVoucherItem();
                        transferVoucherItem.Item = itm;
                        transferVoucherItem.TransferVoucher = this.TrVoucher;
                        transferVoucherItem.Quantity = Item_TransQuantity;
                        Comp.TransferVoucherItems.Add(transferVoucherItem);
                        ProcessTransferVoucherItem(transferVoucherItem);

                        Comp.SaveChanges();

                        MessageBox.Show($"{transferVoucherItem.Quantity} of  Item {transferVoucherItem.ItemId} Has been Transfered from Warehouse {TrVoucher.SourceWarehouseId} To Warehouse {TrVoucher.TargetWarehouseId}", "CONFIRM");
                        quantityToTransfer.Text = "";
                        Update_Quantity(itm);
                        
                    }  

                }
            }

        }
    }
}

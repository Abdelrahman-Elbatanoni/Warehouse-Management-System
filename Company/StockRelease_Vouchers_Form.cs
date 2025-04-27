using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Company
{
    public partial class StockRelease_Vouchers_Form : Form
    {
        private CompanyContext compContext;
        private StockReleaseVoucher StockReleaseVoucher;

        public StockRelease_Vouchers_Form(CompanyContext C, StockReleaseVoucher SRV)
        {
            InitializeComponent();
            compContext = C;
            StockReleaseVoucher = SRV;
        }

        private void Load_SRV_Info()
        {
            customerName.Text = StockReleaseVoucher.Customer.Name;
            customerMobile.Text = StockReleaseVoucher.Customer.Mobile;
            StockRelease_Voucher_ID.Text = StockReleaseVoucher.Id.ToString();
            Voucher_Date.Text = StockReleaseVoucher.VoucherDate.ToString();
        }
        private void Load_Items()
        {
            foreach (var i in compContext.Items)
            {
                CompanyItemsListBox.Items.Add($"- Id: {i.ID} | Code: {i.Code} | Name: {i.Name} | Measurment_Unit: {i.MeasurementUnit}");
            }
        }

        private void StockRelease_Vouchers_Form_Load(object sender, EventArgs e)
        {
            Load_SRV_Info();
            Load_Items();
        }

        public List<StockReleaseVoucherItem> AllocateStock(int itemId, int requestedQuantity)
        { 
            var warehouseStock = compContext.WarehouseItems
                .Where(wi => wi.ItemId == itemId && wi.Quantity > 0)
                .OrderByDescending(wi => wi.Quantity) // Prioritize warehouses with more stock
                .ToList();

            List<StockReleaseVoucherItem> releasedItems = new List<StockReleaseVoucherItem>();
            int remainingQuantity = requestedQuantity;

            foreach (var stock in warehouseStock)
            {
                if (remainingQuantity <= 0)
                    break;

                int quantityToRelease = Math.Min(stock.Quantity, remainingQuantity);
                StockReleaseVoucherItem SRV_Item = new StockReleaseVoucherItem
                {
                    ItemId = itemId,
                    Quantity = quantityToRelease,
                    StockReleaseVoucher = this.StockReleaseVoucher
                };

                releasedItems.Add(SRV_Item);

                // Reduce stock in the database
                stock.Quantity -= quantityToRelease;
                remainingQuantity -= quantityToRelease;
                StockReleaseVoucherItemWarehouse SRV_Warehouse=new StockReleaseVoucherItemWarehouse();
                SRV_Warehouse.Quantity=quantityToRelease;
                SRV_Warehouse.Warehouse = stock.Warehouse;
                SRV_Warehouse.StockReleaseVoucherItem = SRV_Item;
                compContext.StockReleaseVoucherItemWarehouses.Add(SRV_Warehouse);
            }

            return releasedItems;
            
        }

        private void AddItem_Click(object sender, EventArgs e)
        {
            if (CompanyItemsListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select an Item to Add to the Stock Release Voucher.", "ERROR");
            }
            else
            {
                if (string.IsNullOrEmpty(itemQuantity.Text))
                {
                    MessageBox.Show("Please Enter Item Quantity.", "ERROR");
                }

                else
                {
                    int Item_Id = int.Parse(CompanyItemsListBox.SelectedItem.ToString()[6].ToString());
                    Item itm = compContext.Items.Find(Item_Id);
                    if (itm != null)
                    {
                        if(int.Parse(itemQuantity.Text) >  int.Parse(ItemAvailableQuantity.Text) )
                        {
                            MessageBox.Show("No Enough Stock","ERROR");
                        }
                        else
                        {
                            var releasedItems = AllocateStock(Item_Id, int.Parse(itemQuantity.Text));

                            foreach (var i in releasedItems)
                            {
                                compContext.StockReleaseVoucherItems.Add(i);
                            }
                            compContext.SaveChanges();
                            itemQuantity.Text = "";
                            MessageBox.Show("Item has been added to the Voucher Successfully");
                            Update_Available_Quantity();
                        }

                    }
                }
            }
        }

        private void Update_Available_Quantity()
        {
            int Item_Id = int.Parse(CompanyItemsListBox.SelectedItem.ToString()[6].ToString());
            Item itm = compContext.Items.Find(Item_Id);
            if (itm != null)
            {
                int AvailableQuantity = compContext.WarehouseItems
                                       .Where(wi => wi.ItemId == Item_Id)
                                       .Sum(wi => wi.Quantity);
                ItemAvailableQuantity.Text = AvailableQuantity.ToString();
            }
        }
        private void CompanyItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Update_Available_Quantity();
        }
    }
}

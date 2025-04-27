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
    public partial class SuppVoucherItemsForm : Form
    {
        private SupplyVoucher sVoucher;
        private CompanyContext compContext;
        public SuppVoucherItemsForm(CompanyContext cc, SupplyVoucher sv)
        {
            InitializeComponent();
            sVoucher = sv;
            compContext = cc;
        }
        

        private void Load_SV_Info()
        {
            Supplier_Name.Text = sVoucher.Supplier.Name;
            Supplier_Mobile.Text = sVoucher.Supplier.Mobile;
            Sup_Voucher_ID.Text = sVoucher.Id.ToString();
            Voucher_Date.Text = sVoucher.VoucherDate.ToString();
        }
        private void Load_Items()
        {
            foreach (var i in compContext.Items)
            {
                CompanyItemsListBox.Items.Add($"- Id: {i.ID} | Code: {i.Code} | Name: {i.Name} | Measurment_Unit: {i.MeasurementUnit}");
            }
        }
        private void Load_Warehouses()
        {
            foreach (var w in compContext.Warehouses)
            {
                warehouseBox.Items.Add(w.Id);
            }
        }

        private void SuppVoucherItemsForm_Load(object sender, EventArgs e)
        {
            Load_SV_Info();
            Load_Items();
            Load_Warehouses();
        }

        private void warehouseBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int W_Id = int.Parse(warehouseBox.SelectedItem.ToString());
            var W = compContext.Warehouses.Find(W_Id);
            if (W != null)
            {
                warehouseNameLabel.Text = W.Name;
                warehouseAddressLabel.Text = W.Address;
            }
        }

        private void AddItem_Click(object sender, EventArgs e)
        {
            if (CompanyItemsListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select an Item to Add to the Supply Voucher.", "ERROR");
            }
            else
            {
                if (string.IsNullOrEmpty(itemQuantity.Text)  && warehouseBox.SelectedItem == null)
                {
                    MessageBox.Show("Please Fill the Missing Data", "ERROR");
                }
                else if (string.IsNullOrEmpty(itemQuantity.Text))
                {
                    MessageBox.Show("Please Enter Item Quantity.", "ERROR");
                }
                else if (warehouseBox.SelectedItem == null)
                {
                    MessageBox.Show("Please Select a Warehouse to store the item in.", "ERROR");
                }

                else
                {
                    int Item_Id = int.Parse(CompanyItemsListBox.SelectedItem.ToString()[6].ToString());
                    Item itm = compContext.Items.Find(Item_Id);
                    if (itm != null)
                    {
                        int W_Id = int.Parse(warehouseBox.SelectedItem.ToString());
                        WareHouse W = compContext.Warehouses.Find(W_Id);

                        if (W != null)
                        { 
                            SupplyVoucherItem supplyVoucherItem = new SupplyVoucherItem();
                            supplyVoucherItem.Item = itm;
                            supplyVoucherItem.Quantity = int.Parse(itemQuantity.Text);
                            supplyVoucherItem.ProductionDate = productionDate.Value;
                            supplyVoucherItem.ExpiryDate=expiryDate.Value;
                            supplyVoucherItem.SupplyVoucher = sVoucher;

                            compContext.SupplyVoucherItems.Add(supplyVoucherItem);

                            SupplyVoucherItemWarehouse supplyVoucherItemWarehouse = new SupplyVoucherItemWarehouse();
                            supplyVoucherItemWarehouse.Quantity = int.Parse(itemQuantity.Text);
                            supplyVoucherItemWarehouse.SupplyVoucherItem = supplyVoucherItem;
                            supplyVoucherItemWarehouse.Warehouse = W;

                            compContext.SupplyVoucherItemWarehouses.Add(supplyVoucherItemWarehouse);

                            WarehouseItem warehouseItem = new WarehouseItem();
                            warehouseItem.Item = itm;
                            warehouseItem.Warehouse = W;
                            warehouseItem.Quantity=int.Parse(itemQuantity.Text);
                            warehouseItem.SupplyVoucher= sVoucher;

                            compContext.WarehouseItems.Add(warehouseItem);

                            compContext.SaveChanges();

                            MessageBox.Show("Item Has been added successfully", "CONFIRM");

                            itemQuantity.Text = warehouseBox.Text= "";
                        }

                    }
                }
            }
        }

        
    }
}

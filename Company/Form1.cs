
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Company
{
    public partial class Form1 : Form
    {
        CompanyContext Comp;
        public Form1()
        {
            InitializeComponent();
            Comp = new CompanyContext();
            Comp.Database.EnsureCreated();
        }

        private void Add_Data_Click(object sender, EventArgs e)
        { 
            panel6.Hide();
            Back.Enabled = true;             
        }

        private void Show_Reports_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports(Comp);
            reports.Show();          
        }

        private void Back_Click(object sender, EventArgs e)
        {
            panel6.Show();
            Back.Enabled = false;
        }

        private void Load_Secretaries()
        {
            Ware_Secr_Box.Items.Clear();
            Secrs_ListBox.Items.Clear();
            var Secretaries = Comp.Secretaries;
            var Warehouses = Comp.Warehouses;
            foreach (var s in Secretaries)
            {
                Ware_Secr_Box.Items.Add(s.Secretary_Id);
                Secrs_ListBox.Items.Add($"- Id: {s.Secretary_Id} | Name: {s.Name} | Address: {s.Address}");
            }
        }
        private void Load_Warehouses()
        {
            Warehouses_ListBox.Items.Clear();
            SourceWarehouseBox.Items.Clear();
            var Warehouses = Comp.Warehouses;

            foreach (var w in Warehouses)
            {
                Warehouses_ListBox.Items.Add($"- Id: {w.Id} | Name: {w.Name} | Address: {w.Address} | Secretary_Id: {w.SecretaryId}");
                SourceWarehouseBox.Items.Add(w.Id);
            }
        }
        private void Load_Items()
        {
            ItemsListBox.Items.Clear();
            foreach (var i in Comp.Items)
            {
                ItemsListBox.Items.Add($"- Id: {i.ID} | Code: {i.Code} | Name: {i.Name} | Measurment_Unit: {i.MeasurementUnit}");
            }

            ItemCode.Items.Clear();
            var codes = Comp.Items.Select(item => item.Code)
                                  .Distinct()
                                  .ToList();
            foreach (var i in codes)
            {
                ItemCode.Items.Add(i);
            }
        }
        private void Load_Suppliers()
        {
            suppliersListBox.Items.Clear();
            SuppVoucher_SupplierBox.Items.Clear();

            foreach (var s in Comp.Suppliers)
            {
                suppliersListBox.Items.Add($"- Id: {s.Id} | Name: {s.Name} | Phone: {s.Phone} | Mobile: {s.Mobile} | Fax: {s.Fax} | Email: {s.Email} | Website: {s.Website}");
                SuppVoucher_SupplierBox.Items.Add(s.Id);
            }
        }
        private void Load_Customers()
        {
            CustomerListBox.Items.Clear();
            releaseVoucher_customerBox.Items.Clear();

            foreach (var c in Comp.Customers)
            {
                CustomerListBox.Items.Add($"- Id: {c.Id} | Name: {c.Name} | Phone: {c.Phone} | Mobile: {c.Mobile} | Fax: {c.Fax} | Email: {c.Email} | Website: {c.Website}");
                releaseVoucher_customerBox.Items.Add(c.Id);
            }
        }
        private void Load_SupplyVouchers()
        {
            SuppVouchers_ListBox.Items.Clear();

            foreach (var SV in Comp.SupplyVouchers)
            {
                SuppVouchers_ListBox.Items.Add($"- Id: {SV.Id} | Supplier_Id: {SV.SupplierId} | Date: {SV.VoucherDate}");
            }
        }
        private void Load_StockReleaseVouchers()
        {
            stockReleaseVouchers_ListBox.Items.Clear();

            foreach (var SRV in Comp.StockReleaseVouchers)
            {
                stockReleaseVouchers_ListBox.Items.Add($"- Id: {SRV.Id} | Customer_Id: {SRV.CustomerId} | Date: {SRV.VoucherDate}");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Back.Enabled = false;
            Load_Items();
            Load_Secretaries();
            Load_Warehouses();
            Load_Suppliers();
            Load_Customers();
            Load_SupplyVouchers();
            Load_StockReleaseVouchers();
        }

        private void Add_Sec_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Sec_Name.Text) && string.IsNullOrEmpty(Sec_Address.Text))
            {
                MessageBox.Show("Please Fill the Missing Data", "ERROR");
            }
            else if (string.IsNullOrEmpty(Sec_Name.Text))
            {
                MessageBox.Show("Please Enter Secretary Name", "ERROR");
            }
            else if (string.IsNullOrEmpty(Sec_Address.Text))
            {
                MessageBox.Show("Please Enter Secretary Address", "ERROR");
            }
            else
            {
                Secretary s = new Secretary();
                s.Name = Sec_Name.Text;
                s.Address = Sec_Address.Text;
                Comp.Secretaries.Add(s);
                Comp.SaveChanges();
                Sec_Address.Text = Sec_Name.Text = "";
                MessageBox.Show("The Secretary has been added successfully", "Confirm");
                Load_Secretaries();
            }
        }

        private void Add_Warehouse_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Ware_Name.Text) && string.IsNullOrEmpty(Ware_Address.Text) && Ware_Secr_Box.SelectedItem == null)
            {
                MessageBox.Show("Please Fill the Missing Data", "ERROR");
            }
            else if (string.IsNullOrEmpty(Ware_Name.Text))
            {
                MessageBox.Show("Please Enter Warehouse Name", "ERROR");
            }
            else if (string.IsNullOrEmpty(Ware_Address.Text))
            {
                MessageBox.Show("Please Enter Warehouse Address", "ERROR");
            }
            else if (Ware_Secr_Box.SelectedItem == null)
            {
                MessageBox.Show("Please Choose A secretary for the Warehouse", "ERROR");
            }
            else
            {
                try
                {
                    WareHouse house = new WareHouse();
                    house.Name = Ware_Name.Text;
                    house.Address = Ware_Address.Text;
                    int Sec_Id = int.Parse(Ware_Secr_Box.SelectedItem.ToString());
                    Secretary s = Comp.Secretaries.Find(Sec_Id);
                    house.Secretary = s;
                    Comp.Warehouses.Add(house);
                    Comp.SaveChanges();
                    Ware_Address.Text = Ware_Name.Text = Sec_Add_Label.Text = Sec_Name_Label.Text = "";
                    Ware_Secr_Box.SelectedItem = null;
                    MessageBox.Show("The Warehouse has been added successfully", "Confirm");
                    Load_Warehouses();
                }

                catch (Exception ex)
                {

                    MessageBox.Show("The Secretary is already Assigned to Another Warehouse.\nPlease Try Again.", "Error");
                }
            }
        }

        private void Ware_Secr_Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Ware_Secr_Box.SelectedItem != null)
            {
                int Sec_Id = int.Parse(Ware_Secr_Box.SelectedItem.ToString());
                Secretary s = Comp.Secretaries.Find(Sec_Id);
                if (s != null)
                {
                    Sec_Name_Label.Text = s.Name;
                    Sec_Add_Label.Text = s.Address;
                }
            }
        }

        private void Update_Sec_Click(object sender, EventArgs e)
        {
            if (Secrs_ListBox.SelectedItem == null)
            {
                MessageBox.Show("Please Select a secretary to update.", "ERROR");
            }
            else
            {
                if (!string.IsNullOrEmpty(Sec_Name.Text) || !string.IsNullOrEmpty(Sec_Address.Text))
                {
                    string id = Secrs_ListBox.SelectedItem.ToString()[6].ToString();

                    int Sec_Id = int.Parse(id);

                    Secretary To_Update_S = Comp.Secretaries.Find(Sec_Id);

                    if (To_Update_S != null)
                    {
                        if (!string.IsNullOrEmpty(Sec_Name.Text))
                            To_Update_S.Name = Sec_Name.Text;

                        if (!string.IsNullOrEmpty(Sec_Address.Text))
                            To_Update_S.Address = Sec_Address.Text;

                        MessageBox.Show("Secretary has been Updated Successfully.", "Confirm");
                        Sec_Address.Text = Sec_Name.Text = "";
                        Comp.SaveChanges();
                        Load_Secretaries();
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter the field you want to update", "ERROR");
                }

            }
        }

        private void Update_Warehous_Click(object sender, EventArgs e)
        {
            if (Warehouses_ListBox.SelectedItem == null)
            {
                MessageBox.Show("Please Select a Warehouse to update.", "ERROR");
            }
            else
            {
                if (!string.IsNullOrEmpty(Ware_Name.Text) || !string.IsNullOrEmpty(Ware_Address.Text) || Ware_Secr_Box.SelectedItem !=null)
                {
                    string id = Warehouses_ListBox.SelectedItem.ToString()[6].ToString();

                    int W_Id = int.Parse(id);

                    WareHouse To_Update_W = Comp.Warehouses.Find(W_Id);

                    if (To_Update_W != null)
                    {
                        if (!string.IsNullOrEmpty(Ware_Name.Text))
                            To_Update_W.Name = Ware_Name.Text;

                        if (!string.IsNullOrEmpty(Ware_Address.Text))
                            To_Update_W.Address = Ware_Address.Text;

                        if (Ware_Secr_Box.SelectedItem != null)
                        {
                            try
                            {
                                int Sec_Id = int.Parse(Ware_Secr_Box.SelectedItem.ToString());
                                Secretary s = Comp.Secretaries.Find(Sec_Id);
                                To_Update_W.Secretary = s;
                            }

                            catch (Exception ex)
                            {

                                MessageBox.Show("The Secretary is already Assigned to Another Warehouse.\nPlease Try Again.", "Error");
                            }

                        }

                        try
                        {
                            Ware_Address.Text = Ware_Name.Text = Sec_Add_Label.Text = Sec_Name_Label.Text = "";
                            Ware_Secr_Box.SelectedItem = null;
                            Comp.SaveChanges();
                            Load_Warehouses();
                            MessageBox.Show("Warehouse has been Updated Successfully.", "Confirm");
                        }
                        catch (Exception ec)
                        {
                            MessageBox.Show("The Secretary is already Assigned to Another Warehouse.\nPlease Try Again.", "Error");

                        }

                    }
                }
                else
                {
                    MessageBox.Show("Please Enter the field you want to update", "ERROR");
                }

            }

        }

        private void Add_Item_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ItemCode.Text) && string.IsNullOrEmpty(ItemName.Text) && string.IsNullOrEmpty(ItemMeasuringUnit.Text))
            {
                MessageBox.Show("Please Fill the Missing Data", "ERROR");
            }
            else if (string.IsNullOrEmpty(ItemCode.Text))
            {
                MessageBox.Show("Please Enter Item Code", "ERROR");
            }
            else if (string.IsNullOrEmpty(ItemName.Text))
            {
                MessageBox.Show("Please Enter Item Name", "ERROR");
            }
            else if (string.IsNullOrEmpty(ItemMeasuringUnit.Text))
            {
                MessageBox.Show("Please Enter Item Measurement unit", "ERROR");
            }

            else
            {
                bool flag = false;
                foreach (var i in Comp.Items)
                {
                    if ((ItemCode.Text == i.Code) && (ItemName.Text == i.Name) && (ItemMeasuringUnit.Text == i.MeasurementUnit))
                    {
                        MessageBox.Show("Item Already exists.", "ERROR");
                        flag = true;
                    }
                }

                if (!flag)
                {
                    Item itm = new Item();
                    itm.Code = ItemCode.Text;
                    itm.Name = ItemName.Text;
                    itm.MeasurementUnit = ItemMeasuringUnit.Text;

                    Comp.Items.Add(itm);
                    Comp.SaveChanges();

                    ItemCode.Text = ItemName.Text = ItemMeasuringUnit.Text = "";
                    ItemsListBox.Items.Clear();
                    MessageBox.Show("The Item has been added successfully", "Confirm");
                    Load_Items();
                }

            }
        }

        private void Update_Item_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem == null)
            {
                MessageBox.Show("Please Select an Item to update.", "ERROR");
            }
            else
            {
                if (ItemCode.SelectedItem != null || !string.IsNullOrEmpty(ItemMeasuringUnit.Text) || !string.IsNullOrEmpty(ItemName.Text) || !string.IsNullOrEmpty(ItemCode.Text))
                {
                    string id = ItemsListBox.SelectedItem.ToString()[6].ToString();

                    int itm_Id = int.Parse(id);

                    Item To_Update_I = Comp.Items.Find(itm_Id);

                    if (To_Update_I != null)
                    {
                        Item temp = new Item();
                        temp.Name = To_Update_I.Name;
                        temp.Code = To_Update_I.Code;
                        temp.MeasurementUnit = To_Update_I.MeasurementUnit;
                        if (!string.IsNullOrEmpty(ItemCode.Text))
                            temp.Code = ItemCode.Text;

                        if (!string.IsNullOrEmpty(ItemName.Text))
                            temp.Name = ItemName.Text;

                        if (!string.IsNullOrEmpty(ItemMeasuringUnit.Text))
                            temp.MeasurementUnit = ItemMeasuringUnit.Text;

                        bool flag = false;
                        foreach (var i in Comp.Items)
                        {
                            if ((temp.Code == i.Code) && (temp.Name == i.Name) && (temp.MeasurementUnit == i.MeasurementUnit))
                            {
                                MessageBox.Show("Item Already exists.", "ERROR");
                                flag = true;
                            }
                        }

                        try
                        {
                            if (!flag)
                            {
                                To_Update_I.Code = temp.Code;
                                To_Update_I.Name = temp.Name;
                                To_Update_I.MeasurementUnit = temp.MeasurementUnit;
                                ItemsListBox.Items.Clear();
                                ItemCode.Text = ItemName.Text = ItemMeasuringUnit.Text = "";
                                Comp.SaveChanges();
                                MessageBox.Show("Item has been Updated Successfully.", "Confirm");
                                Load_Items();
                            }

                        }
                        catch (Exception ec)
                        {
                            MessageBox.Show("Error while Updating item.", "Error");

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter the field you want to update", "ERROR");
                }
            }
        }

        private void Add_Supplier_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(supplierName.Text) && string.IsNullOrEmpty(supplierPhone.Text) && string.IsNullOrEmpty(supplierFax.Text) && string.IsNullOrEmpty(supplierMobile.Text) && string.IsNullOrEmpty(supplierEmail.Text) && string.IsNullOrEmpty(supplierWebsite.Text))
            {
                MessageBox.Show("Please Fill the Missing Data", "ERROR");
            }
            else if (string.IsNullOrEmpty(supplierName.Text))
            {
                MessageBox.Show("Please Enter Supplier Name.", "ERROR");
            }
            else if (string.IsNullOrEmpty(supplierPhone.Text))
            {
                MessageBox.Show("Please Enter Supplier Phone.", "ERROR");
            }
            else if (string.IsNullOrEmpty(supplierFax.Text))
            {
                MessageBox.Show("Please Enter Supplier Fax.", "ERROR");
            }
            else if (string.IsNullOrEmpty(supplierMobile.Text))
            {
                MessageBox.Show("Please Enter Supplier Mobile.", "ERROR");
            }
            else if (string.IsNullOrEmpty(supplierEmail.Text))
            {
                MessageBox.Show("Please Enter Supplier Email.", "ERROR");
            }
            else if (string.IsNullOrEmpty(supplierWebsite.Text))
            {
                MessageBox.Show("Please Enter Supplier Website.", "ERROR");
            }

            else
            {
                Supplier supp = new Supplier();
                supp.Name = supplierName.Text;
                supp.Phone = supplierPhone.Text;
                supp.Mobile = supplierMobile.Text;
                supp.Fax = supplierFax.Text;
                supp.Email = supplierEmail.Text;
                supp.Website = supplierWebsite.Text;

                Comp.Suppliers.Add(supp);
                Comp.SaveChanges();
                supplierName.Text = supplierPhone.Text = supplierMobile.Text = supplierFax.Text = supplierEmail.Text = supplierWebsite.Text = "";
                MessageBox.Show("The Supplier has been added successfully", "Confirm");
                Load_Suppliers();
            }
        }

        private void Update_Supplier_Click(object sender, EventArgs e)
        {
            if (suppliersListBox.SelectedItem == null)
            {
                MessageBox.Show("Please Select a Supplier to update.", "ERROR");
            }
            else
            {
                if(!string.IsNullOrEmpty(supplierName.Text) || !string.IsNullOrEmpty(supplierPhone.Text) || !string.IsNullOrEmpty(supplierMobile.Text) || !string.IsNullOrEmpty(supplierFax.Text) || !string.IsNullOrEmpty(supplierEmail.Text) || !string.IsNullOrEmpty(supplierWebsite.Text))
                {
                    string id = suppliersListBox.SelectedItem.ToString()[6].ToString();

                    int supp_Id = int.Parse(id);

                    Supplier To_Update_Sup = Comp.Suppliers.Find(supp_Id);

                    if (To_Update_Sup != null)
                    {
                        if (!string.IsNullOrEmpty(supplierName.Text))
                            To_Update_Sup.Name = supplierName.Text;

                        if (!string.IsNullOrEmpty(supplierPhone.Text))
                            To_Update_Sup.Phone = supplierPhone.Text;

                        if (!string.IsNullOrEmpty(supplierMobile.Text))
                            To_Update_Sup.Mobile = supplierMobile.Text;

                        if (!string.IsNullOrEmpty(supplierFax.Text))
                            To_Update_Sup.Fax = supplierFax.Text;

                        if (!string.IsNullOrEmpty(supplierEmail.Text))
                            To_Update_Sup.Email = supplierEmail.Text;

                        if (!string.IsNullOrEmpty(supplierWebsite.Text))
                            To_Update_Sup.Website = supplierWebsite.Text;

                        try
                        {
                            supplierName.Text = supplierPhone.Text = supplierMobile.Text = supplierFax.Text = supplierEmail.Text = supplierWebsite.Text = "";
                            Comp.SaveChanges();
                            MessageBox.Show("Supplier has been Updated Successfully.", "Confirm");
                            Load_Suppliers();
                        }
                        catch (Exception ec)
                        {
                            MessageBox.Show("Error while Updating Supplier.", "Error");
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Please Enter the field you want to update", "ERROR");
                }
            }
        }

        private void Add_Customer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(customerName.Text) && string.IsNullOrEmpty(customerPhone.Text) && string.IsNullOrEmpty(customerFax.Text) && string.IsNullOrEmpty(customerMobile.Text) && string.IsNullOrEmpty(customerEmail.Text) && string.IsNullOrEmpty(customerWebsite.Text))
            {
                MessageBox.Show("Please Fill the Missing Data", "ERROR");
            }
            else if (string.IsNullOrEmpty(customerName.Text))
            {
                MessageBox.Show("Please Enter Customer Name.", "ERROR");
            }
            else if (string.IsNullOrEmpty(customerPhone.Text))
            {
                MessageBox.Show("Please Enter Customer Phone.", "ERROR");
            }
            else if (string.IsNullOrEmpty(customerFax.Text))
            {
                MessageBox.Show("Please Enter Customer Fax.", "ERROR");
            }
            else if (string.IsNullOrEmpty(customerMobile.Text))
            {
                MessageBox.Show("Please Enter Customer Mobile.", "ERROR");
            }
            else if (string.IsNullOrEmpty(customerEmail.Text))
            {
                MessageBox.Show("Please Enter Customer Email.", "ERROR");
            }
            else if (string.IsNullOrEmpty(customerWebsite.Text))
            {
                MessageBox.Show("Please Enter Customer Website.", "ERROR");
            }

            else
            {
                Customer cust = new Customer();
                cust.Name = customerName.Text;
                cust.Phone = customerPhone.Text;
                cust.Mobile = customerMobile.Text;
                cust.Fax = customerFax.Text;
                cust.Email = customerEmail.Text;
                cust.Website = customerWebsite.Text;

                Comp.Customers.Add(cust);
                Comp.SaveChanges();
                customerName.Text = customerPhone.Text = customerMobile.Text = customerFax.Text = customerEmail.Text = customerWebsite.Text = "";
                MessageBox.Show("The Customer has been added successfully", "Confirm");
                Load_Customers();
            }
        }

        private void Update_Customer_Click(object sender, EventArgs e)
        {
            if (CustomerListBox.SelectedItem == null)
            {
                MessageBox.Show("Please Select a Customer to update.", "ERROR");
            }
            else
            {
                if (!string.IsNullOrEmpty(customerName.Text) || !string.IsNullOrEmpty(customerPhone.Text) || !string.IsNullOrEmpty(customerMobile.Text) || !string.IsNullOrEmpty(customerFax.Text) || !string.IsNullOrEmpty(customerEmail.Text) || !string.IsNullOrEmpty(customerWebsite.Text))
                {
                    string id = CustomerListBox.SelectedItem.ToString()[6].ToString();

                    int cust_Id = int.Parse(id);

                    Customer To_Update_Cust = Comp.Customers.Find(cust_Id);

                    if (To_Update_Cust != null)
                    {
                        if (!string.IsNullOrEmpty(customerName.Text))
                            To_Update_Cust.Name = customerName.Text;

                        if (!string.IsNullOrEmpty(customerPhone.Text))
                            To_Update_Cust.Phone = customerPhone.Text;

                        if (!string.IsNullOrEmpty(customerMobile.Text))
                            To_Update_Cust.Mobile = customerMobile.Text;

                        if (!string.IsNullOrEmpty(customerFax.Text))
                            To_Update_Cust.Fax = customerFax.Text;

                        if (!string.IsNullOrEmpty(customerEmail.Text))
                            To_Update_Cust.Email = customerEmail.Text;

                        if (!string.IsNullOrEmpty(customerWebsite.Text))
                            To_Update_Cust.Website = customerWebsite.Text;

                        try
                        {
                            customerName.Text = customerPhone.Text = customerMobile.Text = customerFax.Text = customerEmail.Text = customerWebsite.Text = "";
                            Comp.SaveChanges();
                            MessageBox.Show("Customer has been Updated Successfully.", "Confirm");
                            Load_Customers();
                        }
                        catch (Exception ec)
                        {
                            MessageBox.Show("Error while Updating Customer.", "Error");

                        }

                    }
                }
                else
                {
                    MessageBox.Show("Please Enter the field you want to update", "ERROR");
                }
            }
        }

        private void SuppVoucher_SupplierBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sup_Id = int.Parse(SuppVoucher_SupplierBox.SelectedItem.ToString());
            var s = Comp.Suppliers.Find(sup_Id);
            if (s != null)
            {
                Supplier_NameLabel.Text = s.Name;
                Supplier_MobileLabel.Text = s.Mobile;
            }
        }

        private void ADD_SupplyVoucher_Click(object sender, EventArgs e)
        {
            if (SuppVoucher_SupplierBox.SelectedItem == null)
            {
                MessageBox.Show("Please Select a Supplier.", "ERROR");
            }
            else
            {
                int supp_Id = int.Parse(SuppVoucher_SupplierBox.SelectedItem.ToString());

                Supplier suppVoucherSupplier = Comp.Suppliers.Find(supp_Id);


                if (suppVoucherSupplier != null)
                {
                    SupplyVoucher supVoucher = new SupplyVoucher();
                    supVoucher.Supplier = suppVoucherSupplier;
                    supVoucher.VoucherDate = DateTime.Now;
                    Comp.SupplyVouchers.Add(supVoucher);
                    Comp.SaveChanges();
                    MessageBox.Show("A Supply Voucher has been Added Successfully.", "Confirm");
                    SuppVoucher_SupplierBox.Text = "";
                    Load_SupplyVouchers();
                }
            }
        }

        private void AddItemsToSuppVoucher_Click(object sender, EventArgs e)
        {
            if (SuppVouchers_ListBox.SelectedItem == null)
            {
                MessageBox.Show("Please Select a Voucher.", "ERROR");
            }
            else
            {
                int suppVoucher_Id = int.Parse(SuppVouchers_ListBox.SelectedItem.ToString()[6].ToString());

                SupplyVoucher sV = Comp.SupplyVouchers.Find(suppVoucher_Id);


                if (sV != null)
                {
                    SuppVoucherItemsForm sItemsForm = new SuppVoucherItemsForm(Comp, sV);
                    sItemsForm.Show();
                }
            }
        }

        private void releaseVoucher_customerBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cust_Id = int.Parse(releaseVoucher_customerBox.SelectedItem.ToString());
            var c = Comp.Customers.Find(cust_Id);
            if (c != null)
            {
                customerNameLabel.Text = c.Name;
                customerMobileLabel.Text = c.Mobile;
            }

        }

        private void Add_StockRelease_Voucher_Click(object sender, EventArgs e)
        {
            if (releaseVoucher_customerBox.SelectedItem == null)
            {
                MessageBox.Show("Please Select a Customer.", "ERROR");
            }
            else
            {
                int Cust_Id = int.Parse(releaseVoucher_customerBox.SelectedItem.ToString());

                Customer releaseVoucherCust = Comp.Customers.Find(Cust_Id);


                if (releaseVoucherCust != null)
                {
                    StockReleaseVoucher STV = new StockReleaseVoucher();
                    STV.Customer = releaseVoucherCust;
                    STV.VoucherDate = DateTime.Now;
                    Comp.StockReleaseVouchers.Add(STV);
                    Comp.SaveChanges();
                    MessageBox.Show("A Stock Release Voucher has been Added Successfully.", "Confirm");
                    releaseVoucher_customerBox.Text = "";
                    Load_StockReleaseVouchers();
                }
            }
        }

        private void releaseVoucher_AddItems_Click(object sender, EventArgs e)
        {
            if (stockReleaseVouchers_ListBox.SelectedItem == null)
            {
                MessageBox.Show("Please Select a Voucher.", "ERROR");
            }
            else
            {
                int SRV_Id = int.Parse(stockReleaseVouchers_ListBox.SelectedItem.ToString()[6].ToString());

                StockReleaseVoucher SRV = Comp.StockReleaseVouchers.Find(SRV_Id);


                if (SRV != null)
                {
                    StockRelease_Vouchers_Form SRV_ItemsForm = new StockRelease_Vouchers_Form(Comp, SRV);
                    SRV_ItemsForm.Show();
                }
            }
        }

        private void SourceWarehouseBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int W_Id = int.Parse(SourceWarehouseBox.SelectedItem.ToString());
            var W = Comp.Warehouses.Find(W_Id);
            if (W != null)
            {
                SourceWarehouseName.Text = W.Name;
                sourceWarehouseAddress.Text = W.Address;
            }

            var warehouseItems = Comp.WarehouseItems
                .Where(wi => wi.WarehouseId == W_Id)
                .Select(wi => wi.Item)
                .ToList();


            destinationWarehouseBox.Items.Clear();
            foreach (var destware in Comp.Warehouses)
            {
                if (destware != W)
                {
                    destinationWarehouseBox.Items.Add(destware.Id);
                }
            }

            destWarehouseName.Text = destWarehouseAddress.Text = "";
        }

        private void destinationWarehouseBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int W_Id = int.Parse(destinationWarehouseBox.SelectedItem.ToString());
            var W = Comp.Warehouses.Find(W_Id);
            if (W != null)
            {
                destWarehouseName.Text = W.Name;
                destWarehouseAddress.Text = W.Address;
            }
        }

        private void AddItems_Click(object sender, EventArgs e)
        {
            if (SourceWarehouseBox.SelectedItem == null && destinationWarehouseBox.SelectedItem == null)
                MessageBox.Show("Please Fill the Missing Data", "ERROR");


            else if (SourceWarehouseBox.SelectedItem == null)
                MessageBox.Show("Please select a Source Warehouse.", "ERROR");

            else if (destinationWarehouseBox.SelectedItem == null)
                MessageBox.Show("Please select a destination Warehouse.", "ERROR");

            else
            {
                int Source_Ware_Id = int.Parse(SourceWarehouseBox.SelectedItem.ToString());
                int Dest_Ware_Id = int.Parse(destinationWarehouseBox.SelectedItem.ToString());

                var Source_Warehouse = Comp.Warehouses.Find(Source_Ware_Id);
                var Dest_Warehouse = Comp.Warehouses.Find(Dest_Ware_Id);

                if (Source_Warehouse != null && Dest_Warehouse != null)
                {
                    TransferVoucher TrVoucher = new TransferVoucher();
                    TrVoucher.SourceWarehouse = Source_Warehouse;
                    TrVoucher.TargetWarehouse = Dest_Warehouse;
                    TrVoucher.VoucherDate = DateTime.Now;
                    TransferVoucher_Form transferVoucher_Form = new TransferVoucher_Form(Comp, TrVoucher);
                    transferVoucher_Form.Show();

                }
            }
        }
       
    }
}

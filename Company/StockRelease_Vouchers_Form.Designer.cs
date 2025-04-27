namespace Company
{
    partial class StockRelease_Vouchers_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            itemQuantity = new TextBox();
            AddItem = new Button();
            label13 = new Label();
            label7 = new Label();
            CompanyItemsListBox = new ListBox();
            label1 = new Label();
            label5 = new Label();
            Voucher_Date = new Label();
            StockRelease_Voucher_ID = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            customerMobile = new Label();
            customerName = new Label();
            label6 = new Label();
            ItemAvailableQuantity = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // itemQuantity
            // 
            itemQuantity.Location = new Point(542, 414);
            itemQuantity.Name = "itemQuantity";
            itemQuantity.Size = new Size(250, 27);
            itemQuantity.TabIndex = 30;
            // 
            // AddItem
            // 
            AddItem.BackColor = SystemColors.MenuHighlight;
            AddItem.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddItem.Location = new Point(530, 584);
            AddItem.Name = "AddItem";
            AddItem.Size = new Size(175, 57);
            AddItem.TabIndex = 28;
            AddItem.Text = "ADD";
            AddItem.UseVisualStyleBackColor = false;
            AddItem.Click += AddItem_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(401, 415);
            label13.Name = "label13";
            label13.Size = new Size(85, 23);
            label13.TabIndex = 29;
            label13.Text = "Quantity:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(58, 27);
            label7.Name = "label7";
            label7.Size = new Size(112, 20);
            label7.TabIndex = 19;
            label7.Text = "Company Items";
            // 
            // CompanyItemsListBox
            // 
            CompanyItemsListBox.FormattingEnabled = true;
            CompanyItemsListBox.HorizontalScrollbar = true;
            CompanyItemsListBox.Location = new Point(62, 50);
            CompanyItemsListBox.Name = "CompanyItemsListBox";
            CompanyItemsListBox.Size = new Size(547, 184);
            CompanyItemsListBox.TabIndex = 18;
            CompanyItemsListBox.SelectedIndexChanged += CompanyItemsListBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(793, 14);
            label1.Name = "label1";
            label1.Size = new Size(207, 20);
            label1.TabIndex = 16;
            label1.Text = "Stock Release Voucher Details";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 110);
            label5.Name = "label5";
            label5.Size = new Size(126, 20);
            label5.TabIndex = 7;
            label5.Text = "Customer Mobile:";
            // 
            // Voucher_Date
            // 
            Voucher_Date.AutoSize = true;
            Voucher_Date.Location = new Point(122, 157);
            Voucher_Date.Name = "Voucher_Date";
            Voucher_Date.Size = new Size(0, 20);
            Voucher_Date.TabIndex = 6;
            // 
            // StockRelease_Voucher_ID
            // 
            StockRelease_Voucher_ID.AutoSize = true;
            StockRelease_Voucher_ID.Location = new Point(48, 13);
            StockRelease_Voucher_ID.Name = "StockRelease_Voucher_ID";
            StockRelease_Voucher_ID.Size = new Size(0, 20);
            StockRelease_Voucher_ID.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 13);
            label2.Name = "label2";
            label2.Size = new Size(27, 20);
            label2.TabIndex = 1;
            label2.Text = "ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 60);
            label3.Name = "label3";
            label3.Size = new Size(119, 20);
            label3.TabIndex = 2;
            label3.Text = "Customer Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 157);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 3;
            label4.Text = "Creation Date:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.Controls.Add(customerMobile);
            panel1.Controls.Add(customerName);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(Voucher_Date);
            panel1.Controls.Add(StockRelease_Voucher_ID);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(793, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(296, 196);
            panel1.TabIndex = 17;
            // 
            // customerMobile
            // 
            customerMobile.AutoSize = true;
            customerMobile.Location = new Point(141, 110);
            customerMobile.Name = "customerMobile";
            customerMobile.Size = new Size(0, 20);
            customerMobile.TabIndex = 34;
            // 
            // customerName
            // 
            customerName.AutoSize = true;
            customerName.Location = new Point(140, 60);
            customerName.Name = "customerName";
            customerName.Size = new Size(0, 20);
            customerName.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(399, 321);
            label6.Name = "label6";
            label6.Size = new Size(164, 23);
            label6.TabIndex = 31;
            label6.Text = "Available Quantity:";
            // 
            // ItemAvailableQuantity
            // 
            ItemAvailableQuantity.AutoSize = true;
            ItemAvailableQuantity.Location = new Point(569, 323);
            ItemAvailableQuantity.Name = "ItemAvailableQuantity";
            ItemAvailableQuantity.Size = new Size(0, 20);
            ItemAvailableQuantity.TabIndex = 32;
            // 
            // StockRelease_Vouchers_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1179, 690);
            Controls.Add(ItemAvailableQuantity);
            Controls.Add(label6);
            Controls.Add(itemQuantity);
            Controls.Add(AddItem);
            Controls.Add(label13);
            Controls.Add(label7);
            Controls.Add(CompanyItemsListBox);
            Controls.Add(label1);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "StockRelease_Vouchers_Form";
            Text = "StockRelease_Vouchers_Form";
            Load += StockRelease_Vouchers_Form_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox itemQuantity;
        private Button AddItem;
        private Label label13;
        private DateTimePicker expiryDate;
        private DateTimePicker productionDate;
        private Label label8;
        private Label label7;
        private ListBox CompanyItemsListBox;
        private Label label1;
        private Label Supplier_Phone;
        private Label label5;
        private Label Voucher_Date;
        private Label Supplier_Name;
        private Label StockRelease_Voucher_ID;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private Label label6;
        private Label ItemAvailableQuantity;
        private Label customerMobile;
        private Label customerName;
    }
}
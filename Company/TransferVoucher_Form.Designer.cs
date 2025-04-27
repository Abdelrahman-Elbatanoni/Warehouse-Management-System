namespace Company
{
    partial class TransferVoucher_Form
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
            TransferItems = new Button();
            label38 = new Label();
            panel5 = new Panel();
            label6 = new Label();
            destWarehouseId = new Label();
            destWarehouseAddress = new Label();
            destWarehouseName = new Label();
            label47 = new Label();
            label48 = new Label();
            label19 = new Label();
            panel4 = new Panel();
            label4 = new Label();
            sourceWarehouseId = new Label();
            sourceWarehouseAddress = new Label();
            SourceWarehouseName = new Label();
            label43 = new Label();
            label44 = new Label();
            sourceWarehouse_Items_ListBox = new ListBox();
            label1 = new Label();
            label2 = new Label();
            itemAvailableQuantity = new Label();
            label3 = new Label();
            quantityToTransfer = new TextBox();
            label5 = new Label();
            panel1 = new Panel();
            itemSuppName = new Label();
            label7 = new Label();
            itemExpiryDate = new Label();
            label8 = new Label();
            ItemProdDate = new Label();
            ItemSupplierId = new Label();
            label11 = new Label();
            label12 = new Label();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // TransferItems
            // 
            TransferItems.BackColor = Color.LightGreen;
            TransferItems.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TransferItems.Location = new Point(484, 585);
            TransferItems.Name = "TransferItems";
            TransferItems.Size = new Size(184, 55);
            TransferItems.TabIndex = 26;
            TransferItems.Text = "Transfer";
            TransferItems.UseVisualStyleBackColor = false;
            TransferItems.Click += TransferItems_Click;
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Location = new Point(758, 341);
            label38.Name = "label38";
            label38.Size = new Size(212, 20);
            label38.TabIndex = 25;
            label38.Text = "Destination Warehouse Details";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.GradientInactiveCaption;
            panel5.Controls.Add(label6);
            panel5.Controls.Add(destWarehouseId);
            panel5.Controls.Add(destWarehouseAddress);
            panel5.Controls.Add(destWarehouseName);
            panel5.Controls.Add(label47);
            panel5.Controls.Add(label48);
            panel5.ForeColor = Color.Black;
            panel5.Location = new Point(758, 354);
            panel5.Name = "panel5";
            panel5.Size = new Size(250, 202);
            panel5.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 29);
            label6.Name = "label6";
            label6.Size = new Size(27, 20);
            label6.TabIndex = 35;
            label6.Text = "ID:";
            // 
            // destWarehouseId
            // 
            destWarehouseId.AutoSize = true;
            destWarehouseId.Location = new Point(58, 29);
            destWarehouseId.Name = "destWarehouseId";
            destWarehouseId.Size = new Size(0, 20);
            destWarehouseId.TabIndex = 36;
            // 
            // destWarehouseAddress
            // 
            destWarehouseAddress.AutoSize = true;
            destWarehouseAddress.Location = new Point(96, 152);
            destWarehouseAddress.Name = "destWarehouseAddress";
            destWarehouseAddress.Size = new Size(0, 20);
            destWarehouseAddress.TabIndex = 12;
            // 
            // destWarehouseName
            // 
            destWarehouseName.AutoSize = true;
            destWarehouseName.Location = new Point(81, 93);
            destWarehouseName.Name = "destWarehouseName";
            destWarehouseName.Size = new Size(0, 20);
            destWarehouseName.TabIndex = 11;
            // 
            // label47
            // 
            label47.AutoSize = true;
            label47.Location = new Point(25, 152);
            label47.Name = "label47";
            label47.Size = new Size(65, 20);
            label47.TabIndex = 10;
            label47.Text = "Address:";
            // 
            // label48
            // 
            label48.AutoSize = true;
            label48.Location = new Point(23, 93);
            label48.Name = "label48";
            label48.Size = new Size(52, 20);
            label48.TabIndex = 9;
            label48.Text = "Name:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(157, 346);
            label19.Name = "label19";
            label19.Size = new Size(181, 20);
            label19.TabIndex = 23;
            label19.Text = "Source Warehouse Details";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.GradientInactiveCaption;
            panel4.Controls.Add(label4);
            panel4.Controls.Add(sourceWarehouseId);
            panel4.Controls.Add(sourceWarehouseAddress);
            panel4.Controls.Add(SourceWarehouseName);
            panel4.Controls.Add(label43);
            panel4.Controls.Add(label44);
            panel4.ForeColor = Color.Black;
            panel4.Location = new Point(157, 359);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 197);
            panel4.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 24);
            label4.Name = "label4";
            label4.Size = new Size(27, 20);
            label4.TabIndex = 33;
            label4.Text = "ID:";
            // 
            // sourceWarehouseId
            // 
            sourceWarehouseId.AutoSize = true;
            sourceWarehouseId.Location = new Point(51, 24);
            sourceWarehouseId.Name = "sourceWarehouseId";
            sourceWarehouseId.Size = new Size(0, 20);
            sourceWarehouseId.TabIndex = 34;
            // 
            // sourceWarehouseAddress
            // 
            sourceWarehouseAddress.AutoSize = true;
            sourceWarehouseAddress.Location = new Point(91, 147);
            sourceWarehouseAddress.Name = "sourceWarehouseAddress";
            sourceWarehouseAddress.Size = new Size(0, 20);
            sourceWarehouseAddress.TabIndex = 12;
            // 
            // SourceWarehouseName
            // 
            SourceWarehouseName.AutoSize = true;
            SourceWarehouseName.Location = new Point(76, 88);
            SourceWarehouseName.Name = "SourceWarehouseName";
            SourceWarehouseName.Size = new Size(0, 20);
            SourceWarehouseName.TabIndex = 11;
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.Location = new Point(20, 147);
            label43.Name = "label43";
            label43.Size = new Size(65, 20);
            label43.TabIndex = 10;
            label43.Text = "Address:";
            // 
            // label44
            // 
            label44.AutoSize = true;
            label44.Location = new Point(18, 88);
            label44.Name = "label44";
            label44.Size = new Size(52, 20);
            label44.TabIndex = 9;
            label44.Text = "Name:";
            // 
            // sourceWarehouse_Items_ListBox
            // 
            sourceWarehouse_Items_ListBox.FormattingEnabled = true;
            sourceWarehouse_Items_ListBox.Location = new Point(26, 32);
            sourceWarehouse_Items_ListBox.Name = "sourceWarehouse_Items_ListBox";
            sourceWarehouse_Items_ListBox.Size = new Size(503, 224);
            sourceWarehouse_Items_ListBox.TabIndex = 27;
            sourceWarehouse_Items_ListBox.SelectedIndexChanged += sourceWarehouse_Items_ListBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 9);
            label1.Name = "label1";
            label1.Size = new Size(171, 20);
            label1.TabIndex = 28;
            label1.Text = "Source Warehouse Items";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 100);
            label2.Name = "label2";
            label2.Size = new Size(134, 20);
            label2.TabIndex = 29;
            label2.Text = "Available Quantity:";
            // 
            // itemAvailableQuantity
            // 
            itemAvailableQuantity.AutoSize = true;
            itemAvailableQuantity.Location = new Point(169, 100);
            itemAvailableQuantity.Name = "itemAvailableQuantity";
            itemAvailableQuantity.Size = new Size(0, 20);
            itemAvailableQuantity.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(448, 450);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 31;
            label3.Text = "Quantity:";
            // 
            // quantityToTransfer
            // 
            quantityToTransfer.Location = new Point(568, 447);
            quantityToTransfer.Name = "quantityToTransfer";
            quantityToTransfer.Size = new Size(125, 27);
            quantityToTransfer.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(643, 9);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 34;
            label5.Text = "Item Details";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(itemSuppName);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(itemExpiryDate);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(ItemProdDate);
            panel1.Controls.Add(ItemSupplierId);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(itemAvailableQuantity);
            panel1.Controls.Add(label2);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(643, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(503, 224);
            panel1.TabIndex = 33;
            // 
            // itemSuppName
            // 
            itemSuppName.AutoSize = true;
            itemSuppName.Location = new Point(142, 59);
            itemSuppName.Name = "itemSuppName";
            itemSuppName.Size = new Size(0, 20);
            itemSuppName.TabIndex = 34;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 59);
            label7.Name = "label7";
            label7.Size = new Size(111, 20);
            label7.TabIndex = 33;
            label7.Text = "Supplier Name:";
            // 
            // itemExpiryDate
            // 
            itemExpiryDate.AutoSize = true;
            itemExpiryDate.Location = new Point(119, 183);
            itemExpiryDate.Name = "itemExpiryDate";
            itemExpiryDate.Size = new Size(0, 20);
            itemExpiryDate.TabIndex = 32;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(25, 183);
            label8.Name = "label8";
            label8.Size = new Size(88, 20);
            label8.TabIndex = 31;
            label8.Text = "Expiry Date:";
            // 
            // ItemProdDate
            // 
            ItemProdDate.AutoSize = true;
            ItemProdDate.Location = new Point(151, 144);
            ItemProdDate.Name = "ItemProdDate";
            ItemProdDate.Size = new Size(0, 20);
            ItemProdDate.TabIndex = 12;
            // 
            // ItemSupplierId
            // 
            ItemSupplierId.AutoSize = true;
            ItemSupplierId.Location = new Point(117, 18);
            ItemSupplierId.Name = "ItemSupplierId";
            ItemSupplierId.Size = new Size(0, 20);
            ItemSupplierId.TabIndex = 11;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(25, 144);
            label11.Name = "label11";
            label11.Size = new Size(120, 20);
            label11.TabIndex = 10;
            label11.Text = "Production Date:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(25, 18);
            label12.Name = "label12";
            label12.Size = new Size(86, 20);
            label12.TabIndex = 9;
            label12.Text = "Supplier ID:";
            // 
            // TransferVoucher_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1179, 691);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(quantityToTransfer);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(sourceWarehouse_Items_ListBox);
            Controls.Add(TransferItems);
            Controls.Add(label38);
            Controls.Add(panel5);
            Controls.Add(label19);
            Controls.Add(panel4);
            MaximizeBox = false;
            Name = "TransferVoucher_Form";
            Text = "TransferVoucher_Form";
            Load += TransferVoucher_Form_Load;
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button TransferItems;
        private Label label38;
        private Panel panel5;
        private Label destWarehouseAddress;
        private Label destWarehouseName;
        private Label label47;
        private Label label48;
        private Label label19;
        private Panel panel4;
        private Label sourceWarehouseAddress;
        private Label SourceWarehouseName;
        private Label label43;
        private Label label44;
        private ListBox sourceWarehouse_Items_ListBox;
        private Label label1;
        private Label label2;
        private Label itemAvailableQuantity;
        private Label label6;
        private Label destWarehouseId;
        private Label label4;
        private Label sourceWarehouseId;
        private Label label3;
        private TextBox quantityToTransfer;
        private Label label5;
        private Panel panel1;
        private Label ItemProdDate;
        private Label ItemSupplierId;
        private Label label11;
        private Label label12;
        private Label itemExpiryDate;
        private Label label8;
        private Label itemSuppName;
        private Label label7;
    }
}
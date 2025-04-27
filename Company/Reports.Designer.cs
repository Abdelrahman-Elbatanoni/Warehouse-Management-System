namespace Company
{
    partial class Reports
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            SupplyVocherBox = new ComboBox();
            tabPage2 = new TabPage();
            dataGridView2 = new DataGridView();
            label2 = new Label();
            StockReleaseVoucherBox = new ComboBox();
            tabPage3 = new TabPage();
            label12 = new Label();
            label13 = new Label();
            panel2 = new Panel();
            SecAddressLabel = new Label();
            label7 = new Label();
            SecNameLabel = new Label();
            label5 = new Label();
            panel1 = new Panel();
            WarehouseAddressLabel = new Label();
            WarehouseNameLabel = new Label();
            label9 = new Label();
            label4 = new Label();
            dataGridView3 = new DataGridView();
            label3 = new Label();
            WarehouseBox = new ComboBox();
            tabPage4 = new TabPage();
            dataGridView4 = new DataGridView();
            label6 = new Label();
            ItemBox = new ComboBox();
            tabPage5 = new TabPage();
            TransferHistory_Btn = new Button();
            label10 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            dataGridView5 = new DataGridView();
            label8 = new Label();
            tabPage6 = new TabPage();
            NumofDays = new NumericUpDown();
            label11 = new Label();
            itmStoringPeriod_WarehouseBox = new ComboBox();
            ShowItemsBtn = new Button();
            dataGridView6 = new DataGridView();
            label14 = new Label();
            tabPage7 = new TabPage();
            label15 = new Label();
            itmsToExpire_WarehouseBox = new ComboBox();
            itmsToExpire_ShowBtn = new Button();
            dataGridView7 = new DataGridView();
            ItmsStatus = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).BeginInit();
            tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumofDays).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView6).BeginInit();
            tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView7).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Controls.Add(tabPage7);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1181, 708);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(SupplyVocherBox);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1173, 675);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Supply Voucher ";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 127);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1112, 489);
            dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(406, 50);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 1;
            label1.Text = "Voucher Id:";
            // 
            // SupplyVocherBox
            // 
            SupplyVocherBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SupplyVocherBox.FormattingEnabled = true;
            SupplyVocherBox.Location = new Point(523, 47);
            SupplyVocherBox.Name = "SupplyVocherBox";
            SupplyVocherBox.Size = new Size(151, 28);
            SupplyVocherBox.TabIndex = 0;
            SupplyVocherBox.SelectedIndexChanged += SupplyVocherBox_SelectedIndexChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(StockReleaseVoucherBox);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1173, 675);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Stock Release Voucher";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(30, 133);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(1112, 489);
            dataGridView2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(409, 56);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 3;
            label2.Text = "Voucher Id:";
            // 
            // StockReleaseVoucherBox
            // 
            StockReleaseVoucherBox.DropDownStyle = ComboBoxStyle.DropDownList;
            StockReleaseVoucherBox.FormattingEnabled = true;
            StockReleaseVoucherBox.Location = new Point(526, 53);
            StockReleaseVoucherBox.Name = "StockReleaseVoucherBox";
            StockReleaseVoucherBox.Size = new Size(151, 28);
            StockReleaseVoucherBox.TabIndex = 2;
            StockReleaseVoucherBox.SelectedIndexChanged += StockReleaseVoucherBox_SelectedIndexChanged;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label12);
            tabPage3.Controls.Add(label13);
            tabPage3.Controls.Add(panel2);
            tabPage3.Controls.Add(panel1);
            tabPage3.Controls.Add(dataGridView3);
            tabPage3.Controls.Add(label3);
            tabPage3.Controls.Add(WarehouseBox);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1173, 675);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Warehouse";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(87, 84);
            label12.Name = "label12";
            label12.Size = new Size(132, 20);
            label12.TabIndex = 4;
            label12.Text = "Warehouse Details";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(816, 84);
            label13.Name = "label13";
            label13.Size = new Size(120, 20);
            label13.TabIndex = 5;
            label13.Text = "Secretary Details";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientInactiveCaption;
            panel2.Controls.Add(SecAddressLabel);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(SecNameLabel);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(820, 107);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 125);
            panel2.TabIndex = 0;
            // 
            // SecAddressLabel
            // 
            SecAddressLabel.AutoSize = true;
            SecAddressLabel.Location = new Point(88, 91);
            SecAddressLabel.Name = "SecAddressLabel";
            SecAddressLabel.Size = new Size(0, 20);
            SecAddressLabel.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 91);
            label7.Name = "label7";
            label7.Size = new Size(65, 20);
            label7.TabIndex = 3;
            label7.Text = "Address:";
            // 
            // SecNameLabel
            // 
            SecNameLabel.AutoSize = true;
            SecNameLabel.Location = new Point(75, 24);
            SecNameLabel.Name = "SecNameLabel";
            SecNameLabel.Size = new Size(0, 20);
            SecNameLabel.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 24);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 1;
            label5.Text = "Name:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(WarehouseAddressLabel);
            panel1.Controls.Add(WarehouseNameLabel);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label4);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(92, 107);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 125);
            panel1.TabIndex = 5;
            // 
            // WarehouseAddressLabel
            // 
            WarehouseAddressLabel.AutoSize = true;
            WarehouseAddressLabel.Location = new Point(88, 91);
            WarehouseAddressLabel.Name = "WarehouseAddressLabel";
            WarehouseAddressLabel.Size = new Size(0, 20);
            WarehouseAddressLabel.TabIndex = 3;
            // 
            // WarehouseNameLabel
            // 
            WarehouseNameLabel.AutoSize = true;
            WarehouseNameLabel.Location = new Point(69, 24);
            WarehouseNameLabel.Name = "WarehouseNameLabel";
            WarehouseNameLabel.Size = new Size(0, 20);
            WarehouseNameLabel.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 91);
            label9.Name = "label9";
            label9.Size = new Size(65, 20);
            label9.TabIndex = 1;
            label9.Text = "Address:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 24);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 0;
            label4.Text = "Name:";
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(30, 287);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(1112, 335);
            dataGridView3.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(409, 56);
            label3.Name = "label3";
            label3.Size = new Size(128, 23);
            label3.TabIndex = 3;
            label3.Text = " Warehouse Id:";
            // 
            // WarehouseBox
            // 
            WarehouseBox.DropDownStyle = ComboBoxStyle.DropDownList;
            WarehouseBox.FormattingEnabled = true;
            WarehouseBox.Location = new Point(543, 53);
            WarehouseBox.Name = "WarehouseBox";
            WarehouseBox.Size = new Size(151, 28);
            WarehouseBox.TabIndex = 2;
            WarehouseBox.SelectedIndexChanged += WarehouseBox_SelectedIndexChanged;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(dataGridView4);
            tabPage4.Controls.Add(label6);
            tabPage4.Controls.Add(ItemBox);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1173, 675);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Item";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(30, 133);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 51;
            dataGridView4.Size = new Size(1112, 489);
            dataGridView4.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(426, 56);
            label6.Name = "label6";
            label6.Size = new Size(73, 23);
            label6.TabIndex = 3;
            label6.Text = "Item Id:";
            // 
            // ItemBox
            // 
            ItemBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ItemBox.FormattingEnabled = true;
            ItemBox.Location = new Point(526, 53);
            ItemBox.Name = "ItemBox";
            ItemBox.Size = new Size(151, 28);
            ItemBox.TabIndex = 2;
            ItemBox.SelectedIndexChanged += ItemBox_SelectedIndexChanged;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(TransferHistory_Btn);
            tabPage5.Controls.Add(label10);
            tabPage5.Controls.Add(dateTimePicker2);
            tabPage5.Controls.Add(dateTimePicker1);
            tabPage5.Controls.Add(dataGridView5);
            tabPage5.Controls.Add(label8);
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(1173, 675);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Transfer Voucher";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // TransferHistory_Btn
            // 
            TransferHistory_Btn.BackColor = Color.MediumSpringGreen;
            TransferHistory_Btn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TransferHistory_Btn.Location = new Point(523, 114);
            TransferHistory_Btn.Name = "TransferHistory_Btn";
            TransferHistory_Btn.Size = new Size(135, 51);
            TransferHistory_Btn.TabIndex = 8;
            TransferHistory_Btn.Text = "Show Histoy";
            TransferHistory_Btn.UseVisualStyleBackColor = false;
            TransferHistory_Btn.Click += TransferHistory_Btn_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(692, 37);
            label10.Name = "label10";
            label10.Size = new Size(88, 23);
            label10.TabIndex = 7;
            label10.Text = "End Date:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(802, 34);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(207, 37);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 5;
            // 
            // dataGridView5
            // 
            dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView5.Location = new Point(30, 211);
            dataGridView5.Name = "dataGridView5";
            dataGridView5.RowHeadersWidth = 51;
            dataGridView5.Size = new Size(1112, 411);
            dataGridView5.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(103, 37);
            label8.Name = "label8";
            label8.Size = new Size(98, 23);
            label8.TabIndex = 3;
            label8.Text = "Start Date:";
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(ItmsStatus);
            tabPage6.Controls.Add(NumofDays);
            tabPage6.Controls.Add(label11);
            tabPage6.Controls.Add(itmStoringPeriod_WarehouseBox);
            tabPage6.Controls.Add(ShowItemsBtn);
            tabPage6.Controls.Add(dataGridView6);
            tabPage6.Controls.Add(label14);
            tabPage6.Location = new Point(4, 29);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(1173, 675);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "items Storing Period";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // NumofDays
            // 
            NumofDays.Location = new Point(275, 53);
            NumofDays.Name = "NumofDays";
            NumofDays.Size = new Size(150, 27);
            NumofDays.TabIndex = 17;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(732, 51);
            label11.Name = "label11";
            label11.Size = new Size(128, 23);
            label11.TabIndex = 16;
            label11.Text = " Warehouse Id:";
            // 
            // itmStoringPeriod_WarehouseBox
            // 
            itmStoringPeriod_WarehouseBox.DropDownStyle = ComboBoxStyle.DropDownList;
            itmStoringPeriod_WarehouseBox.FormattingEnabled = true;
            itmStoringPeriod_WarehouseBox.Location = new Point(866, 48);
            itmStoringPeriod_WarehouseBox.Name = "itmStoringPeriod_WarehouseBox";
            itmStoringPeriod_WarehouseBox.Size = new Size(151, 28);
            itmStoringPeriod_WarehouseBox.TabIndex = 15;
            // 
            // ShowItemsBtn
            // 
            ShowItemsBtn.BackColor = Color.MediumSpringGreen;
            ShowItemsBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ShowItemsBtn.Location = new Point(523, 123);
            ShowItemsBtn.Name = "ShowItemsBtn";
            ShowItemsBtn.Size = new Size(135, 51);
            ShowItemsBtn.TabIndex = 14;
            ShowItemsBtn.Text = "Show Items";
            ShowItemsBtn.UseVisualStyleBackColor = false;
            ShowItemsBtn.Click += ShowItemsBtn_Click;
            // 
            // dataGridView6
            // 
            dataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView6.Location = new Point(30, 220);
            dataGridView6.Name = "dataGridView6";
            dataGridView6.RowHeadersWidth = 51;
            dataGridView6.Size = new Size(1112, 411);
            dataGridView6.TabIndex = 10;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(123, 53);
            label14.Name = "label14";
            label14.Size = new Size(146, 23);
            label14.TabIndex = 9;
            label14.Text = "Number of Days:";
            // 
            // tabPage7
            // 
            tabPage7.Controls.Add(label15);
            tabPage7.Controls.Add(itmsToExpire_WarehouseBox);
            tabPage7.Controls.Add(itmsToExpire_ShowBtn);
            tabPage7.Controls.Add(dataGridView7);
            tabPage7.Location = new Point(4, 29);
            tabPage7.Name = "tabPage7";
            tabPage7.Size = new Size(1173, 675);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "Items To Expire";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(447, 35);
            label15.Name = "label15";
            label15.Size = new Size(128, 23);
            label15.TabIndex = 22;
            label15.Text = " Warehouse Id:";
            // 
            // itmsToExpire_WarehouseBox
            // 
            itmsToExpire_WarehouseBox.DropDownStyle = ComboBoxStyle.DropDownList;
            itmsToExpire_WarehouseBox.FormattingEnabled = true;
            itmsToExpire_WarehouseBox.Location = new Point(581, 32);
            itmsToExpire_WarehouseBox.Name = "itmsToExpire_WarehouseBox";
            itmsToExpire_WarehouseBox.Size = new Size(151, 28);
            itmsToExpire_WarehouseBox.TabIndex = 21;
            // 
            // itmsToExpire_ShowBtn
            // 
            itmsToExpire_ShowBtn.BackColor = Color.MediumSpringGreen;
            itmsToExpire_ShowBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itmsToExpire_ShowBtn.Location = new Point(523, 121);
            itmsToExpire_ShowBtn.Name = "itmsToExpire_ShowBtn";
            itmsToExpire_ShowBtn.Size = new Size(135, 51);
            itmsToExpire_ShowBtn.TabIndex = 20;
            itmsToExpire_ShowBtn.Text = "Show Items";
            itmsToExpire_ShowBtn.UseVisualStyleBackColor = false;
            itmsToExpire_ShowBtn.Click += itmsToExpire_ShowBtn_Click;
            // 
            // dataGridView7
            // 
            dataGridView7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView7.Location = new Point(30, 218);
            dataGridView7.Name = "dataGridView7";
            dataGridView7.RowHeadersWidth = 51;
            dataGridView7.Size = new Size(1112, 411);
            dataGridView7.TabIndex = 19;
            // 
            // ItmsStatus
            // 
            ItmsStatus.AutoSize = true;
            ItmsStatus.Location = new Point(65, 185);
            ItmsStatus.Name = "ItmsStatus";
            ItmsStatus.Size = new Size(0, 20);
            ItmsStatus.TabIndex = 19;
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 707);
            Controls.Add(tabControl1);
            MaximizeBox = false;
            Name = "Reports";
            Text = "Reports";
            Load += Reports_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumofDays).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView6).EndInit();
            tabPage7.ResumeLayout(false);
            tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView7).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label1;
        private ComboBox SupplyVocherBox;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label label2;
        private ComboBox StockReleaseVoucherBox;
        private TabPage tabPage3;
        private DataGridView dataGridView3;
        private Label label3;
        private ComboBox WarehouseBox;
        private Panel panel2;
        private Panel panel1;
        private Label label12;
        private Label label13;
        private Label SecAddressLabel;
        private Label label7;
        private Label SecNameLabel;
        private Label label5;
        private Label WarehouseAddressLabel;
        private Label WarehouseNameLabel;
        private Label label9;
        private Label label4;
        private TabPage tabPage4;
        private DataGridView dataGridView4;
        private Label label6;
        private ComboBox ItemBox;
        private TabPage tabPage5;
        private Label label10;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView5;
        private Label label8;
        private Button TransferHistory_Btn;
        private TabPage tabPage6;
        private Label label11;
        private ComboBox itmStoringPeriod_WarehouseBox;
        private Button ShowItemsBtn;
        private DateTimePicker dateTimePicker4;
        private DataGridView dataGridView6;
        private Label label14;
        private NumericUpDown NumofDays;
        private TabPage tabPage7;
        private Label label15;
        private ComboBox itmsToExpire_WarehouseBox;
        private Button itmsToExpire_ShowBtn;
        private DataGridView dataGridView7;
        private Label ItmsStatus;
    }
}
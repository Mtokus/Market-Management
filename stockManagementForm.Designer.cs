﻿namespace Market_Management
{
    partial class stockManagementForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.clearProductTextboxButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.productGroupIDTxt = new System.Windows.Forms.TextBox();
            this.supplierIDTxt = new System.Windows.Forms.TextBox();
            this.productIDTxt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.comboBoxSupplierForInventory = new System.Windows.Forms.ComboBox();
            this.comboBoxProductGroupForInventory = new System.Windows.Forms.ComboBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.productDescriptionTxt = new System.Windows.Forms.TextBox();
            this.productStockQuantityTxt = new System.Windows.Forms.TextBox();
            this.productKdvRateTxt = new System.Windows.Forms.TextBox();
            this.productBarcodeTxt = new System.Windows.Forms.TextBox();
            this.productPriceTxt = new System.Windows.Forms.TextBox();
            this.productNameTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.clearSupplierTextboxButton = new System.Windows.Forms.Button();
            this.supplierIDLabel = new System.Windows.Forms.Label();
            this.supplierListButton = new System.Windows.Forms.Button();
            this.deleteSupplierButton = new System.Windows.Forms.Button();
            this.updateSupplierButton = new System.Windows.Forms.Button();
            this.btnSupplierAdd = new System.Windows.Forms.Button();
            this.txtSupplierAddress = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSupplierEmail = new System.Windows.Forms.TextBox();
            this.txtSupplierIbanNo = new System.Windows.Forms.TextBox();
            this.txtSupplierPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(795, 605);
            this.splitContainer1.SplitterDistance = 286;
            this.splitContainer1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(227)))), ((int)(((byte)(169)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(795, 286);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(795, 315);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(227)))), ((int)(((byte)(169)))));
            this.tabPage1.Controls.Add(this.clearProductTextboxButton);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.productGroupIDTxt);
            this.tabPage1.Controls.Add(this.supplierIDTxt);
            this.tabPage1.Controls.Add(this.productIDTxt);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.txtFilter);
            this.tabPage1.Controls.Add(this.comboBoxSupplierForInventory);
            this.tabPage1.Controls.Add(this.comboBoxProductGroupForInventory);
            this.tabPage1.Controls.Add(this.deleteButton);
            this.tabPage1.Controls.Add(this.updateButton);
            this.tabPage1.Controls.Add(this.addButton);
            this.tabPage1.Controls.Add(this.productDescriptionTxt);
            this.tabPage1.Controls.Add(this.productStockQuantityTxt);
            this.tabPage1.Controls.Add(this.productKdvRateTxt);
            this.tabPage1.Controls.Add(this.productBarcodeTxt);
            this.tabPage1.Controls.Add(this.productPriceTxt);
            this.tabPage1.Controls.Add(this.productNameTxt);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(787, 289);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Envanter İşlemleri";
            // 
            // clearProductTextboxButton
            // 
            this.clearProductTextboxButton.Location = new System.Drawing.Point(569, 246);
            this.clearProductTextboxButton.Name = "clearProductTextboxButton";
            this.clearProductTextboxButton.Size = new System.Drawing.Size(96, 27);
            this.clearProductTextboxButton.TabIndex = 12;
            this.clearProductTextboxButton.Text = "Tümünü Temizle";
            this.clearProductTextboxButton.UseVisualStyleBackColor = true;
            this.clearProductTextboxButton.Click += new System.EventHandler(this.clearProductTextboxButton_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(332, 113);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(42, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 13);
            this.label16.TabIndex = 44;
            this.label16.Text = "Ürün ID :";
            this.label16.Visible = false;
            // 
            // productGroupIDTxt
            // 
            this.productGroupIDTxt.Enabled = false;
            this.productGroupIDTxt.Location = new System.Drawing.Point(493, 74);
            this.productGroupIDTxt.Name = "productGroupIDTxt";
            this.productGroupIDTxt.Size = new System.Drawing.Size(67, 20);
            this.productGroupIDTxt.TabIndex = 43;
            this.productGroupIDTxt.Visible = false;
            // 
            // supplierIDTxt
            // 
            this.supplierIDTxt.Enabled = false;
            this.supplierIDTxt.Location = new System.Drawing.Point(493, 42);
            this.supplierIDTxt.Name = "supplierIDTxt";
            this.supplierIDTxt.Size = new System.Drawing.Size(67, 20);
            this.supplierIDTxt.TabIndex = 42;
            this.supplierIDTxt.Visible = false;
            // 
            // productIDTxt
            // 
            this.productIDTxt.Enabled = false;
            this.productIDTxt.Location = new System.Drawing.Point(101, 16);
            this.productIDTxt.Name = "productIDTxt";
            this.productIDTxt.Size = new System.Drawing.Size(78, 20);
            this.productIDTxt.TabIndex = 0;
            this.productIDTxt.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(31, 260);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 40;
            this.label15.Text = "Ürün Filtre :";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(101, 257);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(106, 20);
            this.txtFilter.TabIndex = 39;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // comboBoxSupplierForInventory
            // 
            this.comboBoxSupplierForInventory.FormattingEnabled = true;
            this.comboBoxSupplierForInventory.Location = new System.Drawing.Point(332, 42);
            this.comboBoxSupplierForInventory.Name = "comboBoxSupplierForInventory";
            this.comboBoxSupplierForInventory.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSupplierForInventory.TabIndex = 5;
            this.comboBoxSupplierForInventory.SelectedIndexChanged += new System.EventHandler(this.comboBoxSupplierForInventory_SelectedIndexChanged);
            // 
            // comboBoxProductGroupForInventory
            // 
            this.comboBoxProductGroupForInventory.FormattingEnabled = true;
            this.comboBoxProductGroupForInventory.Location = new System.Drawing.Point(332, 76);
            this.comboBoxProductGroupForInventory.Name = "comboBoxProductGroupForInventory";
            this.comboBoxProductGroupForInventory.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProductGroupForInventory.TabIndex = 6;
            this.comboBoxProductGroupForInventory.SelectedIndexChanged += new System.EventHandler(this.comboBoxProductGroupForInventory_SelectedIndexChanged);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(577, 117);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(88, 26);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "Sil";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(577, 81);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(88, 26);
            this.updateButton.TabIndex = 10;
            this.updateButton.Text = "Güncelle";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(577, 42);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(88, 26);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Ekle";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // productDescriptionTxt
            // 
            this.productDescriptionTxt.Location = new System.Drawing.Point(332, 148);
            this.productDescriptionTxt.Multiline = true;
            this.productDescriptionTxt.Name = "productDescriptionTxt";
            this.productDescriptionTxt.Size = new System.Drawing.Size(333, 92);
            this.productDescriptionTxt.TabIndex = 8;
            // 
            // productStockQuantityTxt
            // 
            this.productStockQuantityTxt.Location = new System.Drawing.Point(101, 181);
            this.productStockQuantityTxt.Name = "productStockQuantityTxt";
            this.productStockQuantityTxt.Size = new System.Drawing.Size(78, 20);
            this.productStockQuantityTxt.TabIndex = 4;
            this.productStockQuantityTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.productPriceTxt_KeyPress);
            // 
            // productKdvRateTxt
            // 
            this.productKdvRateTxt.Location = new System.Drawing.Point(101, 148);
            this.productKdvRateTxt.Name = "productKdvRateTxt";
            this.productKdvRateTxt.Size = new System.Drawing.Size(78, 20);
            this.productKdvRateTxt.TabIndex = 3;
            this.productKdvRateTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.productKdvRateTxt_KeyPress);
            // 
            // productBarcodeTxt
            // 
            this.productBarcodeTxt.Location = new System.Drawing.Point(101, 115);
            this.productBarcodeTxt.Name = "productBarcodeTxt";
            this.productBarcodeTxt.Size = new System.Drawing.Size(78, 20);
            this.productBarcodeTxt.TabIndex = 2;
            this.productBarcodeTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.productPriceTxt_KeyPress);
            // 
            // productPriceTxt
            // 
            this.productPriceTxt.Location = new System.Drawing.Point(101, 82);
            this.productPriceTxt.Name = "productPriceTxt";
            this.productPriceTxt.Size = new System.Drawing.Size(78, 20);
            this.productPriceTxt.TabIndex = 1;
            this.productPriceTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(productKdvRateTxt_KeyPress);
            // 
            // productNameTxt
            // 
            this.productNameTxt.Location = new System.Drawing.Point(101, 49);
            this.productNameTxt.Name = "productNameTxt";
            this.productNameTxt.Size = new System.Drawing.Size(78, 20);
            this.productNameTxt.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(247, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Ürün Açıklma : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(239, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Ürün Alış Tarihi : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(255, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Ürün Grubu : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(238, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Tedarikçi Firma : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Stok Sayısı : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "KDV Oranı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Ürün Barkod : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Ürün Fiyatı : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Ürün Adı : ";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(227)))), ((int)(((byte)(169)))));
            this.tabPage2.Controls.Add(this.clearSupplierTextboxButton);
            this.tabPage2.Controls.Add(this.supplierIDLabel);
            this.tabPage2.Controls.Add(this.supplierListButton);
            this.tabPage2.Controls.Add(this.deleteSupplierButton);
            this.tabPage2.Controls.Add(this.updateSupplierButton);
            this.tabPage2.Controls.Add(this.btnSupplierAdd);
            this.tabPage2.Controls.Add(this.txtSupplierAddress);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.txtSupplierEmail);
            this.tabPage2.Controls.Add(this.txtSupplierIbanNo);
            this.tabPage2.Controls.Add(this.txtSupplierPhoneNumber);
            this.tabPage2.Controls.Add(this.txtSupplierName);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(787, 289);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tedarikçi İşlemleri";
            // 
            // clearSupplierTextboxButton
            // 
            this.clearSupplierTextboxButton.Location = new System.Drawing.Point(311, 233);
            this.clearSupplierTextboxButton.Name = "clearSupplierTextboxButton";
            this.clearSupplierTextboxButton.Size = new System.Drawing.Size(75, 23);
            this.clearSupplierTextboxButton.TabIndex = 9;
            this.clearSupplierTextboxButton.Text = "Temizle";
            this.clearSupplierTextboxButton.UseVisualStyleBackColor = true;
            this.clearSupplierTextboxButton.Click += new System.EventHandler(this.clearSupplierTextboxButton_Click);
            // 
            // supplierIDLabel
            // 
            this.supplierIDLabel.AutoSize = true;
            this.supplierIDLabel.Location = new System.Drawing.Point(326, 43);
            this.supplierIDLabel.Name = "supplierIDLabel";
            this.supplierIDLabel.Size = new System.Drawing.Size(41, 13);
            this.supplierIDLabel.TabIndex = 50;
            this.supplierIDLabel.Text = "label17";
            this.supplierIDLabel.Visible = false;
            // 
            // supplierListButton
            // 
            this.supplierListButton.Location = new System.Drawing.Point(547, 156);
            this.supplierListButton.Name = "supplierListButton";
            this.supplierListButton.Size = new System.Drawing.Size(88, 26);
            this.supplierListButton.TabIndex = 8;
            this.supplierListButton.Text = "Tümünü Listele";
            this.supplierListButton.UseVisualStyleBackColor = true;
            this.supplierListButton.Click += new System.EventHandler(this.supplierListButton_Click);
            // 
            // deleteSupplierButton
            // 
            this.deleteSupplierButton.Location = new System.Drawing.Point(547, 103);
            this.deleteSupplierButton.Name = "deleteSupplierButton";
            this.deleteSupplierButton.Size = new System.Drawing.Size(88, 26);
            this.deleteSupplierButton.TabIndex = 7;
            this.deleteSupplierButton.Text = "Sil";
            this.deleteSupplierButton.UseVisualStyleBackColor = true;
            this.deleteSupplierButton.Click += new System.EventHandler(this.deleteSupplierButton_Click);
            // 
            // updateSupplierButton
            // 
            this.updateSupplierButton.Location = new System.Drawing.Point(547, 67);
            this.updateSupplierButton.Name = "updateSupplierButton";
            this.updateSupplierButton.Size = new System.Drawing.Size(88, 26);
            this.updateSupplierButton.TabIndex = 6;
            this.updateSupplierButton.Text = "Güncelle";
            this.updateSupplierButton.UseVisualStyleBackColor = true;
            this.updateSupplierButton.Click += new System.EventHandler(this.updateSupplierButton_Click);
            // 
            // btnSupplierAdd
            // 
            this.btnSupplierAdd.Location = new System.Drawing.Point(547, 32);
            this.btnSupplierAdd.Name = "btnSupplierAdd";
            this.btnSupplierAdd.Size = new System.Drawing.Size(88, 26);
            this.btnSupplierAdd.TabIndex = 5;
            this.btnSupplierAdd.Text = "Ekle";
            this.btnSupplierAdd.UseVisualStyleBackColor = true;
            this.btnSupplierAdd.Click += new System.EventHandler(this.btnSupplierAdd_Click);
            // 
            // txtSupplierAddress
            // 
            this.txtSupplierAddress.Location = new System.Drawing.Point(133, 140);
            this.txtSupplierAddress.Multiline = true;
            this.txtSupplierAddress.Name = "txtSupplierAddress";
            this.txtSupplierAddress.Size = new System.Drawing.Size(253, 87);
            this.txtSupplierAddress.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(84, 143);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 44;
            this.label13.Text = "Adres : ";
            // 
            // txtSupplierEmail
            // 
            this.txtSupplierEmail.Location = new System.Drawing.Point(133, 114);
            this.txtSupplierEmail.Name = "txtSupplierEmail";
            this.txtSupplierEmail.Size = new System.Drawing.Size(173, 20);
            this.txtSupplierEmail.TabIndex = 3;
            // 
            // txtSupplierIbanNo
            // 
            this.txtSupplierIbanNo.Location = new System.Drawing.Point(133, 88);
            this.txtSupplierIbanNo.Name = "txtSupplierIbanNo";
            this.txtSupplierIbanNo.Size = new System.Drawing.Size(173, 20);
            this.txtSupplierIbanNo.TabIndex = 2;
            this.txtSupplierIbanNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.productPriceTxt_KeyPress);
            // 
            // txtSupplierPhoneNumber
            // 
            this.txtSupplierPhoneNumber.Location = new System.Drawing.Point(133, 62);
            this.txtSupplierPhoneNumber.Name = "txtSupplierPhoneNumber";
            this.txtSupplierPhoneNumber.Size = new System.Drawing.Size(173, 20);
            this.txtSupplierPhoneNumber.TabIndex = 1;
            this.txtSupplierPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.productPriceTxt_KeyPress);
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Location = new System.Drawing.Point(133, 36);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(173, 20);
            this.txtSupplierName.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(82, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "E-Mail : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(69, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "IBAN No : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "Telefon Numarası : ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(39, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 13);
            this.label14.TabIndex = 38;
            this.label14.Text = "Tedarikçi Firma : ";
            // 
            // stockManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(227)))), ((int)(((byte)(169)))));
            this.ClientSize = new System.Drawing.Size(795, 605);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "stockManagementForm";
            this.Text = "stockManagementForm";
            this.Load += new System.EventHandler(this.stockManagementForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtSupplierEmail;
        private System.Windows.Forms.TextBox txtSupplierIbanNo;
        private System.Windows.Forms.TextBox txtSupplierPhoneNumber;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSupplierAddress;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button deleteSupplierButton;
        private System.Windows.Forms.Button updateSupplierButton;
        private System.Windows.Forms.Button btnSupplierAdd;
        private System.Windows.Forms.Button supplierListButton;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox productGroupIDTxt;
        private System.Windows.Forms.TextBox supplierIDTxt;
        private System.Windows.Forms.TextBox productIDTxt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ComboBox comboBoxSupplierForInventory;
        private System.Windows.Forms.ComboBox comboBoxProductGroupForInventory;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox productDescriptionTxt;
        private System.Windows.Forms.TextBox productStockQuantityTxt;
        private System.Windows.Forms.TextBox productKdvRateTxt;
        private System.Windows.Forms.TextBox productBarcodeTxt;
        private System.Windows.Forms.TextBox productPriceTxt;
        private System.Windows.Forms.TextBox productNameTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label supplierIDLabel;
        private System.Windows.Forms.Button clearSupplierTextboxButton;
        private System.Windows.Forms.Button clearProductTextboxButton;
    }
}
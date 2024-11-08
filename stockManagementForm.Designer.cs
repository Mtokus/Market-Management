namespace Market_Management
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stockManagementForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productKDVRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productStockQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productGroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDetailID = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
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
            this.textBox3 = new System.Windows.Forms.TextBox();
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
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
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(227)))), ((int)(((byte)(169)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productID,
            this.productName,
            this.productPrice,
            this.productBarcode,
            this.productKDVRate,
            this.productStockQuantity,
            this.supplierName,
            this.productGroupName,
            this.productDetailID});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(795, 286);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // productID
            // 
            this.productID.HeaderText = "ID";
            this.productID.Name = "productID";
            this.productID.ReadOnly = true;
            this.productID.Visible = false;
            // 
            // productName
            // 
            this.productName.HeaderText = "Ürün Adı";
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            // 
            // productPrice
            // 
            this.productPrice.HeaderText = "Birim Fiyatı";
            this.productPrice.Name = "productPrice";
            this.productPrice.ReadOnly = true;
            // 
            // productBarcode
            // 
            this.productBarcode.HeaderText = "BARKOD";
            this.productBarcode.Name = "productBarcode";
            this.productBarcode.ReadOnly = true;
            // 
            // productKDVRate
            // 
            this.productKDVRate.HeaderText = "KDV Oranı";
            this.productKDVRate.Name = "productKDVRate";
            this.productKDVRate.ReadOnly = true;
            // 
            // productStockQuantity
            // 
            this.productStockQuantity.HeaderText = "Stok Miktarı";
            this.productStockQuantity.Name = "productStockQuantity";
            this.productStockQuantity.ReadOnly = true;
            // 
            // supplierName
            // 
            this.supplierName.HeaderText = "Tedarikçi Firma";
            this.supplierName.Name = "supplierName";
            this.supplierName.ReadOnly = true;
            // 
            // productGroupName
            // 
            this.productGroupName.HeaderText = "Ürün Grup";
            this.productGroupName.Name = "productGroupName";
            this.productGroupName.ReadOnly = true;
            // 
            // productDetailID
            // 
            this.productDetailID.HeaderText = "Ürün Detayı";
            this.productDetailID.Image = ((System.Drawing.Image)(resources.GetObject("productDetailID.Image")));
            this.productDetailID.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.productDetailID.Name = "productDetailID";
            this.productDetailID.ReadOnly = true;
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
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(227)))), ((int)(((byte)(169)))));
            this.tabPage1.Controls.Add(this.button3);
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
            this.tabPage1.Controls.Add(this.textBox3);
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(213, 240);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(38, 20);
            this.button3.TabIndex = 46;
            this.button3.Text = "Ara";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(332, 113);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 45;
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
            this.productIDTxt.TabIndex = 41;
            this.productIDTxt.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(57, 243);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 40;
            this.label15.Text = "Filtre :";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(101, 240);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(106, 20);
            this.txtFilter.TabIndex = 39;
            // 
            // comboBoxSupplierForInventory
            // 
            this.comboBoxSupplierForInventory.FormattingEnabled = true;
            this.comboBoxSupplierForInventory.Location = new System.Drawing.Point(332, 42);
            this.comboBoxSupplierForInventory.Name = "comboBoxSupplierForInventory";
            this.comboBoxSupplierForInventory.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSupplierForInventory.TabIndex = 38;
            this.comboBoxSupplierForInventory.SelectedIndexChanged += new System.EventHandler(this.comboBoxSupplierForInventory_SelectedIndexChanged);
            // 
            // comboBoxProductGroupForInventory
            // 
            this.comboBoxProductGroupForInventory.FormattingEnabled = true;
            this.comboBoxProductGroupForInventory.Location = new System.Drawing.Point(332, 76);
            this.comboBoxProductGroupForInventory.Name = "comboBoxProductGroupForInventory";
            this.comboBoxProductGroupForInventory.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProductGroupForInventory.TabIndex = 37;
            this.comboBoxProductGroupForInventory.SelectedIndexChanged += new System.EventHandler(this.comboBoxProductGroupForInventory_SelectedIndexChanged);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(577, 117);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(88, 26);
            this.deleteButton.TabIndex = 34;
            this.deleteButton.Text = "Sil";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(577, 81);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(88, 26);
            this.updateButton.TabIndex = 35;
            this.updateButton.Text = "Güncelle";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(577, 42);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(88, 26);
            this.addButton.TabIndex = 36;
            this.addButton.Text = "Ekle";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(332, 148);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(333, 92);
            this.textBox3.TabIndex = 27;
            // 
            // productStockQuantityTxt
            // 
            this.productStockQuantityTxt.Location = new System.Drawing.Point(101, 181);
            this.productStockQuantityTxt.Name = "productStockQuantityTxt";
            this.productStockQuantityTxt.Size = new System.Drawing.Size(78, 20);
            this.productStockQuantityTxt.TabIndex = 29;
            // 
            // productKdvRateTxt
            // 
            this.productKdvRateTxt.Location = new System.Drawing.Point(101, 148);
            this.productKdvRateTxt.Name = "productKdvRateTxt";
            this.productKdvRateTxt.Size = new System.Drawing.Size(78, 20);
            this.productKdvRateTxt.TabIndex = 30;
            // 
            // productBarcodeTxt
            // 
            this.productBarcodeTxt.Location = new System.Drawing.Point(101, 115);
            this.productBarcodeTxt.Name = "productBarcodeTxt";
            this.productBarcodeTxt.Size = new System.Drawing.Size(78, 20);
            this.productBarcodeTxt.TabIndex = 31;
            // 
            // productPriceTxt
            // 
            this.productPriceTxt.Location = new System.Drawing.Point(101, 82);
            this.productPriceTxt.Name = "productPriceTxt";
            this.productPriceTxt.Size = new System.Drawing.Size(78, 20);
            this.productPriceTxt.TabIndex = 32;
            // 
            // productNameTxt
            // 
            this.productNameTxt.Location = new System.Drawing.Point(101, 49);
            this.productNameTxt.Name = "productNameTxt";
            this.productNameTxt.Size = new System.Drawing.Size(78, 20);
            this.productNameTxt.TabIndex = 33;
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
            this.label6.Location = new System.Drawing.Point(237, 45);
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
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.button2);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(547, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 26);
            this.button1.TabIndex = 46;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(547, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 26);
            this.button2.TabIndex = 47;
            this.button2.Text = "Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnSupplierAdd
            // 
            this.btnSupplierAdd.Location = new System.Drawing.Point(547, 32);
            this.btnSupplierAdd.Name = "btnSupplierAdd";
            this.btnSupplierAdd.Size = new System.Drawing.Size(88, 26);
            this.btnSupplierAdd.TabIndex = 48;
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
            this.txtSupplierAddress.TabIndex = 45;
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
            this.txtSupplierEmail.TabIndex = 39;
            // 
            // txtSupplierIbanNo
            // 
            this.txtSupplierIbanNo.Location = new System.Drawing.Point(133, 88);
            this.txtSupplierIbanNo.Name = "txtSupplierIbanNo";
            this.txtSupplierIbanNo.Size = new System.Drawing.Size(173, 20);
            this.txtSupplierIbanNo.TabIndex = 40;
            // 
            // txtSupplierPhoneNumber
            // 
            this.txtSupplierPhoneNumber.Location = new System.Drawing.Point(133, 62);
            this.txtSupplierPhoneNumber.Name = "txtSupplierPhoneNumber";
            this.txtSupplierPhoneNumber.Size = new System.Drawing.Size(173, 20);
            this.txtSupplierPhoneNumber.TabIndex = 41;
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Location = new System.Drawing.Point(133, 36);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(173, 20);
            this.txtSupplierName.TabIndex = 43;
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
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
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox comboBoxSupplierForInventory;
        private System.Windows.Forms.ComboBox comboBoxProductGroupForInventory;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox textBox3;
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
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSupplierAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn productBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn productKDVRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn productStockQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productGroupName;
        private System.Windows.Forms.DataGridViewImageColumn productDetailID;
        private System.Windows.Forms.TextBox productGroupIDTxt;
        private System.Windows.Forms.TextBox supplierIDTxt;
        private System.Windows.Forms.TextBox productIDTxt;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtFilter;
    }
}
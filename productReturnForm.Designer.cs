namespace Market_Management
{
    partial class productReturnForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(productReturnForm));
            this.confirmReturnButton = new System.Windows.Forms.Button();
            this.productIDLabel = new System.Windows.Forms.Label();
            this.addSelectedButton = new System.Windows.Forms.Button();
            this.addAllButton = new System.Windows.Forms.Button();
            this.addSingleButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.productQuantityTxt = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteProduct = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.productNameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // confirmReturnButton
            // 
            this.confirmReturnButton.Location = new System.Drawing.Point(145, 385);
            this.confirmReturnButton.Name = "confirmReturnButton";
            this.confirmReturnButton.Size = new System.Drawing.Size(88, 23);
            this.confirmReturnButton.TabIndex = 6;
            this.confirmReturnButton.Text = "İadeyi Onayla";
            this.confirmReturnButton.UseVisualStyleBackColor = true;
            this.confirmReturnButton.Click += new System.EventHandler(this.confirmReturnButton_Click);
            // 
            // productIDLabel
            // 
            this.productIDLabel.AutoSize = true;
            this.productIDLabel.Location = new System.Drawing.Point(20, 192);
            this.productIDLabel.Name = "productIDLabel";
            this.productIDLabel.Size = new System.Drawing.Size(35, 13);
            this.productIDLabel.TabIndex = 6;
            this.productIDLabel.Text = "label4";
            this.productIDLabel.Visible = false;
            // 
            // addSelectedButton
            // 
            this.addSelectedButton.Location = new System.Drawing.Point(49, 144);
            this.addSelectedButton.Name = "addSelectedButton";
            this.addSelectedButton.Size = new System.Drawing.Size(87, 23);
            this.addSelectedButton.TabIndex = 4;
            this.addSelectedButton.Text = "Seçilenleri Ekle";
            this.addSelectedButton.UseVisualStyleBackColor = true;
            this.addSelectedButton.Click += new System.EventHandler(this.addSelectedButton_Click);
            // 
            // addAllButton
            // 
            this.addAllButton.Location = new System.Drawing.Point(146, 144);
            this.addAllButton.Name = "addAllButton";
            this.addAllButton.Size = new System.Drawing.Size(87, 23);
            this.addAllButton.TabIndex = 5;
            this.addAllButton.Text = "Tümünü Ekle";
            this.addAllButton.UseVisualStyleBackColor = true;
            this.addAllButton.Click += new System.EventHandler(this.addAllButton_Click);
            // 
            // addSingleButton
            // 
            this.addSingleButton.Location = new System.Drawing.Point(158, 95);
            this.addSingleButton.Name = "addSingleButton";
            this.addSingleButton.Size = new System.Drawing.Size(75, 23);
            this.addSingleButton.TabIndex = 3;
            this.addSingleButton.Text = "İade Ekle";
            this.addSingleButton.UseVisualStyleBackColor = true;
            this.addSingleButton.Click += new System.EventHandler(this.addSingleButton_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Location = new System.Drawing.Point(3, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 3);
            this.label3.TabIndex = 3;
            // 
            // productQuantityTxt
            // 
            this.productQuantityTxt.Location = new System.Drawing.Point(133, 69);
            this.productQuantityTxt.Name = "productQuantityTxt";
            this.productQuantityTxt.Size = new System.Drawing.Size(100, 20);
            this.productQuantityTxt.TabIndex = 2;
            this.productQuantityTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.productQuantityTxt_KeyPress);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productName,
            this.productQuantity,
            this.deleteProduct});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(502, 222);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // productName
            // 
            this.productName.HeaderText = "Ürün Adı";
            this.productName.Name = "productName";
            // 
            // productQuantity
            // 
            this.productQuantity.HeaderText = "İade Adeti";
            this.productQuantity.Name = "productQuantity";
            // 
            // deleteProduct
            // 
            this.deleteProduct.HeaderText = "İptal";
            this.deleteProduct.Image = ((System.Drawing.Image)(resources.GetObject("deleteProduct.Image")));
            this.deleteProduct.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.deleteProduct.Name = "deleteProduct";
            this.deleteProduct.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.deleteProduct.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(502, 225);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView2);
            this.splitContainer2.Size = new System.Drawing.Size(502, 451);
            this.splitContainer2.SplitterDistance = 225;
            this.splitContainer2.TabIndex = 0;
            // 
            // productNameTxt
            // 
            this.productNameTxt.Location = new System.Drawing.Point(133, 40);
            this.productNameTxt.Name = "productNameTxt";
            this.productNameTxt.Size = new System.Drawing.Size(100, 20);
            this.productNameTxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(46, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "İade Adeti :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(54, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı :";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 451);
            this.splitContainer1.SplitterDistance = 294;
            this.splitContainer1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.confirmReturnButton);
            this.panel2.Controls.Add(this.productIDLabel);
            this.panel2.Controls.Add(this.addSelectedButton);
            this.panel2.Controls.Add(this.addAllButton);
            this.panel2.Controls.Add(this.addSingleButton);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.productQuantityTxt);
            this.panel2.Controls.Add(this.productNameTxt);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 451);
            this.panel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 451);
            this.panel1.TabIndex = 0;
            // 
            // productReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.splitContainer1);
            this.Name = "productReturnForm";
            this.Text = "Ürün İade Formu";
            this.Load += new System.EventHandler(this.productReturnForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button confirmReturnButton;
        public System.Windows.Forms.Label productIDLabel;
        private System.Windows.Forms.Button addSelectedButton;
        private System.Windows.Forms.Button addAllButton;
        private System.Windows.Forms.Button addSingleButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox productQuantityTxt;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox productNameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productQuantity;
        private System.Windows.Forms.DataGridViewImageColumn deleteProduct;
    }
}
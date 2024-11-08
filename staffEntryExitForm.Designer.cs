using System.Windows.Forms;

namespace Market_Management
{
    partial class staffEntryExitForm
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
            this.panelEntryExitTable = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelEntryExitOperation = new System.Windows.Forms.Panel();
            this.labelKacSaat = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonExitFilter = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.buttonLeaveFilter = new System.Windows.Forms.Button();
            this.buttonEntryFilter = new System.Windows.Forms.Button();
            this.buttonDateFilter = new System.Windows.Forms.Button();
            this.buttonStaffNameFilter = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelEntryExitTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelEntryExitOperation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEntryExitTable
            // 
            this.panelEntryExitTable.Controls.Add(this.dataGridView1);
            this.panelEntryExitTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEntryExitTable.Location = new System.Drawing.Point(0, 0);
            this.panelEntryExitTable.Name = "panelEntryExitTable";
            this.panelEntryExitTable.Size = new System.Drawing.Size(595, 380);
            this.panelEntryExitTable.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(595, 380);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // panelEntryExitOperation
            // 
            this.panelEntryExitOperation.Controls.Add(this.labelKacSaat);
            this.panelEntryExitOperation.Controls.Add(this.dateTimePicker2);
            this.panelEntryExitOperation.Controls.Add(this.dateTimePicker1);
            this.panelEntryExitOperation.Controls.Add(this.buttonExitFilter);
            this.panelEntryExitOperation.Controls.Add(this.button5);
            this.panelEntryExitOperation.Controls.Add(this.buttonLeaveFilter);
            this.panelEntryExitOperation.Controls.Add(this.buttonEntryFilter);
            this.panelEntryExitOperation.Controls.Add(this.buttonDateFilter);
            this.panelEntryExitOperation.Controls.Add(this.buttonStaffNameFilter);
            this.panelEntryExitOperation.Controls.Add(this.textBox1);
            this.panelEntryExitOperation.Controls.Add(this.label2);
            this.panelEntryExitOperation.Controls.Add(this.label3);
            this.panelEntryExitOperation.Controls.Add(this.label1);
            this.panelEntryExitOperation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEntryExitOperation.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panelEntryExitOperation.Location = new System.Drawing.Point(0, 380);
            this.panelEntryExitOperation.Name = "panelEntryExitOperation";
            this.panelEntryExitOperation.Size = new System.Drawing.Size(595, 150);
            this.panelEntryExitOperation.TabIndex = 1;
            // 
            // labelKacSaat
            // 
            this.labelKacSaat.AutoSize = true;
            this.labelKacSaat.Location = new System.Drawing.Point(254, 37);
            this.labelKacSaat.Name = "labelKacSaat";
            this.labelKacSaat.Size = new System.Drawing.Size(58, 17);
            this.labelKacSaat.TabIndex = 5;
            this.labelKacSaat.Text = "Kaç saat";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = " dd/MM/yyyy";
            this.dateTimePicker2.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker2.Font = new System.Drawing.Font("Arial", 9.75F);
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(125, 85);
            this.dateTimePicker2.MaxDate = new System.DateTime(2050, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(104, 22);
            this.dateTimePicker2.TabIndex = 4;
            this.dateTimePicker2.Value = new System.DateTime(2024, 10, 23, 0, 0, 0, 0);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.CustomFormat = " dd/MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 85);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(104, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // buttonExitFilter
            // 
            this.buttonExitFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.buttonExitFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExitFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonExitFilter.Location = new System.Drawing.Point(357, 63);
            this.buttonExitFilter.Margin = new System.Windows.Forms.Padding(0);
            this.buttonExitFilter.Name = "buttonExitFilter";
            this.buttonExitFilter.Size = new System.Drawing.Size(59, 22);
            this.buttonExitFilter.TabIndex = 2;
            this.buttonExitFilter.Text = "Çıkışlar";
            this.buttonExitFilter.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(443, 34);
            this.button5.Margin = new System.Windows.Forms.Padding(0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(128, 87);
            this.button5.TabIndex = 2;
            this.button5.Text = "          Giriş-Çıkış \r\n               Ekle";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonLeaveFilter
            // 
            this.buttonLeaveFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.buttonLeaveFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLeaveFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonLeaveFilter.Location = new System.Drawing.Point(357, 91);
            this.buttonLeaveFilter.Margin = new System.Windows.Forms.Padding(0);
            this.buttonLeaveFilter.Name = "buttonLeaveFilter";
            this.buttonLeaveFilter.Size = new System.Drawing.Size(59, 22);
            this.buttonLeaveFilter.TabIndex = 2;
            this.buttonLeaveFilter.Text = "İzinler";
            this.buttonLeaveFilter.UseVisualStyleBackColor = false;
            // 
            // buttonEntryFilter
            // 
            this.buttonEntryFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.buttonEntryFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEntryFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonEntryFilter.Location = new System.Drawing.Point(357, 35);
            this.buttonEntryFilter.Margin = new System.Windows.Forms.Padding(0);
            this.buttonEntryFilter.Name = "buttonEntryFilter";
            this.buttonEntryFilter.Size = new System.Drawing.Size(59, 22);
            this.buttonEntryFilter.TabIndex = 2;
            this.buttonEntryFilter.Text = "Girişler";
            this.buttonEntryFilter.UseVisualStyleBackColor = false;
            // 
            // buttonDateFilter
            // 
            this.buttonDateFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.buttonDateFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDateFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDateFilter.Location = new System.Drawing.Point(232, 85);
            this.buttonDateFilter.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDateFilter.Name = "buttonDateFilter";
            this.buttonDateFilter.Size = new System.Drawing.Size(59, 17);
            this.buttonDateFilter.TabIndex = 2;
            this.buttonDateFilter.Text = "Filtrele";
            this.buttonDateFilter.UseVisualStyleBackColor = false;
            // 
            // buttonStaffNameFilter
            // 
            this.buttonStaffNameFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.buttonStaffNameFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStaffNameFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonStaffNameFilter.Location = new System.Drawing.Point(137, 37);
            this.buttonStaffNameFilter.Margin = new System.Windows.Forms.Padding(0);
            this.buttonStaffNameFilter.Name = "buttonStaffNameFilter";
            this.buttonStaffNameFilter.Size = new System.Drawing.Size(46, 19);
            this.buttonStaffNameFilter.TabIndex = 2;
            this.buttonStaffNameFilter.Text = "Ara";
            this.buttonStaffNameFilter.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 25);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tarih Aralığına Göre Filtrele ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel Ara";
            // 
            // staffEntryExitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(227)))), ((int)(((byte)(169)))));
            this.ClientSize = new System.Drawing.Size(595, 530);
            this.Controls.Add(this.panelEntryExitOperation);
            this.Controls.Add(this.panelEntryExitTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "staffEntryExitForm";
            this.Text = "staffEntryExitForm";
            this.Load += new System.EventHandler(this.staffEntryExitForm_Load);
            this.panelEntryExitTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelEntryExitOperation.ResumeLayout(false);
            this.panelEntryExitOperation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEntryExitTable;
        private System.Windows.Forms.Panel panelEntryExitOperation;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Button buttonExitFilter;
        private Button button5;
        private Button buttonLeaveFilter;
        private Button buttonEntryFilter;
        private Button buttonDateFilter;
        private Button buttonStaffNameFilter;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Label label1;
        private Label labelKacSaat;
    }
}
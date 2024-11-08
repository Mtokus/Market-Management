namespace Market_Management
{
    partial class staffEntryExitAddForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.pickerStaffEntryTime = new System.Windows.Forms.DateTimePicker();
            this.pickerStaffExitTime = new System.Windows.Forms.DateTimePicker();
            this.btnNewEntryStaff = new System.Windows.Forms.Button();
            this.checkLeaveStatus = new System.Windows.Forms.CheckBox();
            this.comboBoxStaffName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(180, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Adı - Soyadı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giriş Saati";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(180, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Çıkış Saati";
            // 
            // txtStaffID
            // 
            this.txtStaffID.Location = new System.Drawing.Point(95, 52);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(34, 20);
            this.txtStaffID.TabIndex = 1;
            // 
            // pickerStaffEntryTime
            // 
            this.pickerStaffEntryTime.CustomFormat = "HH:mm:ss";
            this.pickerStaffEntryTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pickerStaffEntryTime.Location = new System.Drawing.Point(15, 136);
            this.pickerStaffEntryTime.Name = "pickerStaffEntryTime";
            this.pickerStaffEntryTime.Size = new System.Drawing.Size(114, 20);
            this.pickerStaffEntryTime.TabIndex = 3;
            // 
            // pickerStaffExitTime
            // 
            this.pickerStaffExitTime.CustomFormat = "HH:mm:ss";
            this.pickerStaffExitTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pickerStaffExitTime.Location = new System.Drawing.Point(183, 136);
            this.pickerStaffExitTime.Name = "pickerStaffExitTime";
            this.pickerStaffExitTime.Size = new System.Drawing.Size(113, 20);
            this.pickerStaffExitTime.TabIndex = 3;
            // 
            // btnNewEntryStaff
            // 
            this.btnNewEntryStaff.Location = new System.Drawing.Point(330, 126);
            this.btnNewEntryStaff.Name = "btnNewEntryStaff";
            this.btnNewEntryStaff.Size = new System.Drawing.Size(105, 29);
            this.btnNewEntryStaff.TabIndex = 4;
            this.btnNewEntryStaff.Text = "Kaydet";
            this.btnNewEntryStaff.UseVisualStyleBackColor = true;
            this.btnNewEntryStaff.Click += new System.EventHandler(this.btnNewEntryStaff_Click);
            // 
            // checkLeaveStatus
            // 
            this.checkLeaveStatus.AutoSize = true;
            this.checkLeaveStatus.Location = new System.Drawing.Point(308, 78);
            this.checkLeaveStatus.Name = "checkLeaveStatus";
            this.checkLeaveStatus.Size = new System.Drawing.Size(59, 17);
            this.checkLeaveStatus.TabIndex = 5;
            this.checkLeaveStatus.Text = "İzinli mi";
            this.checkLeaveStatus.UseVisualStyleBackColor = true;
            // 
            // comboBoxStaffName
            // 
            this.comboBoxStaffName.FormattingEnabled = true;
            this.comboBoxStaffName.Location = new System.Drawing.Point(267, 51);
            this.comboBoxStaffName.Name = "comboBoxStaffName";
            this.comboBoxStaffName.Size = new System.Drawing.Size(100, 21);
            this.comboBoxStaffName.TabIndex = 6;
          
            // 
            // staffEntryExitAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(227)))), ((int)(((byte)(169)))));
            this.ClientSize = new System.Drawing.Size(473, 202);
            this.Controls.Add(this.comboBoxStaffName);
            this.Controls.Add(this.checkLeaveStatus);
            this.Controls.Add(this.btnNewEntryStaff);
            this.Controls.Add(this.pickerStaffExitTime);
            this.Controls.Add(this.pickerStaffEntryTime);
            this.Controls.Add(this.txtStaffID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "staffEntryExitAddForm";
            this.Text = "staffEntryExitAddForm";
            this.Load += new System.EventHandler(this.staffEntryExitAddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.DateTimePicker pickerStaffEntryTime;
        private System.Windows.Forms.DateTimePicker pickerStaffExitTime;
        private System.Windows.Forms.Button btnNewEntryStaff;
        private System.Windows.Forms.CheckBox checkLeaveStatus;
        private System.Windows.Forms.ComboBox comboBoxStaffName;
    }
}
namespace Market_Management
{
    partial class staffManagementForm
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
            this.panelStaffEntryExitOperation = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.maas_islemleri = new System.Windows.Forms.Button();
            this.buttonStaffOperation = new System.Windows.Forms.Button();
            this.buttonStaffEntryExit = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelStaffEntryExitOperation
            // 
            this.panelStaffEntryExitOperation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelStaffEntryExitOperation.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStaffEntryExitOperation.Location = new System.Drawing.Point(0, 0);
            this.panelStaffEntryExitOperation.Name = "panelStaffEntryExitOperation";
            this.panelStaffEntryExitOperation.Size = new System.Drawing.Size(795, 530);
            this.panelStaffEntryExitOperation.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(53)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.maas_islemleri);
            this.panel2.Controls.Add(this.buttonStaffOperation);
            this.panel2.Controls.Add(this.buttonStaffEntryExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 530);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(795, 75);
            this.panel2.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(565, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(167, 57);
            this.button4.TabIndex = 0;
            this.button4.Text = "button1";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // maas_islemleri
            // 
            this.maas_islemleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.maas_islemleri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.maas_islemleri.Location = new System.Drawing.Point(392, 5);
            this.maas_islemleri.Name = "maas_islemleri";
            this.maas_islemleri.Size = new System.Drawing.Size(167, 57);
            this.maas_islemleri.TabIndex = 0;
            this.maas_islemleri.Text = "Maaş İşlemleri";
            this.maas_islemleri.UseVisualStyleBackColor = false;
            // 
            // buttonStaffOperation
            // 
            this.buttonStaffOperation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.buttonStaffOperation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStaffOperation.Location = new System.Drawing.Point(219, 5);
            this.buttonStaffOperation.Name = "buttonStaffOperation";
            this.buttonStaffOperation.Size = new System.Drawing.Size(167, 57);
            this.buttonStaffOperation.TabIndex = 0;
            this.buttonStaffOperation.Text = "Personel işlemleri";
            this.buttonStaffOperation.UseVisualStyleBackColor = false;
            this.buttonStaffOperation.Click += new System.EventHandler(this.buttonStaffOperation_Click);
            // 
            // buttonStaffEntryExit
            // 
            this.buttonStaffEntryExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.buttonStaffEntryExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStaffEntryExit.Location = new System.Drawing.Point(46, 5);
            this.buttonStaffEntryExit.Name = "buttonStaffEntryExit";
            this.buttonStaffEntryExit.Size = new System.Drawing.Size(167, 57);
            this.buttonStaffEntryExit.TabIndex = 0;
            this.buttonStaffEntryExit.Text = " Personel \r\nGiriş-Çıkış";
            this.buttonStaffEntryExit.UseVisualStyleBackColor = false;
            this.buttonStaffEntryExit.Click += new System.EventHandler(this.buttonStaffEntryExit_Click);
            // 
            // staffManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 605);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelStaffEntryExitOperation);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "staffManagementForm";
            this.Text = "staffManagementForm";
            this.Load += new System.EventHandler(this.staffManagementForm_Load_1);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelStaffEntryExitOperation;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button maas_islemleri;
        private System.Windows.Forms.Button buttonStaffOperation;
        private System.Windows.Forms.Button buttonStaffEntryExit;
    }
}
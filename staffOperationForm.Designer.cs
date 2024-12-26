namespace Market_Management
{
    partial class staffOperationForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtExtraWorkingHours = new System.Windows.Forms.Label();
            this.txtStaffSalary = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.totalSalaryLabel = new System.Windows.Forms.Label();
            this.overTimeLabel = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.comboBoxMonths = new System.Windows.Forms.ComboBox();
            this.salary_transactions = new System.Windows.Forms.Button();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.buttonCallStaff = new System.Windows.Forms.Button();
            this.comboBoxStaffName = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbStaffPosition = new System.Windows.Forms.ComboBox();
            this.txtStaffIDForUptade = new System.Windows.Forms.TextBox();
            this.buttonListStaff = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.updateStaffButton = new System.Windows.Forms.Button();
            this.addStaffButton = new System.Windows.Forms.Button();
            this.pickerFinish = new System.Windows.Forms.DateTimePicker();
            this.pickerStart = new System.Windows.Forms.DateTimePicker();
            this.chkStaffState = new System.Windows.Forms.CheckBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtHomeAddress = new System.Windows.Forms.TextBox();
            this.txtNameSurname = new System.Windows.Forms.TextBox();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.txtTcNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewStaffTbl = new System.Windows.Forms.DataGridView();
            this.staffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffTCNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffNameSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffPhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffAdress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffPositionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffFinishDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffIsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaffTbl)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1042, 507);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1034, 481);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Giriş-Çıkış";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(227)))), ((int)(((byte)(169)))));
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(227)))), ((int)(((byte)(169)))));
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1034, 481);
            this.splitContainer1.SplitterDistance = 327;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1034, 327);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(227)))), ((int)(((byte)(169)))));
            this.panel1.Controls.Add(this.txtExtraWorkingHours);
            this.panel1.Controls.Add(this.txtStaffSalary);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.totalSalaryLabel);
            this.panel1.Controls.Add(this.overTimeLabel);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.buttonFilter);
            this.panel1.Controls.Add(this.comboBoxMonths);
            this.panel1.Controls.Add(this.salary_transactions);
            this.panel1.Controls.Add(this.txtStaffID);
            this.panel1.Controls.Add(this.buttonCallStaff);
            this.panel1.Controls.Add(this.comboBoxStaffName);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1034, 150);
            this.panel1.TabIndex = 0;
            // 
            // txtExtraWorkingHours
            // 
            this.txtExtraWorkingHours.AutoSize = true;
            this.txtExtraWorkingHours.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtExtraWorkingHours.Location = new System.Drawing.Point(681, 17);
            this.txtExtraWorkingHours.Name = "txtExtraWorkingHours";
            this.txtExtraWorkingHours.Size = new System.Drawing.Size(0, 17);
            this.txtExtraWorkingHours.TabIndex = 11;
            // 
            // txtStaffSalary
            // 
            this.txtStaffSalary.AutoSize = true;
            this.txtStaffSalary.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStaffSalary.Location = new System.Drawing.Point(681, 88);
            this.txtStaffSalary.Name = "txtStaffSalary";
            this.txtStaffSalary.Size = new System.Drawing.Size(0, 17);
            this.txtStaffSalary.TabIndex = 12;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(580, 88);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(95, 17);
            this.label17.TabIndex = 13;
            this.label17.Text = "Toplam Maaş :";
            // 
            // totalSalaryLabel
            // 
            this.totalSalaryLabel.AutoSize = true;
            this.totalSalaryLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.totalSalaryLabel.Location = new System.Drawing.Point(681, 88);
            this.totalSalaryLabel.Name = "totalSalaryLabel";
            this.totalSalaryLabel.Size = new System.Drawing.Size(0, 17);
            this.totalSalaryLabel.TabIndex = 14;
            // 
            // overTimeLabel
            // 
            this.overTimeLabel.AutoSize = true;
            this.overTimeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.overTimeLabel.Location = new System.Drawing.Point(681, 17);
            this.overTimeLabel.Name = "overTimeLabel";
            this.overTimeLabel.Size = new System.Drawing.Size(0, 17);
            this.overTimeLabel.TabIndex = 14;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(544, 17);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(131, 17);
            this.label16.TabIndex = 14;
            this.label16.Text = "Toplam Mesai Saati :";
            // 
            // buttonFilter
            // 
            this.buttonFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.buttonFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFilter.Location = new System.Drawing.Point(379, 15);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(79, 22);
            this.buttonFilter.TabIndex = 2;
            this.buttonFilter.Text = "Filtrele";
            this.buttonFilter.UseVisualStyleBackColor = false;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // comboBoxMonths
            // 
            this.comboBoxMonths.FormattingEnabled = true;
            this.comboBoxMonths.Items.AddRange(new object[] {
            "Ocak",
            "Şubat",
            "Mart",
            "Nisan",
            "Mayıs",
            "Haziran",
            "Temmuz",
            "Ağustos",
            "Eylül",
            "Ekim",
            "Kasım",
            "Aralık"});
            this.comboBoxMonths.Location = new System.Drawing.Point(283, 15);
            this.comboBoxMonths.Name = "comboBoxMonths";
            this.comboBoxMonths.Size = new System.Drawing.Size(90, 21);
            this.comboBoxMonths.TabIndex = 1;
            this.comboBoxMonths.SelectedValueChanged += new System.EventHandler(this.comboBoxMonths_SelectedValueChanged);
            // 
            // salary_transactions
            // 
            this.salary_transactions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.salary_transactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salary_transactions.Location = new System.Drawing.Point(379, 82);
            this.salary_transactions.Name = "salary_transactions";
            this.salary_transactions.Size = new System.Drawing.Size(92, 34);
            this.salary_transactions.TabIndex = 4;
            this.salary_transactions.Text = "Maaş Hesapla";
            this.salary_transactions.UseVisualStyleBackColor = false;
            this.salary_transactions.Click += new System.EventHandler(this.salary_transactions_Click);
            // 
            // txtStaffID
            // 
            this.txtStaffID.Location = new System.Drawing.Point(159, 43);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(34, 20);
            this.txtStaffID.TabIndex = 7;
            this.txtStaffID.Visible = false;
            // 
            // buttonCallStaff
            // 
            this.buttonCallStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.buttonCallStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCallStaff.Location = new System.Drawing.Point(105, 86);
            this.buttonCallStaff.Name = "buttonCallStaff";
            this.buttonCallStaff.Size = new System.Drawing.Size(92, 30);
            this.buttonCallStaff.TabIndex = 3;
            this.buttonCallStaff.Text = "Getir / Listele";
            this.buttonCallStaff.UseVisualStyleBackColor = false;
            this.buttonCallStaff.Click += new System.EventHandler(this.buttonCallStaff_Click);
            // 
            // comboBoxStaffName
            // 
            this.comboBoxStaffName.FormattingEnabled = true;
            this.comboBoxStaffName.Location = new System.Drawing.Point(105, 16);
            this.comboBoxStaffName.Name = "comboBoxStaffName";
            this.comboBoxStaffName.Size = new System.Drawing.Size(88, 21);
            this.comboBoxStaffName.TabIndex = 0;
            this.comboBoxStaffName.SelectedValueChanged += new System.EventHandler(this.comboBoxStaffName_SelectedValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(246, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 17);
            this.label13.TabIndex = 4;
            this.label13.Text = "Ay :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(280, 82);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 34);
            this.label14.TabIndex = 4;
            this.label14.Text = "Seçilen Ay\'a \r\nGöre";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(358, 90);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(15, 17);
            this.label15.TabIndex = 4;
            this.label15.Text = " :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(32, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 17);
            this.label12.TabIndex = 4;
            this.label12.Text = "Personel :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Personel Seç :";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(227)))), ((int)(((byte)(169)))));
            this.tabPage2.Controls.Add(this.splitContainer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1034, 481);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Personeller";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridViewStaffTbl);
            this.splitContainer2.Size = new System.Drawing.Size(1034, 481);
            this.splitContainer2.SplitterDistance = 228;
            this.splitContainer2.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(227)))), ((int)(((byte)(169)))));
            this.panel2.Controls.Add(this.cmbStaffPosition);
            this.panel2.Controls.Add(this.txtStaffIDForUptade);
            this.panel2.Controls.Add(this.buttonListStaff);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.updateStaffButton);
            this.panel2.Controls.Add(this.addStaffButton);
            this.panel2.Controls.Add(this.pickerFinish);
            this.panel2.Controls.Add(this.pickerStart);
            this.panel2.Controls.Add(this.chkStaffState);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.txtSalary);
            this.panel2.Controls.Add(this.txtHomeAddress);
            this.panel2.Controls.Add(this.txtNameSurname);
            this.panel2.Controls.Add(this.txtPhoneNo);
            this.panel2.Controls.Add(this.txtTcNo);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 481);
            this.panel2.TabIndex = 0;
            // 
            // cmbStaffPosition
            // 
            this.cmbStaffPosition.FormattingEnabled = true;
            this.cmbStaffPosition.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbStaffPosition.Location = new System.Drawing.Point(105, 155);
            this.cmbStaffPosition.Name = "cmbStaffPosition";
            this.cmbStaffPosition.Size = new System.Drawing.Size(100, 21);
            this.cmbStaffPosition.TabIndex = 6;
            // 
            // txtStaffIDForUptade
            // 
            this.txtStaffIDForUptade.Location = new System.Drawing.Point(75, 0);
            this.txtStaffIDForUptade.Name = "txtStaffIDForUptade";
            this.txtStaffIDForUptade.Size = new System.Drawing.Size(24, 20);
            this.txtStaffIDForUptade.TabIndex = 5;
            this.txtStaffIDForUptade.Visible = false;
            // 
            // buttonListStaff
            // 
            this.buttonListStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.buttonListStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonListStaff.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonListStaff.Location = new System.Drawing.Point(15, 348);
            this.buttonListStaff.Name = "buttonListStaff";
            this.buttonListStaff.Size = new System.Drawing.Size(192, 31);
            this.buttonListStaff.TabIndex = 12;
            this.buttonListStaff.Text = "Listele";
            this.buttonListStaff.UseVisualStyleBackColor = false;
            this.buttonListStaff.Click += new System.EventHandler(this.buttonListStaff_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(15, 442);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(192, 31);
            this.button3.TabIndex = 15;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // updateStaffButton
            // 
            this.updateStaffButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.updateStaffButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateStaffButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.updateStaffButton.Location = new System.Drawing.Point(134, 385);
            this.updateStaffButton.Name = "updateStaffButton";
            this.updateStaffButton.Size = new System.Drawing.Size(73, 32);
            this.updateStaffButton.TabIndex = 14;
            this.updateStaffButton.Text = "Güncelle";
            this.updateStaffButton.UseVisualStyleBackColor = false;
            this.updateStaffButton.Click += new System.EventHandler(this.updateStaffButton_Click);
            // 
            // addStaffButton
            // 
            this.addStaffButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.addStaffButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addStaffButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addStaffButton.Location = new System.Drawing.Point(15, 385);
            this.addStaffButton.Name = "addStaffButton";
            this.addStaffButton.Size = new System.Drawing.Size(73, 32);
            this.addStaffButton.TabIndex = 13;
            this.addStaffButton.Text = "Ekle";
            this.addStaffButton.UseVisualStyleBackColor = false;
            this.addStaffButton.Click += new System.EventHandler(this.addStaffButton_Click);
            // 
            // pickerFinish
            // 
            this.pickerFinish.Location = new System.Drawing.Point(105, 280);
            this.pickerFinish.Name = "pickerFinish";
            this.pickerFinish.Size = new System.Drawing.Size(100, 20);
            this.pickerFinish.TabIndex = 10;
            // 
            // pickerStart
            // 
            this.pickerStart.Location = new System.Drawing.Point(105, 236);
            this.pickerStart.Name = "pickerStart";
            this.pickerStart.Size = new System.Drawing.Size(100, 20);
            this.pickerStart.TabIndex = 9;
            // 
            // chkStaffState
            // 
            this.chkStaffState.AutoSize = true;
            this.chkStaffState.Location = new System.Drawing.Point(105, 315);
            this.chkStaffState.Name = "chkStaffState";
            this.chkStaffState.Size = new System.Drawing.Size(94, 17);
            this.chkStaffState.TabIndex = 11;
            this.chkStaffState.Text = "Çalışıyor Mu ? ";
            this.chkStaffState.UseVisualStyleBackColor = true;
            this.chkStaffState.CheckStateChanged += new System.EventHandler(this.chkStaffState_CheckStateChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEmail.Location = new System.Drawing.Point(105, 101);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 25);
            this.txtEmail.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPassword.Location = new System.Drawing.Point(105, 209);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 25);
            this.txtPassword.TabIndex = 8;
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSalary.Location = new System.Drawing.Point(105, 182);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(100, 25);
            this.txtSalary.TabIndex = 7;
            this.txtSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTcNo_KeyPress);
            // 
            // txtHomeAddress
            // 
            this.txtHomeAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHomeAddress.Location = new System.Drawing.Point(105, 128);
            this.txtHomeAddress.Name = "txtHomeAddress";
            this.txtHomeAddress.Size = new System.Drawing.Size(100, 25);
            this.txtHomeAddress.TabIndex = 5;
            // 
            // txtNameSurname
            // 
            this.txtNameSurname.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNameSurname.Location = new System.Drawing.Point(105, 47);
            this.txtNameSurname.Name = "txtNameSurname";
            this.txtNameSurname.Size = new System.Drawing.Size(100, 25);
            this.txtNameSurname.TabIndex = 2;
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPhoneNo.Location = new System.Drawing.Point(105, 74);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(100, 25);
            this.txtPhoneNo.TabIndex = 3;
            this.txtPhoneNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTcNo_KeyPress);
            // 
            // txtTcNo
            // 
            this.txtTcNo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTcNo.Location = new System.Drawing.Point(105, 20);
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(100, 25);
            this.txtTcNo.TabIndex = 1;
            this.txtTcNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTcNo_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(12, 280);
            this.label11.Margin = new System.Windows.Forms.Padding(5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Ayrılış Tarihi :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(28, 236);
            this.label10.Margin = new System.Windows.Forms.Padding(5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 34);
            this.label10.TabIndex = 0;
            this.label10.Text = "Başlangıç : \r\n     Tarihi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(58, 212);
            this.label9.Margin = new System.Windows.Forms.Padding(5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Şifre :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(52, 185);
            this.label8.Margin = new System.Windows.Forms.Padding(5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Maaş :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(30, 155);
            this.label7.Margin = new System.Windows.Forms.Padding(5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Pozisyon :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(28, 128);
            this.label6.Margin = new System.Windows.Forms.Padding(5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ev Adresi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(10, 101);
            this.label5.Margin = new System.Windows.Forms.Padding(5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email Adresi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(19, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Telefon No :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(20, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Adı Soyadı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(10, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tc Numarası :";
            // 
            // dataGridViewStaffTbl
            // 
            this.dataGridViewStaffTbl.AllowUserToAddRows = false;
            this.dataGridViewStaffTbl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStaffTbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewStaffTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStaffTbl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffID,
            this.staffTCNumber,
            this.staffNameSurname,
            this.staffPhoneNo,
            this.staffEmail,
            this.staffAdress,
            this.staffPositionID,
            this.staffSalary,
            this.staffPassword,
            this.staffStartDate,
            this.staffFinishDate,
            this.staffIsActive});
            this.dataGridViewStaffTbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStaffTbl.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewStaffTbl.Name = "dataGridViewStaffTbl";
            this.dataGridViewStaffTbl.RowHeadersVisible = false;
            this.dataGridViewStaffTbl.Size = new System.Drawing.Size(802, 481);
            this.dataGridViewStaffTbl.TabIndex = 0;
            this.dataGridViewStaffTbl.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStaffTbl_CellContentDoubleClick);
            // 
            // staffID
            // 
            this.staffID.HeaderText = "personelID";
            this.staffID.Name = "staffID";
            this.staffID.ReadOnly = true;
            this.staffID.Visible = false;
            // 
            // staffTCNumber
            // 
            this.staffTCNumber.FillWeight = 158.7302F;
            this.staffTCNumber.HeaderText = "Tc Numarası";
            this.staffTCNumber.Name = "staffTCNumber";
            this.staffTCNumber.ReadOnly = true;
            // 
            // staffNameSurname
            // 
            this.staffNameSurname.FillWeight = 141.2011F;
            this.staffNameSurname.HeaderText = "Adı Soyadı";
            this.staffNameSurname.Name = "staffNameSurname";
            this.staffNameSurname.ReadOnly = true;
            // 
            // staffPhoneNo
            // 
            this.staffPhoneNo.FillWeight = 126.2014F;
            this.staffPhoneNo.HeaderText = "Telefon No";
            this.staffPhoneNo.Name = "staffPhoneNo";
            this.staffPhoneNo.ReadOnly = true;
            // 
            // staffEmail
            // 
            this.staffEmail.FillWeight = 113.3662F;
            this.staffEmail.HeaderText = "Email";
            this.staffEmail.Name = "staffEmail";
            this.staffEmail.ReadOnly = true;
            // 
            // staffAdress
            // 
            this.staffAdress.FillWeight = 102.3832F;
            this.staffAdress.HeaderText = "Adres";
            this.staffAdress.Name = "staffAdress";
            this.staffAdress.ReadOnly = true;
            // 
            // staffPositionID
            // 
            this.staffPositionID.FillWeight = 92.98495F;
            this.staffPositionID.HeaderText = "Posizyon ID";
            this.staffPositionID.Name = "staffPositionID";
            this.staffPositionID.ReadOnly = true;
            // 
            // staffSalary
            // 
            this.staffSalary.FillWeight = 84.94291F;
            this.staffSalary.HeaderText = "Maaş";
            this.staffSalary.Name = "staffSalary";
            this.staffSalary.ReadOnly = true;
            // 
            // staffPassword
            // 
            this.staffPassword.FillWeight = 78.06133F;
            this.staffPassword.HeaderText = "Şifre";
            this.staffPassword.Name = "staffPassword";
            this.staffPassword.ReadOnly = true;
            // 
            // staffStartDate
            // 
            this.staffStartDate.FillWeight = 72.17274F;
            this.staffStartDate.HeaderText = "Başlangıç Tarihi";
            this.staffStartDate.Name = "staffStartDate";
            this.staffStartDate.ReadOnly = true;
            // 
            // staffFinishDate
            // 
            this.staffFinishDate.FillWeight = 67.1339F;
            this.staffFinishDate.HeaderText = "Bitiş Tarihi";
            this.staffFinishDate.Name = "staffFinishDate";
            this.staffFinishDate.ReadOnly = true;
            // 
            // staffIsActive
            // 
            this.staffIsActive.FillWeight = 62.82215F;
            this.staffIsActive.HeaderText = "Aktif";
            this.staffIsActive.Name = "staffIsActive";
            this.staffIsActive.ReadOnly = true;
            // 
            // staffOperationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(227)))), ((int)(((byte)(169)))));
            this.ClientSize = new System.Drawing.Size(1042, 507);
            this.Controls.Add(this.tabControl1);
            this.Name = "staffOperationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel İşlemleri";
            this.Load += new System.EventHandler(this.staffOperationForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaffTbl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dataGridViewStaffTbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtHomeAddress;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.TextBox txtTcNo;
        private System.Windows.Forms.CheckBox chkStaffState;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtNameSurname;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button updateStaffButton;
        private System.Windows.Forms.Button addStaffButton;
        private System.Windows.Forms.DateTimePicker pickerFinish;
        private System.Windows.Forms.DateTimePicker pickerStart;
        private System.Windows.Forms.Button buttonListStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffTCNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffNameSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffPhoneNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffAdress;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffPositionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffFinishDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn staffIsActive;
        private System.Windows.Forms.TextBox txtStaffIDForUptade;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbStaffPosition;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtExtraWorkingHours;
        private System.Windows.Forms.Label txtStaffSalary;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label totalSalaryLabel;
        private System.Windows.Forms.Label overTimeLabel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.ComboBox comboBoxMonths;
        private System.Windows.Forms.Button salary_transactions;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.Button buttonCallStaff;
        private System.Windows.Forms.ComboBox comboBoxStaffName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
    }
}
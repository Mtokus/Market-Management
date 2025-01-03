﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Management
{
    public partial class staffOperationForm : Form
    {
        public staffOperationForm()
        {
            InitializeComponent();
        }
        ShopManagementEntities dbContex= new ShopManagementEntities();
        private void staffOperationForm_Load(object sender, EventArgs e)
        {
            callStafNameForComboBox();
        }
        private void callStafNameForComboBox()
        {
            var staffName = dbContex.staffTbl.ToList();
            foreach (var staff in staffName)
            {
                comboBoxStaffName.Items.Add(new {
                    Text = staff.staffNameSurname,
                    Value = staff.staffID
                });
            }
            comboBoxStaffName.DisplayMember = "Text";
            comboBoxStaffName.ValueMember = "Value";
            
        }
        private void buttonCallStaff_Click(object sender, EventArgs e)
        {   
            if (comboBoxStaffName.Text=="" ) 
            {
               
            }
            dataGridView1.Rows.Clear(); 
            int staffIDfromTxt = Convert.ToInt32(txtStaffID.Text);
            /* // Seçilen işçinin bilgilerini alıyoruz
             var staffDetails = dbContex.StaffEntryExitTbl.Where(p => p.staffID == staffIDfromTxt).ToList();  
             dataGridView1.DataSource = staffDetails;
           */
            var staffInformation = dbContex.ProcedureStaffEntryExit().Where(p=>p.Personel_ID==staffIDfromTxt)
                .OrderByDescending(pp=>pp.Giriş_Saati)
                .ToList();
          //  dataGridView1.DataSource= staffInformation;
            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("Giriş_Saati", "Giriş Saati");
                dataGridView1.Columns.Add("Çıkış_Saati", "Çıkış Saati");
                dataGridView1.Columns.Add("İşlem_Tarihi", "İşlem Tarihi");
                dataGridView1.Columns.Add("Çalışma_Süresi", "Çalışma Süresi");
                dataGridView1.Columns.Add("İzinli_Mi", "İzinli Mi");
            }
            foreach (var staff in staffInformation)
            {
                int rowIndex = dataGridView1.Rows.Add();

                DateTime entryDateTime = Convert.ToDateTime(staff.Giriş_Saati);
                DateTime exitDateTime = Convert.ToDateTime(staff.Çıkış_Saati);

                if (exitDateTime < entryDateTime)
                {
                    exitDateTime = exitDateTime.AddDays(1);
                }

                TimeSpan diffTime = exitDateTime - entryDateTime;

                dataGridView1.Rows[rowIndex].Cells["Giriş_Saati"].Value = entryDateTime.ToString("HH:mm:ss");
                dataGridView1.Rows[rowIndex].Cells["Çıkış_Saati"].Value = exitDateTime.ToString("HH:mm:ss");
                dataGridView1.Rows[rowIndex].Cells["İşlem_Tarihi"].Value = entryDateTime.ToString("dd/MM/yyyy");
                dataGridView1.Rows[rowIndex].Cells["Çalışma_Süresi"].Value = diffTime.ToString(@"hh\:mm");
                //dataGridView1.Rows[rowIndex].Cells["İzinli_Mi"].Value = staff.İzinli.Value ? "İzinli" : "İzinli Değil";

            }
        }
        private void buttonListStaff_Click(object sender, EventArgs e)
        {
            CallStaffList();
        }
        private void comboBoxStaffName_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxStaffName.SelectedItem != null)
            {
                var selectedStaffName = (dynamic)comboBoxStaffName.SelectedItem;
                txtStaffID.Text = selectedStaffName.Value.ToString();
            }
            clearLabels();
        }
        private void dataGridViewStaffTbl_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewStaffTbl.Rows[e.RowIndex];

                txtStaffIDForUptade.Text = row.Cells["staffID"].Value?.ToString();
                txtTcNo.Text = row.Cells["staffTCNumber"].Value?.ToString();
                txtNameSurname.Text = row.Cells["staffNameSurname"].Value?.ToString();
                txtPhoneNo.Text = row.Cells["staffPhoneNo"].Value?.ToString();
                txtEmail.Text = row.Cells["staffEmail"].Value?.ToString();
                txtHomeAddress.Text = row.Cells["staffAdress"].Value?.ToString();
                cmbStaffPosition.Text = row.Cells["staffPositionID"].Value?.ToString();
                txtSalary.Text = row.Cells["staffSalary"].Value?.ToString();
                txtPassword.Text = row.Cells["staffPassword"].Value?.ToString();
                pickerStart.Text = row.Cells["staffStartDate"].Value?.ToString();
                pickerFinish.Text = row.Cells["staffFinishDate"].Value?.ToString();
                // staffIsActive. = row.Cells["staffIsActive"].Value;
            }
        }
        private void salary_transactions_Click(object sender, EventArgs e)
        {
            salaryTransactions();
        }
        private void salaryTransactions()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int staffIDFromTxt = Convert.ToInt32(txtStaffID.Text);
                var choosedStaff = dbContex.staffTbl.FirstOrDefault(c => c.staffID == staffIDFromTxt);
                if (choosedStaff != null && choosedStaff.staffSalary.HasValue)
                {
                    int staffHourlyPay = choosedStaff.staffSalary.Value / 180;
                    TimeSpan totalExtraWorkingHours = TimeSpan.Zero;
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        TimeSpan normalWorkingHours = new TimeSpan(8,30, 0);
                        if (dataGridView1.Rows[i].Cells["Çalışma_Süresi"].Value != null)
                        {
                            TimeSpan workingHours;
                            if (TimeSpan.TryParse(dataGridView1.Rows[i].Cells["Çalışma_Süresi"].Value.ToString(), out workingHours))
                            {
                                if (workingHours > normalWorkingHours)
                                {
                                    TimeSpan extraWorkingHours = workingHours - normalWorkingHours;
                                    totalExtraWorkingHours += extraWorkingHours;
                                }
                            }
                        }
                    }
                    overTimeLabel.Text = totalExtraWorkingHours.ToString(@"hh\:mm");
                    // MessageBox.Show("Toplam fazla çalışma süresi: " + totalExtraWorkingHours.ToString(@"hh\:mm"));
                    double totalExtraHoursDecimal = totalExtraWorkingHours.TotalHours;
                    double totalExtraPay = totalExtraHoursDecimal * staffHourlyPay * 1.5;
                    int totalStandardPay = (dataGridView1.Rows.Count * 8) * staffHourlyPay;
                    double totalStaffSalary = totalStandardPay + totalExtraPay;
                    totalSalaryLabel.Text = totalStaffSalary.ToString("C2");
                    //MessageBox.Show("Toplam maaş: " + totalStaffSalary.ToString("C2"));
                }
                else
                {
                    MessageBox.Show("Geçerli bir personel bulunamadı veya maaş bilgisi eksik.");
                }
            }
        }
        private void buttonFilter_Click(object sender, EventArgs e)
        {
            
            dataGridView1.Rows.Clear();

            if (string.IsNullOrEmpty(txtStaffID.Text))
            {
                MessageBox.Show("Lütfen Personel Seçiniz");
                return;
            }

            if (string.IsNullOrEmpty(comboBoxMonths.Text))
            {
                MessageBox.Show("Lütfen Ay Seçiniz");
                return;
            }

            int selectedMonth = comboBoxMonths.SelectedIndex + 1;
            int selectedYear = DateTime.Today.Year;

            if (selectedMonth > DateTime.Today.Month)
            {
                selectedYear -= 1;
            }

            DateTime startDatetime = new DateTime(selectedYear, selectedMonth, 1);
            DateTime endDatetime = startDatetime.AddMonths(1).AddDays(-1);

            using (var dbContext = new ShopManagementEntities())
            {
                int staffID = Convert.ToInt32(txtStaffID.Text);

                var girisCikislar = dbContext.StaffEntryExitTbl
                    .Where(c => c.staffID == staffID
                                && c.entryDateTime >= startDatetime
                                && c.entryDateTime <= endDatetime)
                    .ToList();

                if (dataGridView1.Columns.Count == 0)
                {
                    dataGridView1.Columns.Add("Giriş_Saati", "Giriş Saati");
                    dataGridView1.Columns.Add("Çıkış_Saati", "Çıkış Saati");
                    dataGridView1.Columns.Add("İşlem_Tarihi", "İşlem Tarihi");
                    dataGridView1.Columns.Add("Çalışma_Süresi", "Çalışma Süresi");
                }
                foreach (var entryExit in girisCikislar)
                {
                    int rowIndex = dataGridView1.Rows.Add();

                    DateTime entryDateTime = entryExit.entryDateTime ?? DateTime.MinValue;
                    DateTime exitDateTime = entryExit.exitDateTime ?? DateTime.MinValue;

                    if (exitDateTime < entryDateTime)
                    {
                        exitDateTime = exitDateTime.AddDays(1);
                    }

                    TimeSpan diffTime = exitDateTime - entryDateTime;

                    dataGridView1.Rows[rowIndex].Cells["Giriş_Saati"].Value = entryDateTime.ToString("HH:mm:ss");
                    dataGridView1.Rows[rowIndex].Cells["Çıkış_Saati"].Value = exitDateTime.ToString("HH:mm:ss");
                    dataGridView1.Rows[rowIndex].Cells["İşlem_Tarihi"].Value = entryDateTime.ToString("dd/MM/yyyy");
                    dataGridView1.Rows[rowIndex].Cells["Çalışma_Süresi"].Value = diffTime.ToString(@"hh\:mm");
                }
            }
        

            /*
            dataGridView1.Rows.Clear();
            DateTime stardDatetime = DateTime.MinValue;
            DateTime endDatetime = DateTime.MinValue;
            if (comboBoxMonths.SelectedIndex != null)
            {
                int selectedMonth = comboBoxMonths.SelectedIndex + 1;
                int selectedYear = DateTime.Today.Year;
                if (selectedMonth > DateTime.Today.Year)
                {
                    selectedYear -= 1;
                }
                stardDatetime = new DateTime(selectedYear, selectedMonth, 1);
                endDatetime = stardDatetime.AddMonths(1).AddDays(-1);
            }
            else { }

            using (var dbContext = new ShopManagementEntities())
            {
                int _staffID = Convert.ToInt32(txtStaffID.Text);
                var girisCikislar = dbContex.StaffEntryExitTbl
                    .Where(c => c.staffID == _staffID
                                && c.entryDateTime >= stardDatetime
                                && c.entryDateTime <= endDatetime
                           )
                    .ToList();

              
                if (dataGridView1.Columns.Count == 0)
                {
                    dataGridView1.Columns.Add("Giriş_Saati", "Giriş Saati");
                    dataGridView1.Columns.Add("Çıkış_Saati", "Çıkış Saati");
                    dataGridView1.Columns.Add("İşlem_Tarihi", "İşlem Tarihi");
                    dataGridView1.Columns.Add("Çalışma_Süresi", "Çalışma Süresi");
                   // dataGridView1.Columns.Add("İzinli_Mi", "İzinli Mi");
                }
                foreach (var staff in girisCikislar)
                {
                    int rowIndex = dataGridView1.Rows.Add();

                    DateTime entryDateTime = Convert.ToDateTime(staff.entryDateTime);
                    DateTime exitDateTime = Convert.ToDateTime(staff.exitDateTime);

                    if (exitDateTime < entryDateTime)
                    {
                        exitDateTime = exitDateTime.AddDays(1);
                    }

                    TimeSpan diffTime = exitDateTime - entryDateTime;

                    dataGridView1.Rows[rowIndex].Cells["Giriş_Saati"].Value = entryDateTime.ToString("HH:mm:ss");
                    dataGridView1.Rows[rowIndex].Cells["Çıkış_Saati"].Value = exitDateTime.ToString("HH:mm:ss");
                    dataGridView1.Rows[rowIndex].Cells["İşlem_Tarihi"].Value = entryDateTime.ToString("dd/MM/yyyy");
                    dataGridView1.Rows[rowIndex].Cells["Çalışma_Süresi"].Value = diffTime.ToString(@"hh\:mm");
                   // dataGridView1.Rows[rowIndex].Cells["İzinli_Mi"].Value = staff.leaveStatus.Value ? "İzinli" : "İzinli Değil";

                }
            }
            */
        }
        private void addStaffButton_Click(object sender, EventArgs e)
        {
            var addNewStaff = new staffTbl
            {
                staffTCNumber = txtTcNo.Text.ToString(),
                staffNameSurname = txtNameSurname.Text.ToString(),
                staffPhoneNo = txtPhoneNo.Text.ToString(),
                staffEmail = txtEmail.Text.ToString(),
                staffAdress = txtHomeAddress.Text.ToString(),
                staffPositionID = Convert.ToInt32(cmbStaffPosition.Text),
                staffSalary = Convert.ToInt32(txtSalary.Text),
                staffPassword = txtPassword.Text.ToString(),
                staffStartDate = pickerStart.Value,
                staffFinishDate =null,
                staffIsActive = true,
            };
            dbContex.staffTbl.Add(addNewStaff);
            dbContex.SaveChanges();
            MessageBox.Show("Başarıyla Eklendi !");
            CallStaffList();
        }
        private void updateStaffButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtStaffIDForUptade.Text);

            var update = dbContex.staffTbl.FirstOrDefault(s => s.staffID == id);
            if (update != null)
            {
                update.staffTCNumber = txtTcNo.Text.ToString();
                update.staffNameSurname = txtNameSurname.Text.ToString();
                update.staffPhoneNo = txtPhoneNo.Text.ToString();
                update.staffEmail = txtEmail.Text.ToString();
                update.staffAdress = txtHomeAddress.Text.ToString();
                update.staffPositionID = Convert.ToInt32(cmbStaffPosition.Text);
                update.staffSalary = Convert.ToInt32(txtSalary.Text);
                update.staffPassword = txtPassword.Text.ToString();
                update.staffStartDate = pickerStart.Value;
                update.staffIsActive = chkStaffState.Checked;

                if (chkStaffState.Checked) 
                {
                    update.staffFinishDate = null;  
                }
                else 
                {
                    update.staffFinishDate = pickerFinish.Value;  
                }

                dbContex.SaveChanges();
                MessageBox.Show("Personel bilgileri başarıyla güncellendi.");
            }
            else
            {
                MessageBox.Show("Personel bulunamadı.");
            }
        }
        private void CallStaffList()
        {
            dataGridView1.Rows.Clear();
            var staffName = dbContex.staffTbl.ToList();
            foreach (var staff in staffName)
            {
                int rowIndex = dataGridViewStaffTbl.Rows.Add();
                dataGridViewStaffTbl.Rows[rowIndex].Cells["staffID"].Value = staff.staffID.ToString();
                dataGridViewStaffTbl.Rows[rowIndex].Cells["staffTCNumber"].Value = staff.staffTCNumber.ToString();
                dataGridViewStaffTbl.Rows[rowIndex].Cells["staffNameSurname"].Value = staff.staffNameSurname.ToString();
                dataGridViewStaffTbl.Rows[rowIndex].Cells["staffPhoneNo"].Value = staff.staffPhoneNo.ToString();
                dataGridViewStaffTbl.Rows[rowIndex].Cells["staffEmail"].Value = staff.staffEmail.ToString();
                dataGridViewStaffTbl.Rows[rowIndex].Cells["staffAdress"].Value = staff.staffAdress.ToString();
                dataGridViewStaffTbl.Rows[rowIndex].Cells["staffPositionID"].Value = staff.staffPositionID.ToString();
                dataGridViewStaffTbl.Rows[rowIndex].Cells["staffSalary"].Value = staff.staffSalary.ToString();
                dataGridViewStaffTbl.Rows[rowIndex].Cells["staffPassword"].Value = staff.staffPassword.ToString();
                dataGridViewStaffTbl.Rows[rowIndex].Cells["staffStartDate"].Value = staff.staffStartDate.ToString();
                dataGridViewStaffTbl.Rows[rowIndex].Cells["staffFinishDate"].Value = staff.staffFinishDate.ToString();
                dataGridViewStaffTbl.Rows[rowIndex].Cells["staffIsActive"].Value = staff.staffIsActive.Value;
            }


        }
        private void chkStaffState_CheckStateChanged(object sender, EventArgs e)
        {
            pickerFinish.Enabled = chkStaffState.Checked ? false : true;
        }

        private void comboBoxMonths_SelectedValueChanged(object sender, EventArgs e)
        {
            clearLabels();
        }
        private void clearLabels() 
        {
            overTimeLabel.Text = string.Empty;
            totalSalaryLabel.Text = string.Empty;
        }

        private void txtTcNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

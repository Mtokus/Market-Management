using Market_Management.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Management
{
    public partial class staffEntryExitForm : Form
    {
        public staffEntryExitForm()
        {
            InitializeComponent();
        }

        private void staffEntryExitForm_Load(object sender, EventArgs e)
        {
            CallStaffEntry();
        }

        ShopManagementEntities dbContex = new ShopManagementEntities();
        void CallStaffEntry()
        {
            #region yol1
            /*
            var staffEntries = dbContex.StaffEntryExitTbl
                    .Include(se => se.staffTbl) // staffTbl'den personel bilgilerini ekler
                    .Select(se => new
                    {
                        
                        StaffName = se.staffTbl.staffNameSurname, // Personel adı
                        ExitTime = se.exitDateTime.HasValue ? se.exitDateTime.ToString() : "Henüz Henüz yapılmadı",
                        EntryTime = se.entryDateTime.HasValue ? se.entryDateTime.Value.ToString() : "Henüz çıkış yapılmadı" // Eğer null ise mesaj göster
                    })
                    .ToList();

            // Verileri DataGridView ya da başka bir kontrol ile gösterebilirsiniz
            dataGridView1.DataSource = staffEntries;
            */
            #endregion
            #region yol2
            /*dataGridView1.DataSource = dbContex.ProcedureStaffEntryExit().OrderByDescending(c=>c.Giriş_Saati).ToList();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[2].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm:ss"; // Giriş saati
            dataGridView1.Columns[3].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm:ss"; // Çıkış saati
            */

            #endregion
            var staffEntryExit = dbContex.ProcedureStaffEntryExit().OrderByDescending(c=>c.Giriş_Saati). ToList();

            DatagridClass.StaffEntryExitGridview(dataGridView1, staffEntryExit);

        }
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CalculateWorkingHours();
            
        }
        private void CalculateWorkingHours() 
        { int rowCount= dataGridView1.Rows.Count;

            for (int rowIndex=0; rowIndex < rowCount; rowIndex ++)
            {
                DateTime entryDateTime =Convert.ToDateTime(dataGridView1.Rows[rowIndex].Cells["Giriş_Saati"].Value);
                DateTime exitDatetime =Convert.ToDateTime(dataGridView1.Rows[rowIndex].Cells["Çıkış_Saati"].Value) ;
                TimeSpan diffTime = exitDatetime - entryDateTime;
            }
            
        }
        private void button5_Click(object sender, EventArgs e)
        {
            staffEntryExitAddForm staffEntryExitAddForm = new staffEntryExitAddForm();
            staffEntryExitAddForm.ShowDialog();
        }

        private void personelSearchTxt_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            if (personelSearchTxt.Text.Length > 0)
            {
                string staffName = personelSearchTxt.Text.ToLower().ToUpper();
                var staffNameFiltered = dbContex.ProcedureStaffEntryExit().Where(o => o.Ad_Soyad.ToLower().ToUpper().Contains(staffName)).ToList();

                DatagridClass.StaffEntryExitGridview(dataGridView1, staffNameFiltered);
            }
        }

        private void buttonDateFilter_Click(object sender, EventArgs e)
        {
            DateTime startDate = this.pickerStart.Value.Date;
            DateTime endDate = this.pickerFinish.Value.Date.AddDays(1.0).AddTicks(-1L);
            using (ShopManagementEntities context = new ShopManagementEntities())
            {
                List<ProcedureStaffEntryExit_Result> filteredRecords = (from r in context.ProcedureStaffEntryExit()
                                                                        where r.Giriş_Saati >= startDate && r.Çıkış_Saati <= endDate
                                                                        select r).ToList<ProcedureStaffEntryExit_Result>();
                DatagridClass.StaffEntryExitGridview(this.dataGridView1, filteredRecords);
            }
        }
        
    }
}
//public Nullable<System.DateTime> Giriş_Saati { get; set; }
//public Nullable<System.DateTime> Çıkış_Saati { get; set; }
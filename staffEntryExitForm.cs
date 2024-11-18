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

            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("Ad_Soyad", "Personal Adı");
                dataGridView1.Columns.Add("Giriş_Saati", "Giriş Saati");
                dataGridView1.Columns.Add("Çıkış_Saati", "Çıkış Saati");
                dataGridView1.Columns.Add("İşlem_Tarihi", "İşlem Tarihi");
                dataGridView1.Columns.Add("Çalışma_Süresi", "Çalışma Süresi");
            }

            foreach (var item in staffEntryExit)
            {
                int rowIndex = dataGridView1.Rows.Add();

                DateTime entryDateTime = Convert.ToDateTime(item.Giriş_Saati);
                DateTime exitDateTime = Convert.ToDateTime(item.Çıkış_Saati);

                if (exitDateTime < entryDateTime)
                {
                    exitDateTime = exitDateTime.AddDays(1);
                }

                TimeSpan diffTime = exitDateTime - entryDateTime;

                dataGridView1.Rows[rowIndex].Cells["Ad_Soyad"].Value = item.Ad_Soyad.ToString();
                dataGridView1.Rows[rowIndex].Cells["Giriş_Saati"].Value = entryDateTime.ToString("HH:mm:ss");
                dataGridView1.Rows[rowIndex].Cells["Çıkış_Saati"].Value = exitDateTime.ToString("HH:mm:ss");
                dataGridView1.Rows[rowIndex].Cells["İşlem_Tarihi"].Value = entryDateTime.ToString("dd/MM/yyyy");
                dataGridView1.Rows[rowIndex].Cells["Çalışma_Süresi"].Value = diffTime.ToString(@"hh\:mm\:ss");
            }

        }
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CalculateWorkingHours();
            
        }
        private void CalculateWorkingHours() 
        { int rowCount= dataGridView1.Rows.Count;

            for (int rowIndex=0; rowIndex < rowCount; rowIndex ++)
            {
                DateTime entryDateTime = Convert.ToDateTime(dataGridView1.Rows[rowIndex].Cells["Giriş_Saati"].Value);
                DateTime exitDatetime =Convert.ToDateTime(dataGridView1.Rows[rowIndex].Cells["Çıkış_Saati"].Value) ;
                TimeSpan diffTime = exitDatetime - entryDateTime;
            }
            
        }
        private void button5_Click(object sender, EventArgs e)
        {
            staffEntryExitAddForm staffEntryExitAddForm = new staffEntryExitAddForm();
            staffEntryExitAddForm.ShowDialog();
        }
    }
}
//public Nullable<System.DateTime> Giriş_Saati { get; set; }
//public Nullable<System.DateTime> Çıkış_Saati { get; set; }
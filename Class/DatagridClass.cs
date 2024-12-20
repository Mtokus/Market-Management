using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Management.Class
{
    internal class DatagridClass
    {
        public static void StaffEntryExitGridview(DataGridView dgv, IEnumerable<dynamic> staffNameFiltered)
        {
            dgv.Rows.Clear();
            if (dgv.Columns.Count == 0)
            {
                dgv.Columns.Add("Ad_Soyad", "Personel Adı");
                dgv.Columns.Add("Giriş_Saati", "Giriş Saati");
                dgv.Columns.Add("Çıkış_Saati", "Çıkış Saati");
                dgv.Columns.Add("İşlem_Tarihi", "İşlem Tarihi");
                dgv.Columns.Add("Çalışma_Süresi", "Çalışma Süresi");
            }

            foreach (var item in staffNameFiltered)
            {
                if (item.Giriş_Saati == null || item.Çıkış_Saati == null)
                {
                    continue; // Geçersiz veriyi atla
                }

                int rowIndex = dgv.Rows.Add();

                DateTime entryDateTime = Convert.ToDateTime(item.Giriş_Saati);
                DateTime exitDateTime = Convert.ToDateTime(item.Çıkış_Saati);

                if (exitDateTime < entryDateTime)
                {
                    exitDateTime = exitDateTime.AddDays(1); // Gece vardiyası durumu
                }

                TimeSpan diffTime = exitDateTime - entryDateTime;

                dgv.Rows[rowIndex].Cells["Ad_Soyad"].Value = item.Ad_Soyad;
                dgv.Rows[rowIndex].Cells["Giriş_Saati"].Value = entryDateTime.ToString("HH:mm:ss");
                dgv.Rows[rowIndex].Cells["Çıkış_Saati"].Value = exitDateTime.ToString("HH:mm:ss");
                dgv.Rows[rowIndex].Cells["İşlem_Tarihi"].Value = entryDateTime.ToString("dd/MM/yyyy");
                dgv.Rows[rowIndex].Cells["Çalışma_Süresi"].Value = diffTime.ToString(@"hh\:mm\:ss");
            }
        }
        public static void ReceiptGridList(DataGridView dgv, IEnumerable<dynamic> items)
        {
            dgv.Columns.Clear();

            // Eğer items boşsa, "Fiş bulunamadı" mesajını göster
            if (items == null || !items.Any())
            {
                MessageBox.Show("Fiş bulunamadı.");
                return;
            }

            // DataGridView kolonlarını oluştur
            dgv.Columns.Add("receiptID", "Fiş ID");
            dgv.Columns.Add("receiptFormationDate", "Fiş Tarihi");
            dgv.Columns.Add("receiptTotalKDV", "Toplam KDV");
            dgv.Columns.Add("receiptTotalPrice", "Toplam Fiyat");
            dgv.Columns.Add("receiptPaymentType", "Ödeme Şekli");

            // Gelen item'ları DataGridView'e ekle
            foreach (var item in items)
            {
                int rowCount = dgv.Rows.Add();
                dgv.Rows[rowCount].Cells["receiptID"].Value = item.receiptID.ToString();
                dgv.Rows[rowCount].Cells["receiptFormationDate"].Value = item.receiptFormationDate?.ToString("dd/MM/yyyy");
                dgv.Rows[rowCount].Cells["receiptTotalKDV"].Value = item.receiptTotalKDV.ToString();
                dgv.Rows[rowCount].Cells["receiptTotalPrice"].Value = item.receiptTotalPrice?.ToString("C2");
                dgv.Rows[rowCount].Cells["receiptPaymentType"].Value = item.receiptPaymentType.ToString();
            }
        }

    }
}

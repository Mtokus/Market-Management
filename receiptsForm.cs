using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Management
{
    public partial class receiptsForm : Form
    {
        public receiptsForm()
        {
            InitializeComponent();
        }
        ShopManagementEntities dbContex= new ShopManagementEntities();
        private void buttonSearchReceipt_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtReceiptID.Text))
            {
                int id = Convert.ToInt32(txtReceiptID.Text);
                var receipt = dbContex.receiptDetailTbl
                    .Where(p => p.receiptID == id)
                    .Include(p => p.receiptTbl)
                    .Include(p => p.productTbl)
                    .Select(p => new
                    {
                        p.receiptID,
                        ReceiptDate = p.receiptTbl.receiptFormationDate,
                        ProductName = p.productTbl.productName,
                        ProductPrice = p.productTbl.productPrice,
                        Quantity = p.productQuantity
                    })
                    .ToList();

                if (receipt.Any())
                {
                    dataGridView1.Columns.Clear();
                    dataGridView1.Columns.Add("productName", "Ürün Adı");
                    dataGridView1.Columns.Add("productPrice", "Ürün Fiyatı");
                    dataGridView1.Columns.Add("productQuantity", "Ürün miktarı");

                    foreach (var item in receipt)
                    {
                        int rowIndex = dataGridView1.Rows.Add();
                        dataGridView1.Rows[rowIndex].Cells["productName"].Value = item.ProductName;
                        dataGridView1.Rows[rowIndex].Cells["productPrice"].Value = item.ProductPrice?.ToString("C2");
                        dataGridView1.Rows[rowIndex].Cells["productQuantity"].Value = item.Quantity.ToString();
                    }

                    var receiptInformation = dbContex.receiptTbl.FirstOrDefault(p => p.receiptID == id);
                    if (receiptInformation != null)
                    {
                        dataGridView2.Columns.Clear();
                        dataGridView2.Columns.Add("receiptID", "Fiş ID");
                        dataGridView2.Columns.Add("receiptFormationDate", "Fiş Tarihi");
                        dataGridView2.Columns.Add("receiptTotalKDV", "Toplam KDV");
                        dataGridView2.Columns.Add("receiptTotalPrice", "Toplam Fiyat");
                        dataGridView2.Columns.Add("receiptPaymentType", "Ödeme Şekli");

                        // Yeni bir satır ekleyin
                        int rowCount = dataGridView2.Rows.Add();

                        // Hücrelere değer atayın
                        dataGridView2.Rows[rowCount].Cells["receiptID"].Value = receiptInformation.receiptID.ToString();
                        dataGridView2.Rows[rowCount].Cells["receiptFormationDate"].Value = receiptInformation.receiptFormationDate?.ToString("dd/MM/yyyy");
                        dataGridView2.Rows[rowCount].Cells["receiptTotalKDV"].Value = receiptInformation.receiptTotalKDV.ToString();
                        dataGridView2.Rows[rowCount].Cells["receiptTotalPrice"].Value = receiptInformation.receiptTotalPrice?.ToString("C2");
                        dataGridView2.Rows[rowCount].Cells["receiptPaymentType"].Value = receiptInformation.receiptPaymentType.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Ürün bulunamadı");
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli fiş numarası giriniz!");
            }
        }

    }
}

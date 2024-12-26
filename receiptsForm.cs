using Market_Management.Class;
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



        private void confirmReturnButton_Click(object sender, EventArgs e)
        {
            Button b = sender as Button; 
            int receiptID;

            if (b != null && int.TryParse(txtReceiptID.Text, out receiptID)) 
            {
                if (UserClass.UserLevel == 1 || UserClass.UserLevel == 2)
                {
                    
                    productReturnForm returnForm = new productReturnForm();
                    returnForm.productIDLabel.Text = receiptID.ToString(); 
                    returnForm.ShowDialog(); 
                }
                else
                {
                    MessageBox.Show("Bu işlemi yapmaya yetkiniz yok!", "Yetki Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir Fiş ID giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void allReceiptListButton_Click(object sender, EventArgs e)
        {
            receiptListCall();
        }

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
                    // DataGridView1 için kolon ekleme
                    dataGridView1.Columns.Clear();
                    dataGridView1.Columns.Add("productName", "Ürün Adı");
                    dataGridView1.Columns.Add("productPrice", "Ürün Fiyatı");
                    dataGridView1.Columns.Add("productQuantity", "Ürün Miktarı");

                    // İade için Checkbox kolonu ekleme
                    DataGridViewCheckBoxColumn returnColumn = new DataGridViewCheckBoxColumn
                    {
                        Name = "productReturn",
                        HeaderText = "İade",
                        Width = 50
                    };
                    dataGridView1.Columns.Add(returnColumn);

                    foreach (var item in receipt)
                    {
                        int rowIndex = dataGridView1.Rows.Add();
                        dataGridView1.Rows[rowIndex].Cells["productName"].Value = item.ProductName;
                        dataGridView1.Rows[rowIndex].Cells["productPrice"].Value = item.ProductPrice?.ToString("C2");
                        dataGridView1.Rows[rowIndex].Cells["productQuantity"].Value = item.Quantity.ToString();
                    }

                    // Fiş bilgilerini al ve DataGridView2'yi doldur
                    var receiptInformation = dbContex.receiptTbl
                        .Where(p => p.receiptID == id)
                        .Select(r => new
                        {
                            r.receiptID,
                            r.receiptFormationDate,
                            r.receiptTotalKDV,
                            r.receiptTotalPrice,
                            r.receiptPaymentType
                        })
                        .ToList();

                    DatagridClass.ReceiptGridList(dataGridView2, receiptInformation);
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

        private void receiptsForm_Load(object sender, EventArgs e)
        {
            receiptListCall();
        }
        private void receiptListCall() 
        {
            var receiptList = dbContex.receiptTbl
                .OrderByDescending(r => r.receiptFormationDate)
                .Take(10)
                .Select(r => new
                {
                    r.receiptID,
                    r.receiptFormationDate,
                    r.receiptTotalKDV,
                    r.receiptTotalPrice,
                    r.receiptPaymentType
                })
                .ToList();
            DatagridClass.ReceiptGridList(dataGridView2, receiptList);
        }

        private void txtReceiptID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /*  private void returnProductFormButton_Click(object sender, EventArgs e)
{
 Button b = sender as Button; // Butona tıklanıldığını al
 int receiptID;

 if (b != null && int.TryParse(txtReceiptID.Text, out receiptID)) // Fiş ID geçerli mi kontrol et
 {
     if (UserClass.UserLevel == 1 || UserClass.UserLevel == 2)
     {
         // Yeni formu oluştur ve ID'yi Label'e yazdır
         productReturnForm returnForm = new productReturnForm();
         returnForm.productIDLabel.Text = receiptID.ToString(); // Fiş ID'yi yeni formdaki label'e yaz
         returnForm.ShowDialog(); // Formu aç
     }
     else
     {
         MessageBox.Show("Bu işlemi yapmaya yetkiniz yok!", "Yetki Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
     }
 }
 else
 {
     MessageBox.Show("Lütfen geçerli bir Fiş ID giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
 }
}*/
    }
}

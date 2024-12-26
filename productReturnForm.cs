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
    public partial class productReturnForm : Form
    {
        public productReturnForm()
        {
            InitializeComponent();
        }
        ShopManagementEntities dbContex = new ShopManagementEntities();
        private void productReturnForm_Load(object sender, EventArgs e)
        {
            CallReceipt();
        }
        
        
        private void CallReceipt()
        {
            int receiptId = Convert.ToInt32(productIDLabel.Text);
            var receiptDetails = dbContex.receiptDetailTbl
                .Where(p => p.receiptID == receiptId)
                .Include(p => p.receiptTbl)
                .Include(p => p.productTbl)
                .Select(p => new
                {
                    ReceiptID = p.receiptID,
                    ReceiptDate = p.receiptTbl.receiptFormationDate,
                    ProductName = p.productTbl.productName,
                    ProductPrice = p.productTbl.productPrice,
                    Quantity = p.productQuantity
                }).ToList();

            if (!receiptDetails.Any()) return;

            
            InitializeDataGridViewColumns();

            foreach (var detail in receiptDetails)
            {
                int rowIndex = dataGridView1.Rows.Add();
                dataGridView1.Rows[rowIndex].Cells["productName"].Value = detail.ProductName;
                dataGridView1.Rows[rowIndex].Cells["productPrice"].Value = detail.ProductPrice?.ToString("C2");
                dataGridView1.Rows[rowIndex].Cells["productQuantity"].Value = detail.Quantity.ToString();
            }
        }

        private void InitializeDataGridViewColumns()
            {
                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add("productName", "Ürün Adı");
                dataGridView1.Columns.Add("productPrice", "Ürün Fiyatı");
                dataGridView1.Columns.Add("productQuantity", "Ürün Miktarı");

                var returnColumn = new DataGridViewCheckBoxColumn
                {
                    Name = "productReturn",
                    HeaderText = "İade",
                    Width = 50
                };
                dataGridView1.Columns.Add(returnColumn);
            }
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                selectedRowIndex = e.RowIndex;
                if (selectedRowIndex < 0 || dataGridView1.Rows[selectedRowIndex].Cells["productName"].Value == null) return;

                productNameTxt.Text = dataGridView1.Rows[selectedRowIndex].Cells["productName"].Value.ToString();
                productQuantityTxt.Text = dataGridView1.Rows[selectedRowIndex].Cells["productQuantity"].Value.ToString();
            }
        
        private int selectedRowIndex = -1;

        private void addSingleButton_Click(object sender, EventArgs e)
        {
            string productName = productNameTxt.Text;

            
            int productQuantity;
            bool isValidQuantity = int.TryParse(productQuantityTxt.Text, out productQuantity);
            selectedRowIndex = dataGridView1.CurrentRow.Index;
            if (!isValidQuantity || productQuantity <= 0)
            {
                MessageBox.Show("Lütfen geçerli bir miktar giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selectedRowIndex >= 0 && dataGridView1.Rows[selectedRowIndex].Cells["productQuantity"].Value != null)
            {
                int availableQuantity = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["productQuantity"].Value);

                if (productQuantity > 0 && productQuantity <= availableQuantity)
                {
                    
                    int rowIndex = dataGridView2.Rows.Add();
                    dataGridView2.Rows[rowIndex].Cells["productName"].Value = productName;
                    dataGridView2.Rows[rowIndex].Cells["productQuantity"].Value = productQuantity;
                    dataGridView1.Rows[selectedRowIndex].Cells["productQuantity"].Value = availableQuantity - productQuantity;

                    ClearTextBox();
                }
                else
                {
                    MessageBox.Show("Girilen miktar mevcut stoktan fazla olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir ürün seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClearTextBox()
        {
            productNameTxt.Text=string.Empty;
            productQuantityTxt.Text=string.Empty;
        }

        private void addSelectedButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["productReturn"] is DataGridViewCheckBoxCell checkBox && Convert.ToBoolean(checkBox.Value))
                {
                    int newRow = dataGridView2.Rows.Add();
                    dataGridView2.Rows[newRow].Cells["productName"].Value = row.Cells["productName"].Value;
                    dataGridView2.Rows[newRow].Cells["productQuantity"].Value = row.Cells["productQuantity"].Value;
                }
            }
            MessageBox.Show("Seçili ürünler eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void addAllButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                
                if (!row.IsNewRow)
                {
                    string productName = row.Cells["productName"].Value?.ToString();
                    int productQuantity = Convert.ToInt32(row.Cells["productQuantity"].Value);

                    
                    int rowIndex = dataGridView2.Rows.Add();
                    dataGridView2.Rows[rowIndex].Cells["productName"].Value = productName;
                    dataGridView2.Rows[rowIndex].Cells["productQuantity"].Value = productQuantity;
                }
            }

            MessageBox.Show("Tüm ürünler eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void confirmReturnButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bu iade işlemini onaylıyor musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                double totalRefundAmount = 0;

                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (row.IsNewRow) continue; 

                    string productName = row.Cells["productName"].Value?.ToString();
                    int quantity = Convert.ToInt32(row.Cells["productQuantity"].Value);

                    var product = dbContex.productTbl
                        .FirstOrDefault(p => p.productName == productName);

                    if (product != null)
                    {
                        product.productStockQuantity += quantity;

                        double productPrice = product.productPrice ?? 0;

                        double refundAmount = productPrice * quantity;
                        totalRefundAmount += refundAmount;
                        dbContex.SaveChanges();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show($"Ürün '{productName}' bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                MessageBox.Show($"İade edilecek toplam tutar: {totalRefundAmount:C2}", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("İade işlemi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dataGridView2.Rows.Clear();
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex == 2 && e.RowIndex >= 0)
            {
                
                string productName = dataGridView2.Rows[e.RowIndex].Cells["productName"].Value?.ToString();
                int returnQuantity = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["productQuantity"].Value);

                
                DialogResult result = MessageBox.Show(
                    $"{productName} ürününün iadesini iptal etmek istediğinize emin misiniz?",
                    "İade İptal Onayı",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells["productName"].Value?.ToString() == productName)
                        {
                            int currentQuantity = Convert.ToInt32(row.Cells["productQuantity"].Value);
                            row.Cells["productQuantity"].Value = currentQuantity + returnQuantity;
                            break;
                        }
                    }
                    dataGridView2.Rows.RemoveAt(e.RowIndex);

                    MessageBox.Show(
                        $"{productName} ürününün iadesi iptal edildi ve miktar geri eklendi!",
                        "İade İptal",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
        }

       private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            
            if (rowIndex >= 0 && rowIndex < dataGridView1.Rows.Count)
            {
                if (dataGridView1.Rows[rowIndex].Cells["productName"].Value != null)
                {
                    productNameTxt.Text = dataGridView1.Rows[rowIndex].Cells["productName"].Value.ToString();
                    //txtProductPrice.Text = dataGridView1.Rows[rowIndex].Cells["productPrice"].Value.ToString();
                    productQuantityTxt.Text = dataGridView1.Rows[rowIndex].Cells["productQuantity"].Value.ToString();
                }
            }
            else
            {
                MessageBox.Show("Geçersiz satır seçimi!");
            }

        }

        private void productQuantityTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08 && e.KeyChar != (char)44 && e.KeyChar != (char)45)
            {
                e.Handled = true;
            }
        }
    }

}


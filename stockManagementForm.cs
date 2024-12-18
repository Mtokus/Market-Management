﻿using System;
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
    public partial class stockManagementForm : Form
    {
    public stockManagementForm()
        {
            InitializeComponent();
        }
        ShopManagementEntities dbContex = new ShopManagementEntities();

        private void stockManagementForm_Load(object sender, EventArgs e)
        {
            CallStockTable();
            CallSuppliersForCombobox();
            CallProductGroupForCombobox();

        }

        void CallStockTable()
        {
            var products = dbContex.productProcedure().ToList(); 

            foreach (var product in products)
            {
                int rowIndex = dataGridView1.Rows.Add();
                dataGridView1.Rows[rowIndex].Cells["productID"].Value=product.productID.ToString();
                dataGridView1.Rows[rowIndex].Cells["productName"].Value = product.productName.ToString();
                dataGridView1.Rows[rowIndex].Cells["productPrice"].Value = product.productPrice.ToString();
                dataGridView1.Rows[rowIndex].Cells["productBarcode"].Value = product.productBarcode.ToString();
                dataGridView1.Rows[rowIndex].Cells["productKDVRate"].Value = product.productKDVRate.ToString();
                dataGridView1.Rows[rowIndex].Cells["productStockQuantity"].Value = product.productStockQuantity.ToString();
                dataGridView1.Rows[rowIndex].Cells["supplierName"].Value = product.supplierName ?? "Tedarikçi Yok";
                dataGridView1.Rows[rowIndex].Cells["productGroupName"].Value = product.productGroupName ?? "Grup Adı Yok";
            }
        }

        void CallProductDetailTable(object sender, DataGridViewCellEventArgs e)
        {
            #region Tedarikçi yok hatası

            /* DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
             var id = Convert.ToInt32(selectedRow.Cells["productID"].Value);

             // Ürünün detaylarını getiriyoruz
             var productDetail = dbContex.productProcedure().Where(p => p.productID == id).ToList();

             // 8. kolona tıklanmışsa ve ürün detayları varsa
             if (e.ColumnIndex == 8)
             {
                 if (productDetail.Any() && productDetail[0].supplierName != null) 
                 {
                     // DataGridView'i temizleyip yeni kolonları ekliyoruz
                     dataGridView1.Columns.Clear();
                     dataGridView1.Columns.Add("productName", "Ürün Adı");
                     dataGridView1.Columns.Add("supplierName", "Tedarikçi Adı");
                     dataGridView1.Columns.Add("supplierPhoneNumber", "Tedarikçi NO");
                     dataGridView1.Columns.Add("productGroupName", "Ürün Grubu");

                     // Ürün detaylarını DataGridView'e ekliyoruz
                     foreach (var product in productDetail)
                     {
                         int rowIndex = dataGridView1.Rows.Add();
                         dataGridView1.Rows[rowIndex].Cells["productName"].Value = product.productName.ToString();
                         dataGridView1.Rows[rowIndex].Cells["supplierName"].Value = product.supplierName.ToString();
                         dataGridView1.Rows[rowIndex].Cells["supplierPhoneNumber"].Value = product.supplierPhoneNumber.ToString();
                         dataGridView1.Rows[rowIndex].Cells["productGroupName"].Value = product.productGroupName.ToString();
                     }
                 }
                 else
                 {
                     // Tedarikçi firması yoksa tabloyu açma, sadece mesaj göster
                     MessageBox.Show("Tedarikçi Firma bulunmuyor");
                 }



             }
             */
            #endregion


            DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
            var id = Convert.ToInt32(selectedRow.Cells["productID"].Value);

            var productDetail = dbContex.productProcedure().Where(p => p.productID == id).ToList();
            if (dataGridView1.Columns.Count ==9) 
            
            {
                if (e.ColumnIndex == 8)
                {
                    if (productDetail.Any())
                    {

                        dataGridView1.Columns.Clear();
                        dataGridView1.Columns.Add("productName", "Ürün Adı");
                        dataGridView1.Columns.Add("supplierName", "Tedarikçi Adı");
                        dataGridView1.Columns.Add("supplierPhoneNumber", "Tedarikçi NO");
                        dataGridView1.Columns.Add("productGroupName", "Ürün Grubu");
                        dataGridView1.Columns.Add("backProducts", "Ürünlere Dön");

                        foreach (var product in productDetail)
                        {
                            int rowIndex = dataGridView1.Rows.Add();
                            dataGridView1.Rows[rowIndex].Cells["productName"].Value = product.productName.ToString();
                            dataGridView1.Rows[rowIndex].Cells["supplierName"].Value = product.supplierName?.ToString() ?? "Tedarikçi Yok";
                            dataGridView1.Rows[rowIndex].Cells["supplierPhoneNumber"].Value = product.supplierPhoneNumber?.ToString() ?? "Telefon Numarası Yok";
                            dataGridView1.Rows[rowIndex].Cells["productGroupName"].Value = product.productGroupName?.ToString() ?? "Grup Adı Yok";
                            dataGridView1.Rows[rowIndex].Cells["backProducts"].Value = "Ürünlere Dön";


                        }
                    }
                    else
                    {
                        MessageBox.Show("Tedarikçi Firma bulunmuyor");
                    }
                }
                else
                {
                    var updateProduct = dbContex.productProcedure().Where(w => w.productID == id).FirstOrDefault();



                    productIDTxt.Text = updateProduct.productID.ToString();
                    productNameTxt.Text = updateProduct.productName.ToString();
                    productPriceTxt.Text = updateProduct.productPrice.ToString();
                    productBarcodeTxt.Text = updateProduct.productBarcode.ToString();
                    productKdvRateTxt.Text = updateProduct.productKDVRate.ToString();
                    productStockQuantityTxt.Text = updateProduct.productStockQuantity.ToString();
                    comboBoxSupplierForInventory.Text = updateProduct.supplierName?.ToString();
                    comboBoxProductGroupForInventory.Text = updateProduct.productGroupName?.ToString();
                    //  supplierIDTxt.Text= updateProduct.supp

                }

            }
            else if (dataGridView1.Columns.Count == 6 ) 
            {
                if (e.ColumnIndex == 5) 
                {
                    CallStockTable();
                }

            }
            else {
                MessageBox.Show("Kolon sayısı yanlış");
                    
                    }
            
        }
       
        private void btnSupplierAdd_Click(object sender, EventArgs e)
        {
            supplierTbl addNewSupplier= new supplierTbl();
            addNewSupplier.supplierName=txtSupplierName.Text;   
            addNewSupplier.supplierPhoneNumber= txtSupplierPhoneNumber.Text;
            addNewSupplier.supplierIBAN=txtSupplierIbanNo.Text;
            addNewSupplier.supplierEmail= txtSupplierEmail.Text;
            addNewSupplier.supplierAddress= txtSupplierAddress.Text;
            dbContex.supplierTbl.Add(addNewSupplier);
            dbContex.SaveChanges();
            MessageBox.Show("Eklendi!");
            ClearTxtSuppliers();
        }

        private void ClearTxtProducts()
        {
            productNameTxt.Text = "";
            productPriceTxt.Text = "";
            productBarcodeTxt.Text = "";
            productKdvRateTxt.Text = "";
            productStockQuantityTxt.Text = "";
            comboBoxProductGroupForInventory.Text = "";
            comboBoxSupplierForInventory.Text = "";
        }

        private void ClearTxtSuppliers()
        {
            txtSupplierName.Text = "";
            txtSupplierPhoneNumber.Text = "";
            txtSupplierEmail.Text = "";
            txtSupplierIbanNo.Text = "";
            txtSupplierAddress.Text = "";


        }

        private void CallSuppliersForCombobox()
        {
            var suppliers = dbContex.supplierTbl.ToList();
            foreach (var supplier in suppliers) 
            {
                comboBoxSupplierForInventory.Items.Add(new
                {
                    Text = supplier.supplierName,
                    Value=supplier.supplierID
                });
            }
            comboBoxSupplierForInventory.DisplayMember = "Text";
            comboBoxSupplierForInventory.ValueMember = "Value";
        }

        private void CallProductGroupForCombobox()
        {
            var productGroup = dbContex.productGroupTbl.ToList();
            foreach (var group in productGroup)
            {
                comboBoxProductGroupForInventory.Items.Add(new
                {
                    Text = group.productGroupName,
                    Value = group.productGroupID
                });

            }
            comboBoxProductGroupForInventory.DisplayMember = "Text";
            comboBoxProductGroupForInventory.ValueMember = "Value";
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void comboBoxSupplierForInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSupplierForInventory.SelectedItem != null)
            {
                var selectedSupplier = (dynamic)comboBoxSupplierForInventory.SelectedItem;
                supplierIDTxt.Text = selectedSupplier.Value.ToString();
            }
        }

        private void comboBoxProductGroupForInventory_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBoxProductGroupForInventory.SelectedItem != null)
            {
                var selectedProductGroup = (dynamic)comboBoxProductGroupForInventory.SelectedItem;
                productGroupIDTxt.Text = selectedProductGroup.Value.ToString();
            }
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CallProductDetailTable(sender, e);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var textboxes = new List<TextBox> { productNameTxt, productPriceTxt, productBarcodeTxt, productKdvRateTxt, productStockQuantityTxt, supplierIDTxt, productGroupIDTxt };

            if (textboxes.Any(tb => string.IsNullOrWhiteSpace(tb.Text)))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string newProductBarcode = productBarcodeTxt.Text;
                var existingProductBarcode = dbContex.productTbl.FirstOrDefault(a => a.productBarcode == newProductBarcode);

                if (existingProductBarcode == null)
                {
                    // Ürün mevcut değil, yeni ürün ekle
                    productTbl addProduct = new productTbl
                    {
                        productName = productNameTxt.Text,
                        productPrice = Convert.ToDouble(productPriceTxt.Text),
                        productBarcode = productBarcodeTxt.Text,
                        productKDVRate = Convert.ToDouble(productKdvRateTxt.Text),
                        productStockQuantity = Convert.ToInt32(productStockQuantityTxt.Text)
                    };

                    dbContex.productTbl.Add(addProduct);
                    dbContex.SaveChanges();
                    int newProductID = addProduct.productID;
                    productDetailTbl addNewProductDetail = new productDetailTbl
                    {
                        productID = newProductID,
                        supplierID = Convert.ToInt32(supplierIDTxt.Text),
                        productGroupID = Convert.ToInt32(productGroupIDTxt.Text)
                    };

                    dbContex.productDetailTbl.Add(addNewProductDetail);
                    dbContex.SaveChanges();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Bu ürün mevcut, stoğa eklemek ister misiniz ?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        existingProductBarcode.productStockQuantity += Convert.ToInt32(productStockQuantityTxt.Text);
                        dbContex.SaveChanges();
                    }
                }
                dataGridView1.Rows.Clear();
                CallStockTable();
                ClearTxtProducts();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Hatalı veri girişi: " + ex.Message, "Format Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(productIDTxt.Text);
                var product = dbContex.productTbl.Find(id);

                if (product == null)
                {
                    MessageBox.Show("Ürün bulunamadı!");
                    return;
                }
                // productTbl güncelle
                product.productName = productNameTxt.Text;
                product.productPrice = double.TryParse(productPriceTxt.Text, out double price) ? price : 0;
                product.productBarcode = productBarcodeTxt.Text;
                product.productKDVRate = double.TryParse(productKdvRateTxt.Text, out double kdvRate) ? kdvRate : 0;
                product.productStockQuantity = double.TryParse(productStockQuantityTxt.Text, out double stockQty) ? stockQty : 0;

                // productDetailTbl güncelle yoksa oluştur
                var productDetail = dbContex.productDetailTbl.FirstOrDefault(p => p.productID == id);

                if (productDetail == null)
                {
                    // productDetail kaydı oluştur
                    productDetail = new productDetailTbl
                    {
                        productID = id,
                        supplierID = int.TryParse(supplierIDTxt.Text, out int supplierID) ? supplierID : 0,
                        productGroupID = int.TryParse(productGroupIDTxt.Text, out int productGroupID) ? productGroupID : 0,
                        productPurchaseDate = dateTimePicker1.Value,
                        productDescription = productDescriptionTxt.Text
                    };
                    dbContex.productDetailTbl.Add(productDetail); 
                }
                else
                {
                    
                    productDetail.supplierID = int.TryParse(supplierIDTxt.Text, out int supplierID) ? supplierID : 0;
                    productDetail.productGroupID = int.TryParse(productGroupIDTxt.Text, out int productGroupID) ? productGroupID : 0;
                    productDetail.productPurchaseDate = dateTimePicker1.Value;
                    productDetail.productDescription = productDescriptionTxt.Text;

                    // Entity Framework'e güncellemeyi bildir
                    dbContex.Entry(productDetail).State = EntityState.Modified;
                }

                int changes = dbContex.SaveChanges();

                if (changes > 0)
                {
                    MessageBox.Show("Ürün ve detayları başarıyla güncellendi.");
                }
                else
                {
                    MessageBox.Show("Değişiklikler kaydedilmedi.");
                }
                dataGridView1.Rows.Clear();
                CallStockTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(productIDTxt.Text);
                var product = dbContex.productTbl.Find(id);
                if (product == null)
                {
                    MessageBox.Show("Silinecek ürün bulunamadı!");
                    return;
                }
                var productDetail = dbContex.productDetailTbl.FirstOrDefault(p => p.productID == id);
                if (productDetail != null)
                {
                    dbContex.productDetailTbl.Remove(productDetail);
                }
                dbContex.productTbl.Remove(product);
                dbContex.SaveChanges();
                MessageBox.Show("Ürün başarıyla silindi.");
                dataGridView1.Rows.Clear();
                CallStockTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        private void supplierListButton_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

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
            dataGridView1.Columns.Clear();
			dataGridView1.Columns.Add("productID", "Ürün NO");
			dataGridView1.Columns.Add("productName", "Ürün Adı");
			dataGridView1.Columns.Add("productPrice", "Birim Fiyatı");
			dataGridView1.Columns.Add("productBarcode", "BARKOD");
			dataGridView1.Columns.Add("productKDVRate", "Kdv Oranı");
			dataGridView1.Columns.Add("productStockQuantity", "Stok Miktarı");
			dataGridView1.Columns.Add("supplierName", "Tedarikçi Firma");
			dataGridView1.Columns.Add("productGroupName", "Ürün Grup");
			dataGridView1.Columns.Add("productDetail", "Ürün Detayı");
			List<productProcedure_Result> products = dbContex.productProcedure().ToList<productProcedure_Result>();
			foreach (productProcedure_Result product in products)
			{
				dataGridView1.Rows.Add(new object[]
				{
					product.productID,
					product.productName,
					product.productPrice,
					product.productBarcode,
					product.productKDVRate,
					product.productStockQuantity,
					product.supplierName,
					product.productGroupName
				});
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



            if (dataGridView1.Columns[0].Name == "productID")
            {
                var id = Convert.ToInt32(selectedRow.Cells["productID"].Value);
                var productDetail = dbContex.productProcedure().Where(p => p.productID == id).ToList();

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
                    fillTextboxProducts( id);
                }

            }
            else if (dataGridView1.Columns[0].Name == "productName")
            {
                
                if (e.ColumnIndex == 4) 
                {
                    CallStockTable();
                }
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

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {

            this.dataGridView1.Rows.Clear();
            bool flag = this.txtFilter.Text.Length > 0;
            if (flag)
            {
                string productname = this.txtFilter.Text.ToLower();
                List<productProcedure_Result> productfiltered = (from o in this.dbContex.productProcedure()
                                                                 where o.productName.ToLower().Contains(productname)
                                                                 select o).ToList<productProcedure_Result>();
                foreach (productProcedure_Result product in productfiltered)
                {
                    this.dataGridView1.Rows.Add(new object[]
                    {
                        product.productID,
                        product.productName,
                        product.productPrice,
                        product.productBarcode,
                        product.productKDVRate,
                        product.productStockQuantity,
                        product.supplierName,
                        product.productGroupName
                    });
                }
            }
            else
            {
                this.dataGridView1.Rows.Clear();
                this.CallStockTable();
                this.CallSuppliersForCombobox();
                this.CallProductGroupForCombobox();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = this.tabControl1.SelectedIndex;
            int num = selectedIndex;
            if (num != 0)
            {
                if (num != 1)
                {
                    dataGridView1.Rows.Clear();
                }
                else
                {
                    SupplierListCall();
                }
            }
            else
            {
                CallStockTable();
                CallSuppliersForCombobox();
                CallProductGroupForCombobox();
            }
        }

        private void SupplierListCall()
        {
            this.dataGridView1.Columns.Clear();
            this.dataGridView1.Columns.Add("supplierID", "Tedarikçi NO");
            this.dataGridView1.Columns.Add("supplierName", "Tedarikçi adı");
            this.dataGridView1.Columns.Add("supplierPhoneNumber", "Telefon Numarası");
            this.dataGridView1.Columns.Add("supplierIBAN", "Tedarikçi IBAN");
            this.dataGridView1.Columns.Add("supplierEmail", "E-Mail");
            this.dataGridView1.Columns.Add("supplierAdress", "Adres");
            List<supplierTbl> supliers = this.dbContex.supplierTbl.ToList<supplierTbl>();
            foreach (supplierTbl supplier in supliers)
            {
                this.dataGridView1.Rows.Add(new object[]
                {   supplier.supplierID,
                    supplier.supplierName,
                    supplier.supplierPhoneNumber,
                    supplier.supplierIBAN,
                    supplier.supplierEmail,
                    supplier.supplierAddress
                });
            }
        }

        private void supplierListButton_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Clear();
            this.SupplierListCall();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[0].Name == "supplierID")
            {
                int id =Convert.ToInt32( dataGridView1.CurrentRow.Cells["supplierID"].Value?.ToString());
                fillTextboxSuppliers( id);
            }
            else
            {

                CallProductDetailTable(sender, e);
            }
        }

        private void fillTextboxSuppliers( int id )
        {
            var updateSupplier = dbContex.supplierTbl.Where(w => w.supplierID == id).FirstOrDefault();
            if (updateSupplier != null)
            {
                supplierIDLabel.Text = updateSupplier.supplierID.ToString();
                txtSupplierName.Text = updateSupplier.supplierName;
                txtSupplierPhoneNumber.Text = updateSupplier.supplierPhoneNumber;
                txtSupplierIbanNo.Text = updateSupplier.supplierIBAN;
                txtSupplierEmail.Text = updateSupplier.supplierEmail;
                txtSupplierAddress.Text = updateSupplier.supplierAddress;
            }
            else 
            {
                MessageBox.Show("Tedarikçi Bulunamadı");
            }
        }

        private void fillTextboxProducts( int id )
        {
            var updateProduct = dbContex.productProcedure().Where(w => w.productID == id).FirstOrDefault();
            if (updateProduct != null)
            {
                productIDTxt.Text = updateProduct.productID.ToString();
                productNameTxt.Text = updateProduct.productName.ToString();
                productPriceTxt.Text = updateProduct.productPrice.ToString();
                productBarcodeTxt.Text = updateProduct.productBarcode.ToString();
                productKdvRateTxt.Text = updateProduct.productKDVRate.ToString();
                productStockQuantityTxt.Text = updateProduct.productStockQuantity.ToString();
                comboBoxSupplierForInventory.Text = updateProduct.supplierName?.ToString();
                comboBoxProductGroupForInventory.Text = updateProduct.productGroupName?.ToString();
            }
            else 
            {
                MessageBox.Show("Ürün Bulunamadı");
            }
        }

        private void clearSupplierTextboxButton_Click(object sender, EventArgs e)
        {
            clearSupplierTextboxes();
        }

        private void clearSupplierTextboxes()
        {
            supplierIDLabel.Text = string.Empty;
            txtSupplierName.Text = string.Empty;
            txtSupplierPhoneNumber.Text = string.Empty;
            txtSupplierIbanNo.Text = string.Empty;
            txtSupplierEmail.Text = string.Empty;
            txtSupplierAddress.Text = string.Empty;
        }

        private void clearProductTextboxButton_Click(object sender, EventArgs e)
        {
            clearProductTextboxes();
        }

        private void clearProductTextboxes()
        {
            productIDTxt.Text = string.Empty;
            productNameTxt.Text = string.Empty;
            productPriceTxt.Text = string.Empty;
            productBarcodeTxt.Text = string.Empty;
            productKdvRateTxt.Text = string.Empty;
            productStockQuantityTxt.Text = string.Empty;
            comboBoxSupplierForInventory.Text = string.Empty;
            comboBoxProductGroupForInventory.Text = string.Empty;
        }

        private void updateSupplierButton_Click(object sender, EventArgs e)
        {
            
            var result = MessageBox.Show(
                "Bu tedarikçi bilgilerini güncellemek istediğinize emin misiniz?",
                "Güncelleme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes) 
            {
                try
                {
                    int id = Convert.ToInt32(supplierIDLabel.Text);
                    var supplier = dbContex.supplierTbl.Find(id);
                    if (supplier != null)
                    {
                        supplier.supplierName = txtSupplierName.Text;
                        supplier.supplierPhoneNumber = txtSupplierPhoneNumber.Text;
                        supplier.supplierIBAN = txtSupplierIbanNo.Text;
                        supplier.supplierEmail = txtSupplierEmail.Text;
                        supplier.supplierAddress = txtSupplierAddress.Text;

                        dbContex.Entry(supplier).State = EntityState.Modified;
                        dbContex.SaveChanges();
                        MessageBox.Show("Tedarikçi başarıyla güncellendi.");
                        SupplierListCall();
                    }
                    else
                    {
                        MessageBox.Show("Tedarikçi bulunamadı.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Güncelleme işlemi iptal edildi.");
            }
        }

        private void deleteSupplierButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Bu tedarikçiyi silmek istediğinize emin misiniz?",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes) 
            {
                int id = Convert.ToInt32(supplierIDLabel.Text);
                var supplier = dbContex.supplierTbl.Find(id);
                if (supplier != null)
                {
                    supplier.supplierName = txtSupplierName.Text;
                    supplier.supplierPhoneNumber = txtSupplierPhoneNumber.Text;
                    supplier.supplierIBAN = txtSupplierIbanNo.Text;
                    supplier.supplierEmail = txtSupplierEmail.Text;
                    supplier.supplierAddress = txtSupplierAddress.Text;
                    dbContex.supplierTbl.Remove(supplier);
                    dbContex.SaveChanges();
                    MessageBox.Show("Tedarikçi Silindi");

                    SupplierListCall();
                }
                else
                {
                    MessageBox.Show("Tedarikçi Bulunamadı");
                }
            }
            else
            {
                MessageBox.Show("Silme işlemi iptal edildi.");
            }
        }

    }


}

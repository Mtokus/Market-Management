using Market_Management.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Management
{
    public partial class cashRegisterForm : Form
    {
        public cashRegisterForm()
        {
            InitializeComponent();
            labelUserNameOperationPanel.Text = UserClass.FullName;
        }
        ShopManagementEntities dbContex = new ShopManagementEntities();

        private void picClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void SetOperationLabel(string labelText, bool showQuantityControls = false, string quantityLabelText = "")
        {
            calculateOperationLabel.Text = labelText;
            calculateNumberTxt.Text = string.Empty;

            quantityLabel.Visible = showQuantityControls;
            quantityTxt.Visible = showQuantityControls;

            if (showQuantityControls)
            {
                quantityLabel.Text = quantityLabelText;
            }
        }
        private void QuantityCalcToFalse()
        {
            quantityLabel.Visible = false;
            quantityTxt.Visible = false;
        }
        private void quantityChoiceButton_Click(object sender, EventArgs e)
        {
            SetOperationLabel("İade :");
        }
        private void barcodeChoiceButton_Click(object sender, EventArgs e)
        {
            SetOperationLabel("Barkod :", true, "Miktar :");
        }
        //oto barkod oluşturma
        /* private void weighingOptionButton_Click(object sender, EventArgs e)
         {
             SetOperationLabel("Ürün Kodu :", true,"Kg :");


         }
        */
        private void customerPayButton_Click(object sender, EventArgs e)
        {
            SetOperationLabel("Ödeme :");
        }
        /*#region Clicks
        private void quantityChoiceButton_Click(object sender, EventArgs e)
        {
            calculateOperationLabel.Text = "İade :".ToString();
            QuantityCalcToFalse();
        }
        private void barcodeChoiceButton_Click(object sender, EventArgs e)
        {
            calculateOperationLabel.Text = "Barkod :".ToString();
            quantityLabel.Visible = true;
            quantityTxt.Visible = true;

        }
        private void weighingOptionButton_Click(object sender, EventArgs e)
        {
            calculateOperationLabel.Text = "Ürün Giriniz :".ToString();
            QuantityCalcToFalse();
        }
        private void customerPayButton_Click(object sender, EventArgs e)
        {
            calculateOperationLabel.Text = "Ödeme :".ToString();
            QuantityCalcToFalse();
        }
        #endregion
        */
        //İşlem butonu 
        private void takeActionButton_Click(object sender, EventArgs e)
        {
            if (calculateOperationLabel.Text == "İade :")
            {
                if (calculateNumberTxt.Text != "")
                {

                }
                else { MessageBox.Show("Adet girmediniz"); }
            }
            if (calculateOperationLabel.Text == "Barkod :")
            {
                if (calculateNumberTxt.Text != "")
                {
                    string barcode = calculateNumberTxt.Text.Trim();
                    if (barcode.Length <= 2)
                    {
                        MessageBox.Show("Eksik");
                    }
                    else if (dbContex.productTbl.Any(a => a.productBarcode == barcode))
                    {
                        var product = dbContex.productTbl.Where(w => w.productBarcode == barcode).FirstOrDefault();

                        bool haveProduct = false;
                        int rowIndex = dataGridView1.Rows.Count;
                        if (rowIndex > 0)
                        {
                            for (int i = 0; i < rowIndex; i++)
                            {

                                if (dataGridView1.Rows[i].Cells["productBarcode"].Value != null &&
                                    dataGridView1.Rows[i].Cells["productBarcode"].Value.ToString() == barcode)
                                {
                                    double availableQuantity = Convert.ToDouble(dataGridView1.Rows[i].Cells["productQuantity"].Value);
                                    dataGridView1.Rows[i].Cells["productQuantity"].Value = availableQuantity + Convert.ToDouble(quantityTxt.Text);

                                    // Toplam fiyatı tekrar hesapla
                                    double totalPrice = (product.productKDVRate.Value) * (product.productPrice.Value) * (Convert.ToDouble(dataGridView1.Rows[i].Cells["productQuantity"].Value));
                                    dataGridView1.Rows[i].Cells["productTotalPrice"].Value = totalPrice;

                                    haveProduct = true;
                                    break;
                                }
                            }
                        }

                        if (!haveProduct)
                        {
                            int newRow = dataGridView1.Rows.Add();
                            dataGridView1.Rows[newRow].Cells["productID"].Value = product.productID.ToString();
                            dataGridView1.Rows[newRow].Cells["productBarcode"].Value = product.productBarcode.ToString();
                            dataGridView1.Rows[newRow].Cells["productName"].Value = product.productName.ToString();
                            dataGridView1.Rows[newRow].Cells["productQuantityPrice"].Value = product.productPrice?.ToString();
                            dataGridView1.Rows[newRow].Cells["productQuantity"].Value = quantityTxt.Text;
                            dataGridView1.Rows[newRow].Cells["productKDVRate"].Value = product.productKDVRate.ToString();
                            double totalPrice = (product.productKDVRate.Value) * (product.productPrice.Value) * (Convert.ToDouble(dataGridView1.Rows[newRow].Cells["productQuantity"].Value));
                            dataGridView1.Rows[newRow].Cells["productTotalPrice"].Value = totalPrice;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Barkod girmediniz");
                }
            }
            //oto barkod oluşturma
            /*
             if (calculateOperationLabel.Text == "Ürün Kodu :")
            {
                if (calculateNumberTxt.Text != "")
                {
                    
                }
                else { MessageBox.Show("Ürün girmediniz"); }
            }
            */
            if (calculateOperationLabel.Text == "Ödeme :")
            {
                customerPayLabel.Text = calculateNumberTxt.Text;
                ChangeMoneyCalculate();
                calculateNumberTxt.Text = "";
            };

            //Swich Case
            /* switch (calculateOperationLabel.Text)
             {
                 case "Adet Giriniz :":
                     MessageBox.Show("Adet girmediniz");
                     break;
                 case "Barkod Giriniz :":
                     MessageBox.Show("Barkod girmediniz");
                     break;
                 case "Ürün Giriniz :":
                     MessageBox.Show("Ürün girmediniz");
                     break;
                 case "Alınan Ödeme :":
                     MessageBox.Show("Ödeme girmediniz");
                     break;
                 default:
                     break;
             }
            */
        }
        private void ChangeMoneyCalculate()
        {
            try
            {
                double cashChange = Convert.ToDouble(customerPayLabel.Text) - Convert.ToDouble(totalPriceLabel.Text);
                cashChangeLabel.Text = cashChange.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Lütfen geçerli bir ödeme giriniz." + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            /* if (calculateNumberTxt.Text != "")
             {
                 string price = totalPriceLabel.Text;

                 if (double.TryParse(price, NumberStyles.Currency, CultureInfo.CurrentCulture, out double numericValue))
                 {


                     double changeMoney = Convert.ToDouble(calculateNumberTxt.Text) - numericValue;
                     customerPayLabel.Text = Convert.ToDouble(calculateNumberTxt.Text).ToString("C2");
                     cashChangeLabel.Text = changeMoney.ToString("C2");
                     calculateNumberTxt.Text = "";

                 }
             }
             else { MessageBox.Show("Ödeme girmediniz"); }
            */
        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                TotalPrice();
                TotalKDV();
                if (customerPayLabel.Text != "0")
                {
                    ChangeMoneyCalculate();
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= dataGridView1.Columns["deleteProduct"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Ürünü silmek istediğinizden emin misiniz? ", "Silme Onayı", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                    TotalPrice();
                    TotalKDV();
                }
            }
        }
        private void CalculatorNumbersButton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == ",")
            {
                if (string.IsNullOrEmpty(calculateNumberTxt.Text))
                {
                    return;
                }
                int point = calculateNumberTxt.Text.Count(p => p == ',');
                if (point < 1)
                {
                    calculateNumberTxt.Text += b.Text;
                }
            }
            else if (b.Text == "C")
            {
                if (calculateNumberTxt.Text.Length > 0)
                {
                    calculateNumberTxt.Text = calculateNumberTxt.Text.Substring(0, calculateNumberTxt.Text.Length - 1);
                }
            }
            else
            {
                calculateNumberTxt.Text += b.Text;
            }
        }
        private void cashButton_Click(object sender, EventArgs e)
        {
            double totalprice = Convert.ToDouble(totalPriceLabel.Text);
            double customerpay = Convert.ToDouble(customerPayLabel.Text);

            if (customerPayLabel.Text == "0" || string.IsNullOrWhiteSpace(customerPayLabel.Text))
            {
                MessageBox.Show("Lütfen Ödeme Giriniz");
            }
            else if (totalprice < customerpay)
            {
                confirmSale("Cash");
            }
            else
            {
                double cashchange = Convert.ToDouble(cashChangeLabel.Text);
                cashchange = Math.Abs(cashchange);
                MessageBox.Show($"Lütfen {(cashchange.ToString("C2"))} ekleyiniz"); ;
            }
        }
        private void cardButton_Click(object sender, EventArgs e)
        {
            confirmSale("Card");

        }
        private void confirmSale(string paymentType)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                using (var dbContex = new ShopManagementEntities())
                {
                    DialogResult result = MessageBox.Show("Satışı gerçekleştirmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Stok kontrolü
                        bool isStockSufficient = stockDecrease();
                        if (!isStockSufficient)
                        {
                            MessageBox.Show("İşlem durduruldu. Stok yetersiz!");
                            return;
                        }
                        var receipt = new receiptTbl
                        {
                            receiptFormationDate = DateTime.Now,
                            receiptTotalKDV = Convert.ToDouble(totalKDVLabel.Text),
                            receiptTotalPrice = Convert.ToDouble(totalPriceLabel.Text),
                            receiptCustomerPay = Convert.ToDouble(customerPayLabel.Text),
                            receiptCashChange = Convert.ToDouble(cashChangeLabel.Text),
                            receiptPaymentType = paymentType
                        };
                        dbContex.receiptTbl.Add(receipt);
                        dbContex.SaveChanges();

                        int newReceiptID = receipt.receiptID;
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            int addProductID = Convert.ToInt32(row.Cells["productID"].Value);
                            if (addProductID != null || addProductID.ToString() != "")
                            {
                                var receiptDetail = new receiptDetailTbl
                                {
                                    receiptID = newReceiptID,
                                    productID = Convert.ToInt32(row.Cells["ProductID"].Value),
                                    productQuantity = Convert.ToDouble(row.Cells["productQuantity"].Value),
                                    productTotalPrice = Convert.ToDouble(row.Cells["productTotalPrice"].Value),
                                    productRebate = false
                                };
                                dbContex.receiptDetailTbl.Add(receiptDetail);
                                dbContex.SaveChanges();
                            }
                        }

                        ClearAll();
                        MessageBox.Show("Satış Başarıyla Gerçekleşti");
                    }
                    else
                    {
                        MessageBox.Show("Ekleme işlemi iptal edildi.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen Ürün Giriniz! ");
            }
        }
        private void TotalKDV()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                double sumKDV = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    double priceCell = Convert.ToDouble(dataGridView1.Rows[i].Cells["productQuantityPrice"].Value);
                    double quantityCell = Convert.ToDouble(dataGridView1.Rows[i].Cells["productQuantity"].Value);
                    double totalPriceCell = Convert.ToDouble(dataGridView1.Rows[i].Cells["productTotalPrice"].Value);
                    double totalKDV = totalPriceCell - (priceCell * quantityCell);
                    sumKDV += totalKDV;
                }


                totalKDVLabel.Text = Math.Round(sumKDV, 2).ToString();
                // totalKDVLabel.Text = Math.Round(sumKDV, 2).ToString("C2");
            }
            else
            {
                totalKDVLabel.Text = 0.ToString();
            }
        }
        private void TotalPrice()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                double sum = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    var totalPriceCell = dataGridView1.Rows[i].Cells["productTotalPrice"].Value;


                    if (totalPriceCell != null && double.TryParse(totalPriceCell.ToString(), out double totalPrice))
                    {
                        sum += totalPrice;
                    }
                }
                totalPriceLabel.Text = sum.ToString();
                // totalPriceLabel.Text = sum.ToString("C2");
            }
            else
            {
                totalPriceLabel.Text = 0.ToString();
                // totalPriceLabel.Text = 0.ToString("C2"); 
            }
        }
        private void saleCancelButton_Click(object sender, EventArgs e)
        {
            ClearAll();

        }
        private void fastButton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (b != null)
            {
                int buttonID = Convert.ToInt16(b.Name.ToString().Substring(10, 1));

                if (UserClass.UserLevel == 1 || UserClass.UserLevel == 2)
                {
                    fastButtonAddForm f = new fastButtonAddForm();
                    f.buttonNoLabel.Text = buttonID.ToString();
                    f.ShowDialog();
                }
                else
                {
                    if (b.Text.StartsWith("-"))
                    {
                        fastButtonAddForm f = new fastButtonAddForm();
                        f.buttonNoLabel.Text = buttonID.ToString();
                        f.ShowDialog();
                    }
                    else
                    {
                        // Düğmede "-" yoksa ürün barkodu alınır ve textbox'a yazılır
                        var product_Barcode = dbContex.fastButtonTbl
                            .Where(f => f.productID == buttonID)
                            .Select(f => f.productBarcode)
                            .FirstOrDefault();

                        var product = dbContex.productTbl
                            .Where(p => p.productBarcode == product_Barcode)
                            .FirstOrDefault();

                        if (product != null)
                        {
                            calculateNumberTxt.Text = product.productBarcode.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Ürün bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        public void fastButtonLoad()
        {
            var fastProducts = dbContex.fastButtonTbl.ToList();
            foreach (var product in fastProducts)
            {
                Button fast = this.Controls.Find("fastButton" + product.productID, true).FirstOrDefault() as Button;
                if (fast != null)
                {
                    fast.Text = product.productName + "\n " + product.productPrice?.ToString("C2");
                }
            }
        }
        private void ClearAll()
        {
            dataGridView1.Rows.Clear();
            totalPriceLabel.Text = "0";
            totalKDVLabel.Text = "0";
            customerPayLabel.Text = "0";
            cashChangeLabel.Text = "0";
            calculateNumberTxt.Text = string.Empty;
            SetOperationLabel("Barkod :", true, "Miktar :");
            quantityTxt.Text = "1";
        }
        private void calculateNumberTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //  if (calculateOperationLabel.Text== "Barkod :" && calculateOperationLabel.Text == "Ödeme :") {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            //  }
        }
        private void quantityTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08 && e.KeyChar != (char)44 && e.KeyChar != (char)45)
            {
                e.Handled = true;
            }
        }

        private void cashRegisterForm_Load(object sender, EventArgs e)
        {
            fastButtonLoad();
        }

        public bool stockDecrease()
        {
            bool isStockSufficient = true;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string barcode = row.Cells["productBarcode"].Value.ToString();
                int quantity = Convert.ToInt32(row.Cells["productQuantity"].Value);
                var productUpdate = dbContex.productTbl.FirstOrDefault(p => p.productBarcode == barcode);

                if (productUpdate != null && productUpdate.productStockQuantity >= quantity)
                {
                    productUpdate.productStockQuantity -= quantity;
                    dbContex.Entry(productUpdate).State = EntityState.Modified;
                }
                else
                {
                    MessageBox.Show($"Ürün stokta yetersiz: {barcode}");
                    isStockSufficient = false;
                }
            }

            if (isStockSufficient)
            {
                dbContex.SaveChanges();
            }

            return isStockSufficient;
        }

    }
}
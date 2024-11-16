using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }
        ShopManagementEntities dbContex=new ShopManagementEntities();   
     
        private void picClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        #region Clicks
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
        private void takeActionButton_Click(object sender, EventArgs e)
        {
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
                                    int availableQuantity = Convert.ToInt32(dataGridView1.Rows[i].Cells["productQuantity"].Value);
                                    dataGridView1.Rows[i].Cells["productQuantity"].Value = availableQuantity + Convert.ToInt32( quantityTxt.Text);

                                    // Toplam fiyatı tekrar hesapla
                                    double totalPrice = (product.productKDVRate.Value) * (product.productPrice.Value) * (Convert.ToUInt32(dataGridView1.Rows[i].Cells["productQuantity"].Value));
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
                            dataGridView1.Rows[newRow].Cells["productQuantity"].Value =quantityTxt.Text;
                            dataGridView1.Rows[newRow].Cells["productKDVRate"].Value = product.productKDVRate.ToString();
                            double totalPrice = (product.productKDVRate.Value) * (product.productPrice.Value) * (Convert.ToUInt32(dataGridView1.Rows[newRow].Cells["productQuantity"].Value));
                            dataGridView1.Rows[newRow].Cells["productTotalPrice"].Value = totalPrice; 
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Barkod girmediniz");
                }
            }

            if (calculateOperationLabel.Text == "İade :")
            {
                if (calculateNumberTxt.Text != "")
                {

                }
                else { MessageBox.Show("Adet girmediniz"); }
            }

            if (calculateOperationLabel.Text == "Ürün Giriniz :")
            {
                if (calculateNumberTxt.Text != "")
                {

                }
                else { MessageBox.Show("Ürün girmediniz"); }
            }
            
            if (calculateOperationLabel.Text == "Ödeme :")
            {
                customerPayLabel.Text = calculateNumberTxt.Text;
                ChangeMoneyCalculate();
                calculateNumberTxt.Text = "";
            };

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
                MessageBox.Show("Lütfen geçerli bir ödeme giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Eğer başka bir hata meydana gelirse
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
            if (e.ColumnIndex >= dataGridView1.Columns["deleteProduct"].Index && e.RowIndex>=0)
            {
                DialogResult result = MessageBox.Show("Ürünü silmek istediğinizden emin misiniz? ", "Silme Onayı", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) 
                {
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                    TotalPrice();   
                    TotalKDV();
                    ChangeMoneyCalculate();
                    
                }
            }
        }

        private void CalculatorNumbersButton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == ",")
            {
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
        private void QuantityCalcToFalse() 
        {
            quantityLabel.Visible = false;
            quantityTxt.Visible = false;
        }

        private void cashButton_Click(object sender, EventArgs e)
        {
            confirmSale("Cash");
        }
        private void confirmSale( string paymentType ) 
        {
            using (var dbContex = new ShopManagementEntities())
            {
                DialogResult result = MessageBox.Show("Bu kaydı eklemek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var receipt = new receiptTbl
                    {
                        receiptFormationDate = DateTime.Now,
                        receiptTotalKDV = Convert.ToDouble(totalKDVLabel.Text),
                        receiptTotalPrice = Convert.ToDouble(totalPriceLabel.Text),
                        receiptPaymentType = paymentType
                    };
                    dbContex.receiptTbl.Add(receipt);
                    dbContex.SaveChanges();
                    MessageBox.Show("Eklendi");
                }
                else
                {
                    MessageBox.Show("Ekleme işlemi iptal edildi.");
                }
            }

        }
    }
}

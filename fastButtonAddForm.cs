using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Management
{
    public partial class fastButtonAddForm : Form
    {
        public fastButtonAddForm()
        {
            InitializeComponent();
        }
        ShopManagementEntities dbContex= new ShopManagementEntities();

        private void productSearch_TextChanged(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(productSearchTxt.Text))
            {
                dataGridView1.Rows.Clear();
                CallStockTable(); 
            }
            else
            {
                dataGridView1.Rows.Clear();
                string product_Name = productSearchTxt.Text;
                var products = dbContex.productTbl.Where(p => p.productName.Contains(product_Name)).ToList();

                foreach (var item in products)
                {
                    int rowIndex = dataGridView1.Rows.Add();
                    dataGridView1.Rows[rowIndex].Cells["productID"].Value = item.productID.ToString();
                    dataGridView1.Rows[rowIndex].Cells["productName"].Value = item.productName.ToString();
                    dataGridView1.Rows[rowIndex].Cells["productBarcode"].Value = item.productBarcode.ToString();
                    dataGridView1.Rows[rowIndex].Cells["productPrice"].Value = item.productPrice.ToString();
                }
            }
        }
        private void CallStockTable()
        {
            var products = dbContex.productTbl.ToList(); 
            foreach (var item in products)
            {
                int rowIndex = dataGridView1.Rows.Add();
                dataGridView1.Rows[rowIndex].Cells["productID"].Value = item.productID.ToString();
                dataGridView1.Rows[rowIndex].Cells["productName"].Value = item.productName.ToString();
                dataGridView1.Rows[rowIndex].Cells["productBarcode"].Value = item.productBarcode.ToString();
                dataGridView1.Rows[rowIndex].Cells["productPrice"].Value = item.productPrice.ToString();
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string barcode = dataGridView1.CurrentRow.Cells["productBarcode"].Value.ToString();
            string name = dataGridView1.CurrentRow.Cells["productName"].Value.ToString();
            double price = Convert.ToDouble(dataGridView1.CurrentRow.Cells["productPrice"].Value.ToString());
            int buttonID = Convert.ToInt16(buttonNoLabel.Text);
            var updateButton = dbContex.fastButtonTbl.Find(buttonID);
            updateButton.productBarcode = barcode;
            updateButton.productPrice = price;
            updateButton.productName = name;
            dbContex.SaveChanges();
            MessageBox.Show("Tanımlandı");

            cashRegisterForm c = (cashRegisterForm)Application.OpenForms["cashRegisterForm"];
            if (c != null)
            {
                Button b = c.Controls.Find("fastButton" + buttonID, true).FirstOrDefault() as Button;
                b.Text = name + "\n "+ price.ToString("C2");
              }
        }

        private void fastButtonAddForm_Load(object sender, EventArgs e)
        {
            CallStockTable();
        }
    }
}

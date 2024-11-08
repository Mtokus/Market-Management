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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        ShopManagementEntities db = new ShopManagementEntities();
        private void picClose_Click(object sender, EventArgs e)
        {
            Close();   
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();
            var userFromDB = db.staffTbl.FirstOrDefault(a => a.staffTCNumber == userName && a.staffPassword == password);
            if (userFromDB != null)
            {
                MessageBox.Show("Giriş Başarılı");
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide(); 
                
                
            }
            else {
                MessageBox.Show("giriş Başarısız");


                    } 
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}

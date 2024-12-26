using Market_Management.Class;
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
            Application.Exit();  
        }
        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            string userName = this.txtUserName.Text.Trim();
            string password = this.txtPassword.Text.Trim();
            staffTbl userFromDB = this.db.staffTbl.FirstOrDefault((staffTbl a) => a.staffTCNumber == userName && a.staffPassword == password);
            
            if (userFromDB != null)
            {
                UserClass.UserLevel = Convert.ToInt32(userFromDB.staffPositionID);
                UserClass.FullName = userFromDB.staffNameSurname.ToString();
                MessageBox.Show("Giriş Başarılı");
                if (UserClass.UserLevel == 6)
                {
                    cashRegisterForm f = new cashRegisterForm();
                    f.Show();
                    Hide();
                }

                else
                {
                    Form1 form = new Form1();
                    form.Show();
                    form.labelUserNameOperationPanel.Text = UserClass.FullName;
                    Hide();
                }
            }
            else
            {
                MessageBox.Show("giriş Başarısız");
            }
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

    }
}

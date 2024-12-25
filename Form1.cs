using Market_Management.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Market_Management
{
    public partial class Form1 : Form
    {
        
        [DllImport("user32.dll")]
        public static extern void ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;
        public Form1()
        {
            InitializeComponent();
            panelHeader.MouseDown += panelHeader_MouseDown;
        }
        private void NewFormLoad(object Form)
        {
            if (this.operationPanel.Controls.Count > 0)
                this.operationPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.operationPanel.Controls.Add(f);
            this.operationPanel.Tag = f;
            f.Show();
        }
        private void stockManagementButton_Click(object sender, EventArgs e)
        {
            NewFormLoad(new stockManagementForm());
        }
        private void staffManagementButton_Click(object sender, EventArgs e)
        {
            NewFormLoad(new staffManagementForm());
        }
        private void salariesButton_Click(object sender, EventArgs e)
        {
            NewFormLoad (new receiptsForm());
        }
        private void cashRegisterButton_Click(object sender, EventArgs e)
        {
            cashRegisterForm cashRegisterForm = new cashRegisterForm();
            cashRegisterForm.ShowDialog();
        }
        private void userChangeButton_Click(object sender, EventArgs e)
        {
            Close();
            LoginForm f = new LoginForm();
            f.ShowDialog();
            
        }
        private void logoutButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {
            int userLevel = UserClass.UserLevel;
            int num = userLevel;
            if (num != 5)
            {
                if (num == 6)
                {
                    this.salariesButton.Enabled = false;
                    this.stockManagementButton.Enabled = false;
                    this.staffManagementButton.Enabled = false;
                    this.salariesButton.Text = this.salariesButton.Text + " (Yetkisiz)";
                    this.stockManagementButton.Text = this.stockManagementButton.Text + "(Yetkisiz)";
                    this.staffManagementButton.Text = this.staffManagementButton.Text + " (Yetkisiz)";
                }
            }
            else
            {
                this.stockManagementButton.Enabled = false;
                this.staffManagementButton.Enabled = false;
                this.stockManagementButton.Text = this.stockManagementButton.Text + "(Yetkisiz)";
                this.staffManagementButton.Text = this.staffManagementButton.Text + " (Yetkisiz)";
            }
        }
        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
    }
}

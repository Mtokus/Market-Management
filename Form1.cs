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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
        private void picClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void staffManagementButton_Click(object sender, EventArgs e)
        {
            NewFormLoad(new staffManagementForm());
        }
    }
}

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
    public partial class staffManagementForm : Form
    {
        public staffManagementForm()
        {
            InitializeComponent();
        }
        private void NewFormLoad(object Form)
        {
            if (this.panelStaffEntryExitOperation.Controls.Count > 0)
                this.panelStaffEntryExitOperation.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelStaffEntryExitOperation.Controls.Add(f);
            this.panelStaffEntryExitOperation.Tag = f;
            f.Show();
        }
        private void staffManagementForm_Load_1(object sender, EventArgs e)
        {
           NewFormLoad(new staffEntryExitForm());
        }

        private void buttonStaffEntryExit_Click(object sender, EventArgs e)
        {
            NewFormLoad(new staffEntryExitForm());
        }

        private void buttonStaffOperation_Click(object sender, EventArgs e)
        {
            staffOperationForm staffOperationForm = new staffOperationForm();
            staffOperationForm.ShowDialog();
        }

        
    }
}

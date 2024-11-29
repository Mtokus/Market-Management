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
    public partial class staffEntryExitAddForm : Form
    {
        public staffEntryExitAddForm()
        {
            InitializeComponent();
        }
        ShopManagementEntities dbContex=new ShopManagementEntities();   

        private void btnNewEntryStaff_Click(object sender, EventArgs e)
        {
            var addNewEntryExit = new StaffEntryExitTbl()
            {
                staffID = Convert.ToInt32(txtStaffID.Text),
                entryDateTime = pickerStaffEntryTime.Value,
                exitDateTime = pickerStaffExitTime.Value,
                leaveStatus = checkLeaveStatus.Checked,

            };

           /* StaffEntryExitTbl addNewEntryExit= new StaffEntryExitTbl();
            addNewEntryExit.staffID=Convert.ToInt32(txtStaffID.Text) ;
            addNewEntryExit.entryDateTime = pickerStaffEntryTime.Value;
            addNewEntryExit.exitDateTime=pickerStaffExitTime.Value;
            addNewEntryExit.leaveStatus = checkLeaveStatus.Checked;
           */
            dbContex.StaffEntryExitTbl.Add(addNewEntryExit);
            dbContex.SaveChanges();
            MessageBox.Show("kaydedildi");
        }
        private void staffEntryExitAddForm_Load(object sender, EventArgs e)
        {
            CallStaffNameForCombobox();
                
        }
        private void CallStaffNameForCombobox()
        {
            var staffNameSurname=dbContex.staffTbl.ToList();
            foreach (var staff in staffNameSurname)
            {
                comboBoxStaffName.Items.Add(new
                {
                    Text=staff.staffNameSurname,
                    Value=staff.staffID
                });
            }
            comboBoxStaffName.DisplayMember = "Text";
            comboBoxStaffName.ValueMember = "Value";
        }
     
        private void comboBoxStaffName_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboBoxStaffName.SelectedIndex != -1)
            {
                var staffNameSurname = dbContex.staffTbl
                    .FirstOrDefault(s => s.staffNameSurname == comboBoxStaffName.Text);
                if (staffNameSurname != null)
                {
                    txtStaffID.Text = staffNameSurname.staffID.ToString();
                }
            }
        }
        private void txtStaffID_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtStaffID.Text))
            {
                if (int.TryParse(txtStaffID.Text, out int staffId))
                {
                    var staff = dbContex.staffTbl.FirstOrDefault(s => s.staffID == staffId);

                    if (staff != null)
                    {
                        comboBoxStaffName.Text = staff.staffNameSurname;
                    }
                    else
                    {
                        comboBoxStaffName.Text = string.Empty; 
                    }
                }
                else
                {
                    comboBoxStaffName.Text = string.Empty; 
                }
            }
        }

    }


}

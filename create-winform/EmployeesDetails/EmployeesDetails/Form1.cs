using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesDetails
{
    public partial class frmEmployeesDetails : Form
    {
      
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbTitle_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtEmployeeID_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmEmployeesDetails_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String EmployeeID = txtEmployeeID.Text;
            String EmployeeNme = txtEmployeeName.Text;
            String Phone = mtxtPhone.Text;
            String Gender = (rdFemale.Checked ? "Female" : "Male");
            String Degree = cboDegree.Text;
            StringBuilder builder = new StringBuilder();
            builder.Append($"Employee ID:{EmployeeID}\n");
            builder.Append($"Employee Name:{EmployeeNme}\n");
            builder.Append($"Phone:{Phone}\n");
            builder.Append($"Gender:{Gender}\n");
            builder.Append($"Degree ID:{Degree}\n");
            MessageBox.Show(builder.ToString(),"Employee Details");

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

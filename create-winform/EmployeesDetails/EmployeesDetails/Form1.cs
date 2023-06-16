using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            
            string employeeID = txtEmployeeID.Text;
            string employeeName = txtEmployeeName.Text;
            string phone = mtxtPhone.Text;
            string degree = cboDegree.SelectedItem.ToString();
            string gender = (rdFemale.Checked ? "Female" : "Male");

            string data = $"{employeeID},{employeeName},{phone},{degree},{gender}";

            try
            {
                using (StreamWriter writer = new StreamWriter("Employee.txt", true))
                {
                    writer.WriteLine(data);
                }

                MessageBox.Show("Information saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the information: {ex.Message}");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbTitle_Click_1(object sender, EventArgs e)
        {

        }
    }
}

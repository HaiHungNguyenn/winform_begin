using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ConnectDB
{
    public partial class Form1 : Form

    {
        String strCon = @"Data Source=LAPTOP-55QLG1BQ\MSSQLSERVER01;Initial Catalog=CarShowroom;Integrated Security=True";
        SqlConnection sqlCon = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try { 
                if (sqlCon == null) { sqlCon = new SqlConnection(strCon); }
               
                if (sqlCon.State == ConnectionState.Closed) {
                    sqlCon.Open();
                    MessageBox.Show("sucessfully connect");
                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon != null && sqlCon.State == ConnectionState.Open) { sqlCon.Close(); MessageBox.Show("disconnected"); }
                else {
                    MessageBox.Show("not connect yet");
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

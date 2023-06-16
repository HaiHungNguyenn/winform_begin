using System.Data;

namespace DataGridView2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ProductID", typeof(int));
            dt.Columns.Add("ProductName", typeof(string));
            dt.Columns.Add("UnitPrice", typeof(decimal));
            dt.Rows.Add(1, "Mouse", 10);
            dt.Rows.Add(2, "Monitor", 30);
            dgvProducts.DataSource = dt;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            List<dynamic> list = new List<dynamic> {
                new { ProductID=3,ProductName="Speaker",UnitPrice=2},
                new { ProductID=4,ProductName="keyboard",UnitPrice=4}
            };
            dgvProducts.DataSource = list;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            DataTable dt = new DataTable("Products");
            dt.Columns.Add("ProductID", typeof(int));
            dt.Columns.Add("ProductName", typeof(string));
            dt.Columns.Add("UnitPrice", typeof(decimal));

            dt.Rows.Add(1, "table", 10);
            dt.Rows.Add(2, "chair", 30);

            ds.Tables.Add(dt);

            dgvProducts.DataSource = ds.Tables["Products"];
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            List<dynamic> list = new List<dynamic> {
                new { ProductID=3,ProductName="Speaker",UnitPrice=2},
                new { ProductID=4,ProductName="keyboard",UnitPrice=4}
            };
            dgvProducts.DataSource = list;
        }
    }
}
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace sql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // string s = @"Data Source=DUy;Initial Catalog=CSDL;Integrated Security=True"; ;
            // SqlConnection cnn = new SqlConnection(s);
            // string query = " select * from SV";

            // SqlDataAdapter adt= new SqlDataAdapter(query,cnn);   
            // DataSet ds = new DataSet();
            // DataTable dt = new DataTable();
            // cnn.Open();
            //// adt.Fill(ds,"SV");
            //adt.Fill(dt);
            // cnn.Close();
            // //      dataGridView1.DataSource= ds.Tables[0];
            // dataGridView1.DataSource = dt;
            string query = "select * from SV";
            dataGridView1.DataSource = DbHelper.Instance.gettable(query);

        }
       
    }
}